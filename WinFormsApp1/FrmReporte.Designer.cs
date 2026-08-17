namespace Systema.De.Gestion.Academica.UI
{
    partial class FrmReporte
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblEstudiante;

        private System.Windows.Forms.ComboBox cmbTipoReporte;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.ComboBox cmbEstudiante;

        private System.Windows.Forms.Button btnGenerar;

        private System.Windows.Forms.GroupBox grpVistaPrevia;

        private System.Windows.Forms.Label lblBoletin;
        private System.Windows.Forms.Label lblDatosEstudiante;
        private System.Windows.Forms.Label lblDatosGrado;
        private System.Windows.Forms.Label lblDatosPeriodo;

        private System.Windows.Forms.DataGridView dgvReporte;

        private System.Windows.Forms.Label lblPromedioTexto;
        private System.Windows.Forms.Label lblPromedio;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components =
                new System.ComponentModel.Container();

            this.lblTitulo =
                new System.Windows.Forms.Label();

            this.lblTipoReporte =
                new System.Windows.Forms.Label();

            this.lblPeriodo =
                new System.Windows.Forms.Label();

            this.lblGrado =
                new System.Windows.Forms.Label();

            this.lblEstudiante =
                new System.Windows.Forms.Label();

            this.cmbTipoReporte =
                new System.Windows.Forms.ComboBox();

            this.cmbPeriodo =
                new System.Windows.Forms.ComboBox();

            this.cmbGrado =
                new System.Windows.Forms.ComboBox();

            this.cmbEstudiante =
                new System.Windows.Forms.ComboBox();

            this.btnGenerar =
                new System.Windows.Forms.Button();

            this.grpVistaPrevia =
                new System.Windows.Forms.GroupBox();

            this.lblBoletin =
                new System.Windows.Forms.Label();

            this.lblDatosEstudiante =
                new System.Windows.Forms.Label();

            this.lblDatosGrado =
                new System.Windows.Forms.Label();

            this.lblDatosPeriodo =
                new System.Windows.Forms.Label();

            this.dgvReporte =
                new System.Windows.Forms.DataGridView();

            this.lblPromedioTexto =
                new System.Windows.Forms.Label();

            this.lblPromedio =
                new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvReporte)).BeginInit();

            this.SuspendLayout();

            // ==========================================
            // FORMULARIO
            // ==========================================

            this.BackColor =
                System.Drawing.Color.White;

            this.ClientSize =
                new System.Drawing.Size(500, 600);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Generación de Reportes";

            // ==========================================
            // TITULO
            // ==========================================

            this.lblTitulo.AutoSize = true;

            this.lblTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    14F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblTitulo.Location =
                new System.Drawing.Point(18, 18);

            this.lblTitulo.Name =
                "lblTitulo";

            this.lblTitulo.Text =
                "Generación de Reportes";

            // ==========================================
            // TIPO DE REPORTE
            // ==========================================

            this.lblTipoReporte.AutoSize = true;

            this.lblTipoReporte.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8F
                );

            this.lblTipoReporte.Location =
                new System.Drawing.Point(18, 55);

            this.lblTipoReporte.Text =
                "Tipo de Reporte:";

            this.cmbTipoReporte.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbTipoReporte.FormattingEnabled = true;

            this.cmbTipoReporte.Items.AddRange(
                new object[]
                {
                    "Boletín de Calificaciones",
                    "Reporte de Asistencia",
                    "Reporte de Estudiantes",
                    "Reporte de Docentes"
                }
            );

            this.cmbTipoReporte.Location =
                new System.Drawing.Point(110, 52);

            this.cmbTipoReporte.Name =
                "cmbTipoReporte";

            this.cmbTipoReporte.Size =
                new System.Drawing.Size(220, 23);

            this.cmbTipoReporte.SelectedIndex = 0;

            // ==========================================
            // PERIODO
            // ==========================================

            this.lblPeriodo.AutoSize = true;

            this.lblPeriodo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8F
                );

            this.lblPeriodo.Location =
                new System.Drawing.Point(18, 83);

            this.lblPeriodo.Text =
                "Periodo:";

            this.cmbPeriodo.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbPeriodo.FormattingEnabled = true;

            this.cmbPeriodo.Items.AddRange(
                new object[]
                {
                    "Primer Periodo",
                    "Segundo Periodo",
                    "Tercer Periodo",
                    "Cuarto Periodo"
                }
            );

            this.cmbPeriodo.Location =
                new System.Drawing.Point(110, 80);

            this.cmbPeriodo.Name =
                "cmbPeriodo";

            this.cmbPeriodo.Size =
                new System.Drawing.Size(220, 23);

            this.cmbPeriodo.SelectedIndex = 1;

            // ==========================================
            // GRADO
            // ==========================================

            this.lblGrado.AutoSize = true;

            this.lblGrado.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8F
                );

            this.lblGrado.Location =
                new System.Drawing.Point(18, 111);

            this.lblGrado.Text =
                "Grado / Sección:";

            this.cmbGrado.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbGrado.FormattingEnabled = true;

            this.cmbGrado.Items.AddRange(
                new object[]
                {
                    "1° A",
                    "1° B",
                    "2° A",
                    "2° B",
                    "3° A",
                    "3° B"
                }
            );

            this.cmbGrado.Location =
                new System.Drawing.Point(110, 108);

            this.cmbGrado.Name =
                "cmbGrado";

            this.cmbGrado.Size =
                new System.Drawing.Size(220, 23);

            this.cmbGrado.SelectedIndex = 0;

            // ==========================================
            // ESTUDIANTE
            // ==========================================

            this.lblEstudiante.AutoSize = true;

            this.lblEstudiante.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8F
                );

            this.lblEstudiante.Location =
                new System.Drawing.Point(18, 139);

            this.lblEstudiante.Text =
                "Estudiante:";

            this.cmbEstudiante.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbEstudiante.FormattingEnabled = true;

            this.cmbEstudiante.Items.AddRange(
                new object[]
                {
                    "Juan Pérez",
                    "María López",
                    "Carlos García",
                    "Ana Martínez"
                }
            );

            this.cmbEstudiante.Location =
                new System.Drawing.Point(110, 136);

            this.cmbEstudiante.Name =
                "cmbEstudiante";

            this.cmbEstudiante.Size =
                new System.Drawing.Size(220, 23);

            this.cmbEstudiante.SelectedIndex = 0;

            // ==========================================
            // BOTÓN GENERAR
            // ==========================================

            this.btnGenerar.BackColor =
                System.Drawing.Color.FromArgb(
                    45,
                    45,
                    45
                );

            this.btnGenerar.FlatAppearance.BorderSize =
                0;

            this.btnGenerar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnGenerar.ForeColor =
                System.Drawing.Color.White;

            this.btnGenerar.Location =
                new System.Drawing.Point(18, 172);

            this.btnGenerar.Name =
                "btnGenerar";

            this.btnGenerar.Size =
                new System.Drawing.Size(445, 30);

            this.btnGenerar.Text =
                "▣   Generar Reporte (PDF)";

            this.btnGenerar.UseVisualStyleBackColor =
                false;

            this.btnGenerar.Click +=
                new System.EventHandler(
                    this.btnGenerar_Click
                );

            // ==========================================
            // VISTA PREVIA
            // ==========================================

            this.grpVistaPrevia.Controls.Add(
                this.lblBoletin
            );

            this.grpVistaPrevia.Controls.Add(
                this.lblDatosEstudiante
            );

            this.grpVistaPrevia.Controls.Add(
                this.lblDatosGrado
            );

            this.grpVistaPrevia.Controls.Add(
                this.lblDatosPeriodo
            );

            this.grpVistaPrevia.Controls.Add(
                this.dgvReporte
            );

            this.grpVistaPrevia.Controls.Add(
                this.lblPromedioTexto
            );

            this.grpVistaPrevia.Controls.Add(
                this.lblPromedio
            );

            this.grpVistaPrevia.Location =
                new System.Drawing.Point(18, 215);

            this.grpVistaPrevia.Name =
                "grpVistaPrevia";

            this.grpVistaPrevia.Size =
                new System.Drawing.Size(445, 330);

            this.grpVistaPrevia.TabStop = false;

            this.grpVistaPrevia.Text =
                "Vista Previa";

            // ==========================================
            // BOLETÍN
            // ==========================================

            this.lblBoletin.AutoSize = true;

            this.lblBoletin.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblBoletin.Location =
                new System.Drawing.Point(145, 30);

            this.lblBoletin.Text =
                "BOLETÍN DE CALIFICACIONES";

            // ==========================================
            // DATOS ESTUDIANTE
            // ==========================================

            this.lblDatosEstudiante.AutoSize = true;

            this.lblDatosEstudiante.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8F
                );

            this.lblDatosEstudiante.Location =
                new System.Drawing.Point(15, 55);

            this.lblDatosEstudiante.Text =
                "Estudiante: Juan Pérez";

            // ==========================================
            // DATOS GRADO
            // ==========================================

            this.lblDatosGrado.AutoSize = true;

            this.lblDatosGrado.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8F
                );

            this.lblDatosGrado.Location =
                new System.Drawing.Point(15, 72);

            this.lblDatosGrado.Text =
                "Grado / Sección: 1° A";

            // ==========================================
            // DATOS PERIODO
            // ==========================================

            this.lblDatosPeriodo.AutoSize = true;

            this.lblDatosPeriodo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8F
                );

            this.lblDatosPeriodo.Location =
                new System.Drawing.Point(15, 89);

            this.lblDatosPeriodo.Text =
                "Periodo: Segundo Periodo";

            // ==========================================
            // TABLA REPORTE
            // ==========================================

            this.dgvReporte.AllowUserToAddRows =
                false;

            this.dgvReporte.AllowUserToDeleteRows =
                false;

            this.dgvReporte.AllowUserToResizeRows =
                false;

            this.dgvReporte.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvReporte.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.dgvReporte.ColumnHeadersHeight =
                25;

            this.dgvReporte.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvReporte.Location =
                new System.Drawing.Point(15, 112);

            this.dgvReporte.Name =
                "dgvReporte";

            this.dgvReporte.ReadOnly = true;

            this.dgvReporte.RowHeadersVisible =
                false;

            this.dgvReporte.Size =
                new System.Drawing.Size(410, 115);

            this.dgvReporte.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // ==========================================
            // COLUMNAS
            // ==========================================

            this.dgvReporte.Columns.Add(
                "Materia",
                "Materia"
            );

            this.dgvReporte.Columns.Add(
                "Nota",
                "Nota"
            );

            // ==========================================
            // DATOS
            // ==========================================

            this.dgvReporte.Rows.Add(
                "Matemática",
                "8.50"
            );

            this.dgvReporte.Rows.Add(
                "Lenguaje",
                "9.00"
            );

            this.dgvReporte.Rows.Add(
                "Ciencias",
                "8.75"
            );

            this.dgvReporte.Rows.Add(
                "Inglés",
                "9.25"
            );

            // ==========================================
            // PROMEDIO
            // ==========================================

            this.lblPromedioTexto.AutoSize = true;

            this.lblPromedioTexto.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblPromedioTexto.Location =
                new System.Drawing.Point(15, 245);

            this.lblPromedioTexto.Text =
                "Promedio General";

            this.lblPromedio.AutoSize = true;

            this.lblPromedio.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblPromedio.Location =
                new System.Drawing.Point(350, 244);

            this.lblPromedio.Text =
                "8.88";

            // ==========================================
            // AGREGAR CONTROLES
            // ==========================================

            this.Controls.Add(
                this.lblTitulo
            );

            this.Controls.Add(
                this.lblTipoReporte
            );

            this.Controls.Add(
                this.lblPeriodo
            );

            this.Controls.Add(
                this.lblGrado
            );

            this.Controls.Add(
                this.lblEstudiante
            );

            this.Controls.Add(
                this.cmbTipoReporte
            );

            this.Controls.Add(
                this.cmbPeriodo
            );

            this.Controls.Add(
                this.cmbGrado
            );

            this.Controls.Add(
                this.cmbEstudiante
            );

            this.Controls.Add(
                this.btnGenerar
            );

            this.Controls.Add(
                this.grpVistaPrevia
            );

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvReporte)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}