namespace Systema.De_Gestion.Academica.UI
{
    partial class FrmAsistencia
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblDocente;

        private System.Windows.Forms.DateTimePicker dtpFecha;

        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.ComboBox cmbDocente;

        private System.Windows.Forms.DataGridView dgvAsistencia;

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

            this.lblFecha =
                new System.Windows.Forms.Label();

            this.lblGrado =
                new System.Windows.Forms.Label();

            this.lblMateria =
                new System.Windows.Forms.Label();

            this.lblDocente =
                new System.Windows.Forms.Label();

            this.dtpFecha =
                new System.Windows.Forms.DateTimePicker();

            this.cmbGrado =
                new System.Windows.Forms.ComboBox();

            this.cmbMateria =
                new System.Windows.Forms.ComboBox();

            this.cmbDocente =
                new System.Windows.Forms.ComboBox();

            this.dgvAsistencia =
                new System.Windows.Forms.DataGridView();

            this.btnGuardar =
                new System.Windows.Forms.Button();

            this.btnCancelar =
                new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvAsistencia)).BeginInit();

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
                "Registro de Asistencia";

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
                "Registro de Asistencia";

            // ==========================================
            // FECHA
            // ==========================================

            this.lblFecha.AutoSize = true;

            this.lblFecha.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8F
                );

            this.lblFecha.Location =
                new System.Drawing.Point(18, 60);

            this.lblFecha.Text =
                "Fecha:";

            // ==========================================
            // DATE PICKER
            // ==========================================

            this.dtpFecha.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpFecha.Location =
                new System.Drawing.Point(18, 78);

            this.dtpFecha.Name =
                "dtpFecha";

            this.dtpFecha.Size =
                new System.Drawing.Size(100, 23);

            this.dtpFecha.Value =
                new System.DateTime(
                    2026,
                    6,
                    17
                );

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
                new System.Drawing.Point(130, 60);

            this.lblGrado.Text =
                "Grado / Sección:";

            // ==========================================
            // COMBO GRADO
            // ==========================================

            this.cmbGrado.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbGrado.FormattingEnabled =
                true;

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
                new System.Drawing.Point(130, 78);

            this.cmbGrado.Name =
                "cmbGrado";

            this.cmbGrado.Size =
                new System.Drawing.Size(130, 23);

            this.cmbGrado.SelectedIndex = 0;

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

            // ==========================================
            // COMBO MATERIA
            // ==========================================

            this.cmbMateria.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbMateria.FormattingEnabled =
                true;

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

            this.cmbMateria.Name =
                "cmbMateria";

            this.cmbMateria.Size =
                new System.Drawing.Size(100, 23);

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
                new System.Drawing.Point(130, 115);

            this.lblDocente.Text =
                "Docente:";

            // ==========================================
            // COMBO DOCENTE
            // ==========================================

            this.cmbDocente.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbDocente.FormattingEnabled =
                true;

            this.cmbDocente.Items.AddRange(
                new object[]
                {
                    "Carlos Gómez",
                    "Ana Martínez",
                    "Pedro Romero"
                }
            );

            this.cmbDocente.Location =
                new System.Drawing.Point(130, 133);

            this.cmbDocente.Name =
                "cmbDocente";

            this.cmbDocente.Size =
                new System.Drawing.Size(130, 23);

            this.cmbDocente.SelectedIndex = 0;

            // ==========================================
            // TABLA
            // ==========================================

            this.dgvAsistencia.AllowUserToAddRows =
                false;

            this.dgvAsistencia.AllowUserToDeleteRows =
                false;

            this.dgvAsistencia.AllowUserToResizeRows =
                false;

            this.dgvAsistencia.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvAsistencia.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.dgvAsistencia.ColumnHeadersHeight =
                28;

            this.dgvAsistencia.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvAsistencia.Location =
                new System.Drawing.Point(18, 185);

            this.dgvAsistencia.Name =
                "dgvAsistencia";

            this.dgvAsistencia.RowHeadersVisible =
                false;

            this.dgvAsistencia.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvAsistencia.Size =
                new System.Drawing.Size(445, 190);

            this.dgvAsistencia.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // ==========================================
            // COLUMNAS
            // ==========================================

            this.dgvAsistencia.Columns.Add(
                "Codigo",
                "Código"
            );

            this.dgvAsistencia.Columns.Add(
                "Estudiante",
                "Estudiante"
            );

            System.Windows.Forms.DataGridViewComboBoxColumn columnaEstado =
                new System.Windows.Forms.DataGridViewComboBoxColumn();

            columnaEstado.Name =
                "Estado";

            columnaEstado.HeaderText =
                "Estado";

            columnaEstado.Items.Add(
                "Presente"
            );

            columnaEstado.Items.Add(
                "Tardanza"
            );

            columnaEstado.Items.Add(
                "Ausente"
            );

            columnaEstado.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.dgvAsistencia.Columns.Add(
                columnaEstado
            );

            // ==========================================
            // ESTUDIANTE 1
            // ==========================================

            this.dgvAsistencia.Rows.Add(
                "E001",
                "Juan Pérez",
                "Presente"
            );

            // ==========================================
            // ESTUDIANTE 2
            // ==========================================

            this.dgvAsistencia.Rows.Add(
                "E002",
                "María López",
                "Tardanza"
            );

            // ==========================================
            // ESTUDIANTE 3
            // ==========================================

            this.dgvAsistencia.Rows.Add(
                "E003",
                "Carlos García",
                "Ausente"
            );

            // ==========================================
            // ESTUDIANTE 4
            // ==========================================

            this.dgvAsistencia.Rows.Add(
                "E004",
                "Ana Martínez",
                "Presente"
            );

            // ==========================================
            // BOTÓN GUARDAR
            // ==========================================

            this.btnGuardar.BackColor =
                System.Drawing.Color.FromArgb(
                    45,
                    45,
                    45
                );

            this.btnGuardar.FlatAppearance.BorderSize =
                0;

            this.btnGuardar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnGuardar.ForeColor =
                System.Drawing.Color.White;

            this.btnGuardar.Location =
                new System.Drawing.Point(190, 405);

            this.btnGuardar.Name =
                "btnGuardar";

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
                new System.Drawing.Point(275, 405);

            this.btnCancelar.Name =
                "btnCancelar";

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

            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblDocente);

            this.Controls.Add(this.dtpFecha);

            this.Controls.Add(this.cmbGrado);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.cmbDocente);

            this.Controls.Add(this.dgvAsistencia);

            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvAsistencia)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}