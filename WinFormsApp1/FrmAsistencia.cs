using Systema.De_Gestion.Academica.BL;
using Systema.De_Gestion.Academica.EN;
using Systema.De_Gestion.Academica.LN;

namespace Systema.De_Gestion.Academica.UI
{
    public partial class FrmAsistencia : Form
    {
        private readonly AsistenciaBL asistenciaBL = new AsistenciaBL();
        private readonly CatalogoBL catalogoBL = new CatalogoBL();

        public FrmAsistencia()
        {
            InitializeComponent();
            dtpFecha.Value = DateTime.Today;
            ConfigurarEventos();
            CargarCatalogos();
        }

        private void ConfigurarEventos()
        {
            cmbGrado.SelectedIndexChanged += (_, _) => CargarEstudiantes();
            cmbMateria.SelectedIndexChanged += (_, _) => CargarEstudiantes();
            dtpFecha.ValueChanged += (_, _) => CargarEstudiantes();
        }

        private void CargarCatalogos()
        {
            try
            {
                Enlazar(cmbGrado, catalogoBL.ObtenerGrados());
                Enlazar(cmbMateria, catalogoBL.ObtenerMaterias());
                Enlazar(cmbDocente, catalogoBL.ObtenerDocentes());
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
            if (cmbGrado.SelectedItem is not OpcionCatalogo grado ||
                cmbMateria.SelectedItem is not OpcionCatalogo materia)
            {
                return;
            }

            try
            {
                List<Estudiante> estudiantes = catalogoBL.ObtenerEstudiantesPorGrado(grado.Id);
                Dictionary<int, string> estados = asistenciaBL.ObtenerEstados(
                    grado.Id,
                    materia.Id,
                    dtpFecha.Value.Date);

                dgvAsistencia.Rows.Clear();
                foreach (Estudiante estudiante in estudiantes)
                {
                    int indice = dgvAsistencia.Rows.Add(
                        estudiante.Codigo,
                        estudiante.Nombre + " " + estudiante.Apellido,
                        estados.TryGetValue(estudiante.IdEstudiante, out string? estado)
                            ? estado
                            : "Presente");
                    dgvAsistencia.Rows[indice].Tag = estudiante.IdEstudiante;
                }
            }
            catch (Exception ex)
            {
                MostrarError("No se pudieron cargar los estudiantes.", ex);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbGrado.SelectedItem is not OpcionCatalogo grado ||
                cmbMateria.SelectedItem is not OpcionCatalogo materia ||
                cmbDocente.SelectedItem is not OpcionCatalogo docente)
            {
                MessageBox.Show("Complete grado, materia y docente.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var asistencias = new List<Asistencia>();
                foreach (DataGridViewRow fila in dgvAsistencia.Rows)
                {
                    if (fila.Tag is not int idEstudiante)
                        continue;

                    asistencias.Add(new Asistencia
                    {
                        IdEstudiante = idEstudiante,
                        NombreEstudiante = Convert.ToString(fila.Cells["Estudiante"].Value) ?? string.Empty,
                        IdGrado = grado.Id,
                        NombreGrado = grado.Nombre,
                        IdMateria = materia.Id,
                        NombreMateria = materia.Nombre,
                        IdDocente = docente.Id,
                        NombreDocente = docente.Nombre,
                        Fecha = dtpFecha.Value.Date,
                        Estado = Convert.ToString(fila.Cells["Estado"].Value) ?? string.Empty
                    });
                }

                int guardadas = asistenciaBL.RegistrarAsistencias(asistencias);
                MessageBox.Show(
                    $"Se guardaron {guardadas} registros de asistencia correctamente.",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                CargarEstudiantes();
            }
            catch (Exception ex)
            {
                MostrarError("No se guardó la asistencia. Ningún registro fue modificado.", ex);
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
