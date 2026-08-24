using System.Globalization;
using Systema.De_Gestion.Academica.BL;
using Systema.De_Gestion.Academica.EN;
using Systema.De_Gestion.Academica.LN;

namespace Systema.De_Gestion.Academica.UI
{
    public partial class FrmCalificacion : Form
    {
        private readonly CalificacionBL calificacionBL = new CalificacionBL();
        private readonly CatalogoBL catalogoBL = new CatalogoBL();
        private List<Estudiante> estudiantes = new List<Estudiante>();

        public FrmCalificacion()
        {
            InitializeComponent();
            ConfigurarEventos();
            CargarCatalogos();
        }

        private void ConfigurarEventos()
        {
            cmbGrado.SelectedIndexChanged += (_, _) => CargarEstudiantes();
            cmbMateria.SelectedIndexChanged += (_, _) => CargarEstudiantes();
            cmbPeriodo.SelectedIndexChanged += (_, _) => CargarEstudiantes();
            txtBuscar.TextChanged += (_, _) => MostrarEstudiantes(txtBuscar.Text);
        }

        private void CargarCatalogos()
        {
            try
            {
                Enlazar(cmbGrado, catalogoBL.ObtenerGrados());
                Enlazar(cmbMateria, catalogoBL.ObtenerMaterias());
                Enlazar(cmbDocente, catalogoBL.ObtenerDocentes());

                if (cmbPeriodo.Items.Count > 0)
                    cmbPeriodo.SelectedIndex = 0;

                txtBuscar.Clear();
                CargarEstudiantes();
            }
            catch (Exception ex)
            {
                MostrarError("No se pudieron cargar los catálogos.", ex);
            }
        }

        private static void Enlazar(ComboBox combo, List<OpcionCatalogo> opciones)
        {
            combo.DataSource = null;
            combo.DisplayMember = nameof(OpcionCatalogo.Nombre);
            combo.ValueMember = nameof(OpcionCatalogo.Id);
            combo.DataSource = opciones;
        }

        private void CargarEstudiantes()
        {
            if (cmbGrado.SelectedItem is not OpcionCatalogo grado)
                return;

            try
            {
                estudiantes = catalogoBL.ObtenerEstudiantesPorGrado(grado.Id);
                MostrarEstudiantes(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MostrarError("No se pudieron cargar los estudiantes.", ex);
            }
        }

        private void MostrarEstudiantes(string filtro)
        {
            dgvCalificaciones.Rows.Clear();
            string texto = filtro.Trim();

            Dictionary<int, decimal> notas = new Dictionary<int, decimal>();
            if (cmbGrado.SelectedItem is OpcionCatalogo grado &&
                cmbMateria.SelectedItem is OpcionCatalogo materia &&
                !string.IsNullOrWhiteSpace(cmbPeriodo.Text))
            {
                notas = calificacionBL.ObtenerNotas(grado.Id, materia.Id, cmbPeriodo.Text);
            }

            foreach (Estudiante estudiante in estudiantes.Where(e =>
                         string.IsNullOrWhiteSpace(texto) ||
                         e.Codigo.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                         (e.Nombre + " " + e.Apellido).Contains(texto, StringComparison.OrdinalIgnoreCase)))
            {
                int indice = dgvCalificaciones.Rows.Add(
                    estudiante.Codigo,
                    estudiante.Nombre + " " + estudiante.Apellido,
                    notas.TryGetValue(estudiante.IdEstudiante, out decimal nota)
                        ? nota.ToString("0.00", CultureInfo.CurrentCulture)
                        : string.Empty);
                dgvCalificaciones.Rows[indice].Tag = estudiante.IdEstudiante;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbGrado.SelectedItem is not OpcionCatalogo grado ||
                cmbMateria.SelectedItem is not OpcionCatalogo materia ||
                cmbDocente.SelectedItem is not OpcionCatalogo docente ||
                string.IsNullOrWhiteSpace(cmbPeriodo.Text))
            {
                MessageBox.Show("Complete grado, periodo, materia y docente.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var calificaciones = new List<Calificacion>();
                foreach (DataGridViewRow fila in dgvCalificaciones.Rows)
                {
                    if (fila.Tag is not int idEstudiante)
                        continue;

                    string textoNota = Convert.ToString(fila.Cells["Nota"].Value)?.Trim() ?? string.Empty;
                    string nombre = Convert.ToString(fila.Cells["Estudiante"].Value) ?? string.Empty;
                    if (!decimal.TryParse(textoNota, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal nota) &&
                        !decimal.TryParse(textoNota, NumberStyles.Number, CultureInfo.InvariantCulture, out nota))
                    {
                        throw new ArgumentException("La nota de " + nombre + " no es válida.");
                    }

                    calificaciones.Add(new Calificacion
                    {
                        IdEstudiante = idEstudiante,
                        NombreEstudiante = nombre,
                        IdGrado = grado.Id,
                        NombreGrado = grado.Nombre,
                        IdMateria = materia.Id,
                        NombreMateria = materia.Nombre,
                        IdDocente = docente.Id,
                        NombreDocente = docente.Nombre,
                        Periodo = cmbPeriodo.Text,
                        Nota = nota
                    });
                }

                int guardadas = calificacionBL.RegistrarCalificaciones(calificaciones);
                MessageBox.Show(
                    $"Se guardaron {guardadas} calificaciones correctamente.",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                CargarEstudiantes();
            }
            catch (Exception ex)
            {
                MostrarError("No se guardaron las calificaciones. Ningún registro fue modificado.", ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        private static void MostrarError(string mensaje, Exception ex)
        {
            MessageBox.Show(mensaje + "\n\n" + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
