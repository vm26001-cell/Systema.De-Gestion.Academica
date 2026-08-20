namespace Systema.De_Gestion.Academica.UI
{
    partial class FrmHorario
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.ComboBox cmbGrado;

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.ComboBox cmbDia;

        private System.Windows.Forms.DataGridView dgvHorario;

        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAula;

        private System.Windows.Forms.GroupBox grpDatos;

        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cmbMateria;

        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.ComboBox cmbDocente;

        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.ComboBox cmbAula;

        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.TextBox txtHoraInicio;

        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.TextBox txtHoraFin;

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;

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

            this.lblGrado =
                new System.Windows.Forms.Label();

            this.cmbGrado =
                new System.Windows.Forms.ComboBox();

            this.lblDia =
                new System.Windows.Forms.Label();

            this.cmbDia =
                new System.Windows.Forms.ComboBox();

            this.dgvHorario =
                new System.Windows.Forms.DataGridView();

            this.colHora =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colMateria =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colDocente =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colAula =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.grpDatos =
                new System.Windows.Forms.GroupBox();

            this.lblMateria =
                new System.Windows.Forms.Label();

            this.cmbMateria =
                new System.Windows.Forms.ComboBox();

            this.lblDocente =
                new System.Windows.Forms.Label();

            this.cmbDocente =
                new System.Windows.Forms.ComboBox();

            this.lblAula =
                new System.Windows.Forms.Label();

            this.cmbAula =
                new System.Windows.Forms.ComboBox();

            this.lblHoraInicio =
                new System.Windows.Forms.Label();

            this.txtHoraInicio =
                new System.Windows.Forms.TextBox();

            this.lblHoraFin =
                new System.Windows.Forms.Label();

            this.txtHoraFin =
                new System.Windows.Forms.TextBox();

            this.btnNuevo =
                new System.Windows.Forms.Button();

            this.btnGuardar =
                new System.Windows.Forms.Button();

            this.btnCancelar =
                new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvHorario)).BeginInit();

            this.SuspendLayout();

            // ==========================================
            // FORMULARIO
            // ==========================================

            this.BackColor =
                System.Drawing.Color.White;

            this.ClientSize =
                new System.Drawing.Size(850, 620);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Gestión de Horarios";

            // ==========================================
            // TITULO
            // ==========================================

            this.lblTitulo.AutoSize = true;

            this.lblTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    18F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblTitulo.Location =
                new System.Drawing.Point(20, 20);

            this.lblTitulo.Text =
                "Gestión de Horarios";

            // ==========================================
            // BOTON NUEVO
            // ==========================================

            this.btnNuevo.BackColor =
                System.Drawing.Color.FromArgb(
                    45,
                    45,
                    45
                );

            this.btnNuevo.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnNuevo.ForeColor =
                System.Drawing.Color.White;

            this.btnNuevo.Location =
                new System.Drawing.Point(745, 18);

            this.btnNuevo.Size =
                new System.Drawing.Size(85, 35);

            this.btnNuevo.Text =
                "Nuevo";

            this.btnNuevo.UseVisualStyleBackColor =
                false;

            this.btnNuevo.Click +=
                new System.EventHandler(
                    this.btnNuevo_Click
                );

            // ==========================================
            // GRADO
            // ==========================================

            this.lblGrado.AutoSize = true;

            this.lblGrado.Location =
                new System.Drawing.Point(20, 75);

            this.lblGrado.Text =
                "Grado / Sección:";

            this.cmbGrado.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbGrado.Location =
                new System.Drawing.Point(20, 100);

            this.cmbGrado.Size =
                new System.Drawing.Size(230, 28);

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

            this.cmbGrado.SelectedIndex = 0;

            // ==========================================
            // DIA
            // ==========================================

            this.lblDia.AutoSize = true;

            this.lblDia.Location =
                new System.Drawing.Point(275, 75);

            this.lblDia.Text =
                "Día:";

            this.cmbDia.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbDia.Location =
                new System.Drawing.Point(275, 100);

            this.cmbDia.Size =
                new System.Drawing.Size(180, 28);

            this.cmbDia.Items.AddRange(
                new object[]
                {
                    "Lunes",
                    "Martes",
                    "Miércoles",
                    "Jueves",
                    "Viernes"
                }
            );

            this.cmbDia.SelectedIndex = 0;

            // ==========================================
            // TABLA
            // ==========================================

            this.dgvHorario.AllowUserToAddRows =
                false;

            this.dgvHorario.AllowUserToDeleteRows =
                false;

            this.dgvHorario.AllowUserToResizeRows =
                false;

            this.dgvHorario.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvHorario.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.dgvHorario.ColumnHeadersHeight =
                35;

            this.dgvHorario.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvHorario.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colHora,
                    this.colMateria,
                    this.colDocente,
                    this.colAula
                }
            );

            this.dgvHorario.Location =
                new System.Drawing.Point(20, 150);

            this.dgvHorario.MultiSelect =
                false;

            this.dgvHorario.ReadOnly = true;

            this.dgvHorario.RowHeadersVisible =
                false;

            this.dgvHorario.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvHorario.Size =
                new System.Drawing.Size(810, 190);

            // ==========================================
            // COLUMNA HORA
            // ==========================================

            this.colHora.HeaderText =
                "Hora";

            this.colHora.Name =
                "colHora";

            this.colHora.ReadOnly = true;

            this.colHora.Width = 160;

            // ==========================================
            // COLUMNA MATERIA
            // ==========================================

            this.colMateria.HeaderText =
                "Materia";

            this.colMateria.Name =
                "colMateria";

            this.colMateria.ReadOnly = true;

            this.colMateria.Width = 200;

            // ==========================================
            // COLUMNA DOCENTE
            // ==========================================

            this.colDocente.HeaderText =
                "Docente";

            this.colDocente.Name =
                "colDocente";

            this.colDocente.ReadOnly = true;

            this.colDocente.Width = 220;

            // ==========================================
            // COLUMNA AULA
            // ==========================================

            this.colAula.HeaderText =
                "Aula";

            this.colAula.Name =
                "colAula";

            this.colAula.ReadOnly = true;

            this.colAula.Width = 180;

            // ==========================================
            // DATOS DE EJEMPLO
            // ==========================================

            this.dgvHorario.Rows.Add(
                "08:00 - 09:00",
                "Matemática",
                "Carlos Gómez",
                "Aula 101"
            );

            this.dgvHorario.Rows.Add(
                "09:00 - 10:00",
                "Lenguaje",
                "Carlos Gómez",
                "Aula 101"
            );

            this.dgvHorario.Rows.Add(
                "10:00 - 11:00",
                "Ciencias",
                "Ana Martínez",
                "Aula 102"
            );

            this.dgvHorario.Rows.Add(
                "11:00 - 12:00",
                "Inglés",
                "Ana Martínez",
                "Lab. 1"
            );

            // ==========================================
            // GRUPO DATOS HORARIO
            // ==========================================

            this.grpDatos.Location =
                new System.Drawing.Point(20, 360);

            this.grpDatos.Size =
                new System.Drawing.Size(810, 150);

            this.grpDatos.Text =
                "Datos del Horario";

            // ==========================================
            // MATERIA
            // ==========================================

            this.lblMateria.AutoSize = true;

            this.lblMateria.Location =
                new System.Drawing.Point(20, 35);

            this.lblMateria.Text =
                "Materia:";

            this.cmbMateria.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbMateria.Location =
                new System.Drawing.Point(20, 60);

            this.cmbMateria.Size =
                new System.Drawing.Size(180, 28);

            this.cmbMateria.Items.AddRange(
                new object[]
                {
                    "Matemática",
                    "Lenguaje",
                    "Ciencias",
                    "Inglés",
                    "Informática"
                }
            );

            this.cmbMateria.SelectedIndex = 0;

            // ==========================================
            // DOCENTE
            // ==========================================

            this.lblDocente.AutoSize = true;

            this.lblDocente.Location =
                new System.Drawing.Point(220, 35);

            this.lblDocente.Text =
                "Docente:";

            this.cmbDocente.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbDocente.Location =
                new System.Drawing.Point(220, 60);

            this.cmbDocente.Size =
                new System.Drawing.Size(180, 28);

            this.cmbDocente.Items.AddRange(
                new object[]
                {
                    "Carlos Gómez",
                    "Ana Martínez",
                    "Pedro Romero"
                }
            );

            this.cmbDocente.SelectedIndex = 0;

            // ==========================================
            // AULA
            // ==========================================

            this.lblAula.AutoSize = true;

            this.lblAula.Location =
                new System.Drawing.Point(420, 35);

            this.lblAula.Text =
                "Aula:";

            this.cmbAula.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbAula.Location =
                new System.Drawing.Point(420, 60);

            this.cmbAula.Size =
                new System.Drawing.Size(150, 28);

            this.cmbAula.Items.AddRange(
                new object[]
                {
                    "Aula 101",
                    "Aula 102",
                    "Aula 103",
                    "Lab. 1",
                    "Lab. 2"
                }
            );

            this.cmbAula.SelectedIndex = 0;

            // ==========================================
            // HORA INICIO
            // ==========================================

            this.lblHoraInicio.AutoSize = true;

            this.lblHoraInicio.Location =
                new System.Drawing.Point(590, 35);

            this.lblHoraInicio.Text =
                "Hora Inicio:";

            this.txtHoraInicio.Location =
                new System.Drawing.Point(590, 60);

            this.txtHoraInicio.Size =
                new System.Drawing.Size(90, 27);

            this.txtHoraInicio.Text =
                "08:00";

            // ==========================================
            // HORA FIN
            // ==========================================

            this.lblHoraFin.AutoSize = true;

            this.lblHoraFin.Location =
                new System.Drawing.Point(690, 35);

            this.lblHoraFin.Text =
                "Hora Fin:";

            this.txtHoraFin.Location =
                new System.Drawing.Point(690, 60);

            this.txtHoraFin.Size =
                new System.Drawing.Size(90, 27);

            this.txtHoraFin.Text =
                "09:00";

            // ==========================================
            // AGREGAR DATOS AL GROUPBOX
            // ==========================================

            this.grpDatos.Controls.Add(
                this.lblMateria
            );

            this.grpDatos.Controls.Add(
                this.cmbMateria
            );

            this.grpDatos.Controls.Add(
                this.lblDocente
            );

            this.grpDatos.Controls.Add(
                this.cmbDocente
            );

            this.grpDatos.Controls.Add(
                this.lblAula
            );

            this.grpDatos.Controls.Add(
                this.cmbAula
            );

            this.grpDatos.Controls.Add(
                this.lblHoraInicio
            );

            this.grpDatos.Controls.Add(
                this.txtHoraInicio
            );

            this.grpDatos.Controls.Add(
                this.lblHoraFin
            );

            this.grpDatos.Controls.Add(
                this.txtHoraFin
            );

            // ==========================================
            // BOTON GUARDAR
            // ==========================================

            this.btnGuardar.BackColor =
                System.Drawing.Color.FromArgb(
                    45,
                    45,
                    45
                );

            this.btnGuardar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnGuardar.ForeColor =
                System.Drawing.Color.White;

            this.btnGuardar.Location =
                new System.Drawing.Point(600, 535);

            this.btnGuardar.Size =
                new System.Drawing.Size(105, 40);

            this.btnGuardar.Text =
                "Guardar";

            this.btnGuardar.UseVisualStyleBackColor =
                false;

            this.btnGuardar.Click +=
                new System.EventHandler(
                    this.btnGuardar_Click
                );

            // ==========================================
            // BOTON CANCELAR
            // ==========================================

            this.btnCancelar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnCancelar.Location =
                new System.Drawing.Point(715, 535);

            this.btnCancelar.Size =
                new System.Drawing.Size(105, 40);

            this.btnCancelar.Text =
                "Cancelar";

            this.btnCancelar.Click +=
                new System.EventHandler(
                    this.btnCancelar_Click
                );

            // ==========================================
            // AGREGAR CONTROLES AL FORMULARIO
            // ==========================================

            this.Controls.Add(
                this.lblTitulo
            );

            this.Controls.Add(
                this.btnNuevo
            );

            this.Controls.Add(
                this.lblGrado
            );

            this.Controls.Add(
                this.cmbGrado
            );

            this.Controls.Add(
                this.lblDia
            );

            this.Controls.Add(
                this.cmbDia
            );

            this.Controls.Add(
                this.dgvHorario
            );

            this.Controls.Add(
                this.grpDatos
            );

            this.Controls.Add(
                this.btnGuardar
            );

            this.Controls.Add(
                this.btnCancelar
            );

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvHorario)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}