namespace Systema.De_Gestion.Academica.UI
{
    partial class FrmMateria
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelTitulo = new Panel();
            labelTitulo = new Label();

            groupDatosMateria = new GroupBox();
            groupBuscar = new GroupBox();

            labelCodigo = new Label();
            labelNombre = new Label();
            labelDescripcion = new Label();
            labelGrado = new Label();
            labelDocente = new Label();

            textCodigo = new TextBox();
            textNombre = new TextBox();
            textDescripcion = new TextBox();

            comboGrado = new ComboBox();
            comboDocente = new ComboBox();

            buttonNuevo = new Button();
            buttonGuardar = new Button();
            buttonModificar = new Button();
            buttonLimpiar = new Button();

            labelBuscar = new Label();
            textBuscar = new TextBox();
            buttonBuscar = new Button();

            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(35, 45, 55);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(686, 65);
            panelTitulo.TabIndex = 0;

            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font(
                "Comic Sans MS",
                18F,
                FontStyle.Bold
            );
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(250, 15);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(185, 34);
            labelTitulo.Text = "Registro Materia";

            panelTitulo.Controls.Add(labelTitulo);

            // 
            // groupDatosMateria
            // 
            groupDatosMateria.Font = new Font(
                "Comic Sans MS",
                10F,
                FontStyle.Bold
            );
            groupDatosMateria.Location = new Point(20, 85);
            groupDatosMateria.Name = "groupDatosMateria";
            groupDatosMateria.Size = new Size(646, 220);
            groupDatosMateria.Text = "Datos de la materia";

            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Comic Sans MS", 9F);
            labelCodigo.Location = new Point(25, 40);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Text = "Código:";

            // 
            // textCodigo
            // 
            textCodigo.Font = new Font("Comic Sans MS", 9F);
            textCodigo.Location = new Point(100, 37);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(150, 24);

            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Comic Sans MS", 9F);
            labelNombre.Location = new Point(300, 40);
            labelNombre.Name = "labelNombre";
            labelNombre.Text = "Nombre:";

            // 
            // textNombre
            // 
            textNombre.Font = new Font("Comic Sans MS", 9F);
            textNombre.Location = new Point(365, 37);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(220, 24);

            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Comic Sans MS", 9F);
            labelDescripcion.Location = new Point(25, 80);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Text = "Descripción:";

            // 
            // textDescripcion
            // 
            textDescripcion.Font = new Font("Comic Sans MS", 9F);
            textDescripcion.Location = new Point(110, 77);
            textDescripcion.Multiline = true;
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(475, 55);

            // 
            // labelGrado
            // 
            labelGrado.AutoSize = true;
            labelGrado.Font = new Font("Comic Sans MS", 9F);
            labelGrado.Location = new Point(25, 155);
            labelGrado.Name = "labelGrado";
            labelGrado.Text = "Grado:";

            // 
            // comboGrado
            // 
            comboGrado.Font = new Font("Comic Sans MS", 9F);
            comboGrado.FormattingEnabled = true;
            comboGrado.Location = new Point(100, 152);
            comboGrado.Name = "comboGrado";
            comboGrado.Size = new Size(180, 25);

            // 
            // labelDocente
            // 
            labelDocente.AutoSize = true;
            labelDocente.Font = new Font("Comic Sans MS", 9F);
            labelDocente.Location = new Point(315, 155);
            labelDocente.Name = "labelDocente";
            labelDocente.Text = "Docente:";

            // 
            // comboDocente
            // 
            comboDocente.Font = new Font("Comic Sans MS", 9F);
            comboDocente.FormattingEnabled = true;
            comboDocente.Location = new Point(385, 152);
            comboDocente.Name = "comboDocente";
            comboDocente.Size = new Size(200, 25);

            groupDatosMateria.Controls.Add(labelCodigo);
            groupDatosMateria.Controls.Add(textCodigo);
            groupDatosMateria.Controls.Add(labelNombre);
            groupDatosMateria.Controls.Add(textNombre);
            groupDatosMateria.Controls.Add(labelDescripcion);
            groupDatosMateria.Controls.Add(textDescripcion);
            groupDatosMateria.Controls.Add(labelGrado);
            groupDatosMateria.Controls.Add(comboGrado);
            groupDatosMateria.Controls.Add(labelDocente);
            groupDatosMateria.Controls.Add(comboDocente);

            // 
            // buttonNuevo
            // 
            buttonNuevo.Font = new Font("Comic Sans MS", 9F);
            buttonNuevo.Location = new Point(20, 325);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(120, 35);
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;

            // 
            // buttonGuardar
            // 
            buttonGuardar.Font = new Font("Comic Sans MS", 9F);
            buttonGuardar.Location = new Point(155, 325);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(120, 35);
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;

            // 
            // buttonModificar
            // 
            buttonModificar.Font = new Font("Comic Sans MS", 9F);
            buttonModificar.Location = new Point(290, 325);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(120, 35);
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;

            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Font = new Font("Comic Sans MS", 9F);
            buttonLimpiar.Location = new Point(425, 325);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(120, 35);
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;

            // 
            // groupBuscar
            // 
            groupBuscar.Font = new Font(
                "Comic Sans MS",
                9F,
                FontStyle.Bold
            );
            groupBuscar.Location = new Point(20, 390);
            groupBuscar.Name = "groupBuscar";
            groupBuscar.Size = new Size(646, 80);
            groupBuscar.Text = "Buscar materia";

            // 
            // labelBuscar
            // 
            labelBuscar.AutoSize = true;
            labelBuscar.Font = new Font("Comic Sans MS", 9F);
            labelBuscar.Location = new Point(20, 35);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Text = "Código / nombre:";

            // 
            // textBuscar
            // 
            textBuscar.Font = new Font("Comic Sans MS", 9F);
            textBuscar.Location = new Point(135, 32);
            textBuscar.Name = "textBuscar";
            textBuscar.Size = new Size(350, 24);

            // 
            // buttonBuscar
            // 
            buttonBuscar.Font = new Font("Comic Sans MS", 9F);
            buttonBuscar.Location = new Point(500, 30);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(100, 28);
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;

            groupBuscar.Controls.Add(labelBuscar);
            groupBuscar.Controls.Add(textBuscar);
            groupBuscar.Controls.Add(buttonBuscar);

            // 
            // FrmMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(686, 539);

            Controls.Add(panelTitulo);
            Controls.Add(groupDatosMateria);
            Controls.Add(buttonNuevo);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonLimpiar);
            Controls.Add(groupBuscar);

            Name = "FrmMateria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Materia";

            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();

            groupDatosMateria.ResumeLayout(false);
            groupDatosMateria.PerformLayout();

            groupBuscar.ResumeLayout(false);
            groupBuscar.PerformLayout();

            this.ResumeLayout(false);
        }

        #endregion

        private Panel panelTitulo;
        private Label labelTitulo;

        private GroupBox groupDatosMateria;
        private GroupBox groupBuscar;

        private Label labelCodigo;
        private Label labelNombre;
        private Label labelDescripcion;
        private Label labelGrado;
        private Label labelDocente;
        private Label labelBuscar;

        private TextBox textCodigo;
        private TextBox textNombre;
        private TextBox textDescripcion;
        private TextBox textBuscar;

        private ComboBox comboGrado;
        private ComboBox comboDocente;

        private Button buttonNuevo;
        private Button buttonGuardar;
        private Button buttonModificar;
        private Button buttonLimpiar;
        private Button buttonBuscar;
    }
}