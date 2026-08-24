using System.Data;
using Systema.De_Gestion.Academica.BL;
using Systema.De_Gestion.Academica.EN;
using Systema.De_Gestion.Academica.LN;

namespace Systema.De_Gestion.Academica.UI
{
    public partial class FrmReporte : Form
    {
        private readonly ReporteBL reporteBL = new ReporteBL();
        private readonly CatalogoBL catalogoBL = new CatalogoBL();
        private readonly Usuario? usuarioActual;
        private bool configurando;

        public FrmReporte() : this(null)
        {
        }

        public FrmReporte(Usuario? usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();
            cmbGrado.SelectedIndexChanged += (_, _) => CargarEstudiantesDelGrado();
            CargarFiltros();
        }

        private void CargarFiltros()
        {
            try
            {
                configurando = true;
                if (cmbTipoReporte.Items.Count > 0)
                    cmbTipoReporte.SelectedIndex = 0;
                if (cmbPeriodo.Items.Count > 0)
                    cmbPeriodo.SelectedIndex = 0;

                bool restringido = usuarioActual?.Rol is "Estudiante" or "Padre";
                if (restringido)
                {
                    CargarEstudianteVinculado();
                    cmbGrado.Enabled = false;
                    cmbEstudiante.Enabled = false;
                }
                else
                {
                    Enlazar(cmbGrado, catalogoBL.ObtenerGrados());
                    configurando = false;
                    CargarEstudiantesDelGrado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los filtros.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                configurando = false;
            }
        }

        private void CargarEstudianteVinculado()
        {
            if (usuarioActual?.IdEstudiante is not int idEstudiante)
                throw new UnauthorizedAccessException(
                    "La cuenta no tiene un estudiante vinculado. Comuníquese con el administrador.");

            Estudiante estudiante = catalogoBL.ObtenerEstudiantePorId(idEstudiante)
                ?? throw new InvalidOperationException("El estudiante vinculado ya no existe.");

            OpcionCatalogo? grado = catalogoBL.ObtenerGrados().FirstOrDefault(
                g => string.Equals(g.Nombre, estudiante.Grado + " " + estudiante.Seccion,
                    StringComparison.OrdinalIgnoreCase));

            if (grado == null)
                throw new InvalidOperationException("El grado del estudiante no está configurado.");

            Enlazar(cmbGrado, new List<OpcionCatalogo> { grado });
            Enlazar(cmbEstudiante, new List<OpcionCatalogo>
            {
                new OpcionCatalogo
                {
                    Id = estudiante.IdEstudiante,
                    Nombre = estudiante.Nombre + " " + estudiante.Apellido
                }
            });
        }

        private void CargarEstudiantesDelGrado()
        {
            if (configurando || cmbGrado.SelectedItem is not OpcionCatalogo grado)
                return;

            List<OpcionCatalogo> opciones = catalogoBL
                .ObtenerEstudiantesPorGrado(grado.Id)
                .Select(e => new OpcionCatalogo
                {
                    Id = e.IdEstudiante,
                    Nombre = e.Nombre + " " + e.Apellido
                })
                .ToList();
            Enlazar(cmbEstudiante, opciones);
        }

        private static void Enlazar(ComboBox combo, List<OpcionCatalogo> opciones)
        {
            combo.DataSource = null;
            combo.DisplayMember = nameof(OpcionCatalogo.Nombre);
            combo.ValueMember = nameof(OpcionCatalogo.Id);
            combo.DataSource = opciones;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cmbEstudiante.SelectedItem is not OpcionCatalogo estudiante ||
                cmbGrado.SelectedItem is not OpcionCatalogo grado ||
                string.IsNullOrWhiteSpace(cmbPeriodo.Text))
            {
                MessageBox.Show("Seleccione estudiante, grado y periodo.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string periodo = cmbPeriodo.Text;
                DataTable datos = reporteBL.ObtenerCalificaciones(estudiante.Id, periodo);

                dgvReporte.DataSource = null;
                dgvReporte.Columns.Clear();
                dgvReporte.AutoGenerateColumns = true;
                dgvReporte.DataSource = datos;
                dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                lblDatosEstudiante.Text = "Estudiante: " + estudiante.Nombre;
                lblDatosGrado.Text = "Grado / Sección: " + grado.Nombre;
                lblDatosPeriodo.Text = "Periodo: " + periodo;
                lblPromedio.Text = reporteBL.ObtenerPromedio(estudiante.Id, periodo).ToString("0.00");

                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron calificaciones para el periodo seleccionado.",
                        "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
