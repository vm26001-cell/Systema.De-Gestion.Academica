namespace Systema.De.Gestion.Academica.UI
{
    partial class FrmCalificacion
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblDocente;

        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.ComboBox cmbDocente;

        private System.Windows.Forms.TextBox txtBuscar;

        private System.Windows.Forms.DataGridView dgvCalificaciones;

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
            this.components = new System.ComponentModel.Container();

            this.lblTitulo = new System.Windows.Forms.Label();

            this.lblGrado = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();

            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.cmbDocente = new System.Windows.Forms.ComboBox();

            this.txtBuscar = new System.Windows.Forms.TextBox();

            this.dgvCalificaciones = new System.Windows.Forms.DataGridView();

            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).BeginInit();

            this.SuspendLayout();

            // ==========================================
            // FORMULARIO
            // ==========================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.White;

            this.ClientSize =
                new System.Drawing.Size(500, 570);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Registro de Calificaciones";


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

            this.lblTitulo.Text =
                "Registro de Calificaciones";


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
                new System.Drawing.Point(18, 60);

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
                new System.Drawing.Point(18, 78);

            this.cmbGrado.Size =
                new System.Drawing.Size(105, 23);

            this.cmbGrado.SelectedIndex = 0;


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
                new System.Drawing.Point(140, 60);

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
                new System.Drawing.Point(140, 78);

            this.cmbPeriodo.Size =
                new System.Drawing.Size(120, 23);

            this.cmbPeriodo.SelectedIndex = 1;


            // ==========================================
            // MATERIA
            // ==========================================

            this.lblMateria.AutoSize = true;

            this.lblMateria.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8F
                );

            this.lblMateria.Location =
                new System.Drawing.Point(18, 115);

            this.lblMateria.Text =
                "Materia:";


            this.cmbMateria.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbMateria.FormattingEnabled = true;

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

            this.cmbMateria.Location =
                new System.Drawing.Point(18, 133);

            this.cmbMateria.Size =
                new System.Drawing.Size(105, 23);

            this.cmbMateria.SelectedIndex = 0;


            // ==========================================
            // DOCENTE
            // ==========================================

            this.lblDocente.AutoSize = true;

            this.lblDocente.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8F
                );

            this.lblDocente.Location =
                new System.Drawing.Point(140, 115);

            this.lblDocente.Text =
                "Docente:";


            this.cmbDocente.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbDocente.FormattingEnabled = true;

            this.cmbDocente.Items.AddRange(
                new object[]
                {
                    "Carlos Gómez",
                    "Ana Martínez",
                    "Pedro Romero"
                }
            );

            this.cmbDocente.Location =
                new System.Drawing.Point(140, 133);

            this.cmbDocente.Size =
                new System.Drawing.Size(120, 23);

            this.cmbDocente.SelectedIndex = 0;


            // ==========================================
            // BUSCADOR
            // ==========================================

            this.txtBuscar.Location =
                new System.Drawing.Point(18, 170);

            this.txtBuscar.Size =
                new System.Drawing.Size(242, 23);

            this.txtBuscar.Text =
                "Buscar estudiante...";

            this.txtBuscar.ForeColor =
                System.Drawing.Color.Gray;


            // ==========================================
            // TABLA
            // ==========================================

            this.dgvCalificaciones.AllowUserToAddRows =
                false;

            this.dgvCalificaciones.AllowUserToDeleteRows =
                false;

            this.dgvCalificaciones.AllowUserToResizeRows =
                false;

            this.dgvCalificaciones.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvCalificaciones.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.dgvCalificaciones.ColumnHeadersHeight =
                28;

            this.dgvCalificaciones.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvCalificaciones.Location =
                new System.Drawing.Point(18, 205);

            this.dgvCalificaciones.RowHeadersVisible =
                false;

            this.dgvCalificaciones.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvCalificaciones.Size =
                new System.Drawing.Size(445, 190);

            this.dgvCalificaciones.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;


            // ==========================================
            // COLUMNAS
            // ==========================================

            this.dgvCalificaciones.Columns.Add(
                "Codigo",
                "Código"
            );

            this.dgvCalificaciones.Columns.Add(
                "Estudiante",
                "Estudiante"
            );

            this.dgvCalificaciones.Columns.Add(
                "Nota",
                "Nota"
            );


            // ==========================================
            // DATOS
            // ==========================================

            this.dgvCalificaciones.Rows.Add(
                "E001",
                "Juan Pérez",
                "8.50"
            );

            this.dgvCalificaciones.Rows.Add(
                "E002",
                "María López",
                "9.00"
            );

            this.dgvCalificaciones.Rows.Add(
                "E003",
                "Carlos García",
                "7.50"
            );

            this.dgvCalificaciones.Rows.Add(
                "E004",
                "Ana Martínez",
                "8.75"
            );


            // ==========================================
            // BOTÓN GUARDAR
            // ==========================================

            this.btnGuardar.BackColor =
                System.Drawing.Color.FromArgb(45, 45, 45);

            this.btnGuardar.FlatAppearance.BorderSize =
                0;

            this.btnGuardar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnGuardar.ForeColor =
                System.Drawing.Color.White;

            this.btnGuardar.Location =
                new System.Drawing.Point(190, 420);

            this.btnGuardar.Size =
                new System.Drawing.Size(75, 30);

            this.btnGuardar.Text =
                "Guardar";

            this.btnGuardar.UseVisualStyleBackColor =
                false;

            this.btnGuardar.Click +=
                new System.EventHandler(
                    this.btnGuardar_Click
                );


            // ==========================================
            // BOTÓN CANCELAR
            // ==========================================

            this.btnCancelar.BackColor =
                System.Drawing.Color.White;

            this.btnCancelar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnCancelar.Location =
                new System.Drawing.Point(275, 420);

            this.btnCancelar.Size =
                new System.Drawing.Size(75, 30);

            this.btnCancelar.Text =
                "Cancelar";

            this.btnCancelar.UseVisualStyleBackColor =
                false;

            this.btnCancelar.Click +=
                new System.EventHandler(
                    this.btnCancelar_Click
                );


            // ==========================================
            // AGREGAR CONTROLES
            // ==========================================

            this.Controls.Add(this.lblTitulo);

            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblDocente);

            this.Controls.Add(this.cmbGrado);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.cmbDocente);

            this.Controls.Add(this.txtBuscar);

            this.Controls.Add(this.dgvCalificaciones);

            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvCalificaciones)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}