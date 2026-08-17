namespace Systema.De_Gestion.Academica.UI
{
    partial class FrmDocente
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

            groupDatosPersonales = new GroupBox();
            groupDatosContacto = new GroupBox();
            groupDatosAcademicos = new GroupBox();
            groupBuscar = new GroupBox();

            labelCodigo = new Label();
            labelNombre = new Label();
            labelApellido = new Label();
            labelDui = new Label();

            labelTelefono = new Label();
            labelCorreo = new Label();

            labelEspecialidad = new Label();
            labelMateria = new Label();

            labelBuscar = new Label();

            textCodigo = new TextBox();
            textNombre = new TextBox();
            textApellido = new TextBox();
            textDui = new TextBox();

            textTelefono = new TextBox();
            textCorreo = new TextBox();

            textEspecialidad = new TextBox();
            comboMateria = new ComboBox();

            textBuscar = new TextBox();

            buttonNuevo = new Button();
            buttonGuardar = new Button();
            buttonModificar = new Button();
            buttonLimpiar = new Button();
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
            labelTitulo.Location = new Point(245, 15);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(195, 34);
            labelTitulo.Text = "Registro Docente";

            panelTitulo.Controls.Add(labelTitulo);

            // 
            // groupDatosPersonales
            // 
            groupDatosPersonales.Font = new Font(
                "Comic Sans MS",
                10F,
                FontStyle.Bold
            );
            groupDatosPersonales.Location = new Point(20, 80);
            groupDatosPersonales.Name = "groupDatosPersonales";
            groupDatosPersonales.Size = new Size(646, 155);
            groupDatosPersonales.Text = "Datos personales";

            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Comic Sans MS", 9F);
            labelCodigo.Location = new Point(20, 35);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Text = "Código:";

            // 
            // textCodigo
            // 
            textCodigo.Font = new Font("Comic Sans MS", 9F);
            textCodigo.Location = new Point(85, 32);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(140, 24);

            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Comic Sans MS", 9F);
            labelNombre.Location = new Point(250, 35);
            labelNombre.Name = "labelNombre";
            labelNombre.Text = "Nombre:";

            // 
            // textNombre
            // 
            textNombre.Font = new Font("Comic Sans MS", 9F);
            textNombre.Location = new Point(315, 32);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(140, 24);

            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Comic Sans MS", 9F);
            labelApellido.Location = new Point(20, 75);
            labelApellido.Name = "labelApellido";
            labelApellido.Text = "Apellido:";

            // 
            // textApellido
            // 
            textApellido.Font = new Font("Comic Sans MS", 9F);
            textApellido.Location = new Point(85, 72);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(140, 24);

            // 
            // labelDui
            // 
            labelDui.AutoSize = true;
            labelDui.Font = new Font("Comic Sans MS", 9F);
            labelDui.Location = new Point(250, 75);
            labelDui.Name = "labelDui";
            labelDui.Text = "DUI:";

            // 
            // textDui
            // 
            textDui.Font = new Font("Comic Sans MS", 9F);
            textDui.Location = new Point(315, 72);
            textDui.Name = "textDui";
            textDui.Size = new Size(140, 24);

            groupDatosPersonales.Controls.Add(labelCodigo);
            groupDatosPersonales.Controls.Add(textCodigo);
            groupDatosPersonales.Controls.Add(labelNombre);
            groupDatosPersonales.Controls.Add(textNombre);
            groupDatosPersonales.Controls.Add(labelApellido);
            groupDatosPersonales.Controls.Add(textApellido);
            groupDatosPersonales.Controls.Add(labelDui);
            groupDatosPersonales.Controls.Add(textDui);

            // 
            // groupDatosContacto
            // 
            groupDatosContacto.Font = new Font(
                "Comic Sans MS",
                10F,
                FontStyle.Bold
            );
            groupDatosContacto.Location = new Point(20, 250);
            groupDatosContacto.Name = "groupDatosContacto";
            groupDatosContacto.Size = new Size(646, 90);
            groupDatosContacto.Text = "Datos de contacto";

            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Comic Sans MS", 9F);
            labelTelefono.Location = new Point(20, 40);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Text = "Teléfono:";

            // 
            // textTelefono
            // 
            textTelefono.Font = new Font("Comic Sans MS", 9F);
            textTelefono.Location = new Point(90, 37);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(170, 24);

            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Font = new Font("Comic Sans MS", 9F);
            labelCorreo.Location = new Point(300, 40);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Text = "Correo:";

            // 
            // textCorreo
            // 
            textCorreo.Font = new Font("Comic Sans MS", 9F);
            textCorreo.Location = new Point(360, 37);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(220, 24);

            groupDatosContacto.Controls.Add(labelTelefono);
            groupDatosContacto.Controls.Add(textTelefono);
            groupDatosContacto.Controls.Add(labelCorreo);
            groupDatosContacto.Controls.Add(textCorreo);

            // 
            // groupDatosAcademicos
            // 
            groupDatosAcademicos.Font = new Font(
                "Comic Sans MS",
                10F,
                FontStyle.Bold
            );
            groupDatosAcademicos.Location = new Point(20, 355);
            groupDatosAcademicos.Name = "groupDatosAcademicos";
            groupDatosAcademicos.Size = new Size(646, 75);
            groupDatosAcademicos.Text = "Información académica";

            // 
            // labelEspecialidad
            // 
            labelEspecialidad.AutoSize = true;
            labelEspecialidad.Font = new Font("Comic Sans MS", 9F);
            labelEspecialidad.Location = new Point(20, 35);
            labelEspecialidad.Name = "labelEspecialidad";
            labelEspecialidad.Text = "Especialidad:";

            // 
            // textEspecialidad
            // 
            textEspecialidad.Font = new Font("Comic Sans MS", 9F);
            textEspecialidad.Location = new Point(110, 32);
            textEspecialidad.Name = "textEspecialidad";
            textEspecialidad.Size = new Size(180, 24);

            // 
            // labelMateria
            // 
            labelMateria.AutoSize = true;
            labelMateria.Font = new Font("Comic Sans MS", 9F);
            labelMateria.Location = new Point(315, 35);
            labelMateria.Name = "labelMateria";
            labelMateria.Text = "Materia:";

            // 
            // comboMateria
            // 
            comboMateria.Font = new Font("Comic Sans MS", 9F);
            comboMateria.FormattingEnabled = true;
            comboMateria.Location = new Point(375, 32);
            comboMateria.Name = "comboMateria";
            comboMateria.Size = new Size(190, 25);

            groupDatosAcademicos.Controls.Add(labelEspecialidad);
            groupDatosAcademicos.Controls.Add(textEspecialidad);
            groupDatosAcademicos.Controls.Add(labelMateria);
            groupDatosAcademicos.Controls.Add(comboMateria);

            // 
            // buttonNuevo
            // 
            buttonNuevo.Font = new Font("Comic Sans MS", 9F);
            buttonNuevo.Location = new Point(20, 445);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(115, 32);
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;

            // 
            // buttonGuardar
            // 
            buttonGuardar.Font = new Font("Comic Sans MS", 9F);
            buttonGuardar.Location = new Point(150, 445);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(115, 32);
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;

            // 
            // buttonModificar
            // 
            buttonModificar.Font = new Font("Comic Sans MS", 9F);
            buttonModificar.Location = new Point(280, 445);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(115, 32);
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;

            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Font = new Font("Comic Sans MS", 9F);
            buttonLimpiar.Location = new Point(410, 445);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(115, 32);
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
            groupBuscar.Location = new Point(20, 490);
            groupBuscar.Name = "groupBuscar";
            groupBuscar.Size = new Size(646, 40);
            groupBuscar.Text = "Buscar";

            // 
            // labelBuscar
            // 
            labelBuscar.AutoSize = true;
            labelBuscar.Font = new Font("Comic Sans MS", 8F);
            labelBuscar.Location = new Point(10, 15);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Text = "Docente:";

            // 
            // textBuscar
            // 
            textBuscar.Font = new Font("Comic Sans MS", 8F);
            textBuscar.Location = new Point(70, 12);
            textBuscar.Name = "textBuscar";
            textBuscar.Size = new Size(360, 22);

            // 
            // buttonBuscar
            // 
            buttonBuscar.Font = new Font("Comic Sans MS", 8F);
            buttonBuscar.Location = new Point(445, 10);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(90, 25);
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;

            groupBuscar.Controls.Add(labelBuscar);
            groupBuscar.Controls.Add(textBuscar);
            groupBuscar.Controls.Add(buttonBuscar);

            // 
            // FrmDocente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(686, 539);

            Controls.Add(panelTitulo);
            Controls.Add(groupDatosPersonales);
            Controls.Add(groupDatosContacto);
            Controls.Add(groupDatosAcademicos);
            Controls.Add(buttonNuevo);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonLimpiar);
            Controls.Add(groupBuscar);

            Name = "FrmDocente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Docente";

            this.ResumeLayout(false);
        }

        #endregion

        private Panel panelTitulo;
        private Label labelTitulo;

        private GroupBox groupDatosPersonales;
        private GroupBox groupDatosContacto;
        private GroupBox groupDatosAcademicos;
        private GroupBox groupBuscar;

        private Label labelCodigo;
        private Label labelNombre;
        private Label labelApellido;
        private Label labelDui;

        private Label labelTelefono;
        private Label labelCorreo;

        private Label labelEspecialidad;
        private Label labelMateria;

        private Label labelBuscar;

        private TextBox textCodigo;
        private TextBox textNombre;
        private TextBox textApellido;
        private TextBox textDui;

        private TextBox textTelefono;
        private TextBox textCorreo;

        private TextBox textEspecialidad;
        private ComboBox comboMateria;

        private TextBox textBuscar;

        private Button buttonNuevo;
        private Button buttonGuardar;
        private Button buttonModificar;
        private Button buttonLimpiar;
        private Button buttonBuscar;
    }
}