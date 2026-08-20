using System;
using System.Data;
using System.Windows.Forms;
using Systema.De_Gestion.Academica.BL;

namespace Systema.De_Gestion.Academica.UI
{
    public partial class FrmReporte : Form
    {
        private readonly ReporteBL reporteBL;

        public FrmReporte()
        {
            InitializeComponent();

            reporteBL =
                new ReporteBL();

            ConfigurarFormulario();
        }

        // =====================================================
        // CONFIGURAR FORMULARIO
        // =====================================================

        private void ConfigurarFormulario()
        {
            if (cmbTipoReporte.Items.Count > 0)
            {
                cmbTipoReporte.SelectedIndex = 0;
            }

            if (cmbPeriodo.Items.Count > 0)
            {
                cmbPeriodo.SelectedIndex = 0;
            }

            if (cmbGrado.Items.Count > 0)
            {
                cmbGrado.SelectedIndex = 0;
            }

            if (cmbEstudiante.Items.Count > 0)
            {
                cmbEstudiante.SelectedIndex = 0;
            }
        }

        // =====================================================
        // BOTÓN GENERAR
        // =====================================================

        private void btnGenerar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                // =============================================
                // VALIDAR ESTUDIANTE
                // =============================================

                if (cmbEstudiante.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un estudiante.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // =============================================
                // VALIDAR GRADO
                // =============================================

                if (cmbGrado.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un grado.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // =============================================
                // VALIDAR PERIODO
                // =============================================

                if (cmbPeriodo.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un periodo.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string estudiante =
                    cmbEstudiante.Text;

                string grado =
                    cmbGrado.Text;

                string periodo =
                    cmbPeriodo.Text;

                // =============================================
                // OBTENER DATOS
                // =============================================

                DataTable datos =
     reporteBL.ObtenerCalificaciones(
         estudiante,
         grado,
         periodo);

                // =============================================
                // MOSTRAR DATOS
                // =============================================

                // Quitar las columnas creadas anteriormente
                dgvReporte.DataSource = null;
                dgvReporte.Columns.Clear();

                // Crear las columnas automáticamente desde SQL
                dgvReporte.AutoGenerateColumns = true;

                // Cargar los datos
                dgvReporte.DataSource = datos;

                // Ajustar las columnas
                dgvReporte.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                // =============================================
                // MOSTRAR DATOS DEL ESTUDIANTE
                // =============================================

                lblDatosEstudiante.Text =
                    "Estudiante: " +
                    estudiante;

                lblDatosGrado.Text =
                    "Grado / Sección: " +
                    grado;

                lblDatosPeriodo.Text =
                    "Periodo: " +
                    periodo;

                // =============================================
                // PROMEDIO
                // =============================================

                decimal promedio =
                    reporteBL.ObtenerPromedio(
                        estudiante,
                        grado,
                        periodo);

                lblPromedio.Text =
                    promedio.ToString("0.00");

                // =============================================
                // COMPROBAR SI HAY DATOS
                // =============================================

                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron calificaciones para " +
                        estudiante +
                        " en el " +
                        periodo +
                        ".",
                        "Sin resultados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    lblPromedio.Text =
                        "0.00";

                    return;
                }

                MessageBox.Show(
                    "Reporte generado correctamente.",
                    "Reporte",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar el reporte:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}