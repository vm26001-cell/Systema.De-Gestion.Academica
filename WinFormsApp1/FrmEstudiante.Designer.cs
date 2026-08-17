namespace Systema.De_Gestion.Academica.UI
{
    partial class FrmEstudiante
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
            groupDatosAcademicos = new GroupBox();

            labelCodigo = new Label();
            labelNombre = new Label();
            labelApellido = new Label();
            labelDui = new Label();
            labelFechaNacimiento = new Label();
            labelTelefono = new Label();
            labelCorreo = new Label();

            labelGrado = new Label();
            labelSeccion = new Label();
            labelAnio = new Label();

            textCodigo = new TextBox();
            textNombre = new TextBox();
            textApellido = new TextBox();
            textDui = new TextBox();
            textTelefono = new TextBox();
            textCorreo = new TextBox();

            dateFechaNacimiento = new DateTimePicker();

            comboGrado = new ComboBox();
            comboSeccion = new ComboBox();
            textAnio = new TextBox();

            buttonNuevo = new Button();
            buttonGuardar = new Button();
            buttonModificar = new Button();
            buttonLimpiar = new Button();

            groupBuscar = new GroupBox();
            labelBuscar = new Label();
            textBuscar = new TextBox();
            buttonBuscar = new Button();

            panelTitulo.SuspendLayout();
            groupDatosPersonales.SuspendLayout();
            groupDatosAcademicos.SuspendLayout();
            groupBuscar.SuspendLayout();

            this.SuspendLayout();

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
            labelTitulo.Location = new Point(220, 15);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(250, 34);
            labelTitulo.Text = "Registro de Estudiante";

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
            groupDatosPersonales.Size = new Size(646, 205);
            groupDatosPersonales.Text = "Datos personales";

            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Comic Sans MS", 9F);
            labelCodigo.Location = new Point(20, 35);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(55, 17);
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
            labelNombre.Location = new Point(20, 72);
            labelNombre.Name = "labelNombre";
            labelNombre.Text = "Nombre:";

            // 
            // textNombre
            // 
            textNombre.Font = new Font("Comic Sans MS", 9F);
            textNombre.Location = new Point(85, 69);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(200, 24);

            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Comic Sans MS", 9F);
            labelApellido.Location = new Point(305, 72);
            labelApellido.Name = "labelApellido";
            labelApellido.Text = "Apellido:";

            // 
            // textApellido
            // 
            textApellido.Font = new Font("Comic Sans MS", 9F);
            textApellido.Location = new Point(370, 69);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(200, 24);

            // 
            // labelDui
            // 
            labelDui.AutoSize = true;
            labelDui.Font = new Font("Comic Sans MS", 9F);
            labelDui.Location = new Point(20, 109);
            labelDui.Name = "labelDui";
            labelDui.Text = "DUI:";

            // 
            // textDui
            // 
            textDui.Font = new Font("Comic Sans MS", 9F);
            textDui.Location = new Point(85, 106);
            textDui.Name = "textDui";
            textDui.Size = new Size(140, 24);

            // 
            // labelFechaNacimiento
            // 
            labelFechaNacimiento.AutoSize = true;
            labelFechaNacimiento.Font = new Font("Comic Sans MS", 9F);
            labelFechaNacimiento.Location = new Point(305, 109);
            labelFechaNacimiento.Name = "labelFechaNacimiento";
            labelFechaNacimiento.Text = "Fecha nacimiento:";

            // 
            // dateFechaNacimiento
            // 
            dateFechaNacimiento.Font = new Font("Comic Sans MS", 9F);
            dateFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateFechaNacimiento.Location = new Point(420, 106);
            dateFechaNacimiento.Name = "dateFechaNacimiento";
            dateFechaNacimiento.Size = new Size(150, 24);

            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Comic Sans MS", 9F);
            labelTelefono.Location = new Point(20, 146);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Text = "Teléfono:";

            // 
            // textTelefono
            // 
            textTelefono.Font = new Font("Comic Sans MS", 9F);
            textTelefono.Location = new Point(85, 143);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(140, 24);

            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Font = new Font("Comic Sans MS", 9F);
            labelCorreo.Location = new Point(305, 146);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Text = "Correo:";

            // 
            // textCorreo
            // 
            textCorreo.Font = new Font("Comic Sans MS", 9F);
            textCorreo.Location = new Point(370, 143);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(200, 24);

            groupDatosPersonales.Controls.Add(labelCodigo);
            groupDatosPersonales.Controls.Add(textCodigo);
            groupDatosPersonales.Controls.Add(labelNombre);
            groupDatosPersonales.Controls.Add(textNombre);
            groupDatosPersonales.Controls.Add(labelApellido);
            groupDatosPersonales.Controls.Add(textApellido);
            groupDatosPersonales.Controls.Add(labelDui);
            groupDatosPersonales.Controls.Add(textDui);
            groupDatosPersonales.Controls.Add(labelFechaNacimiento);
            groupDatosPersonales.Controls.Add(dateFechaNacimiento);
            groupDatosPersonales.Controls.Add(labelTelefono);
            groupDatosPersonales.Controls.Add(textTelefono);
            groupDatosPersonales.Controls.Add(labelCorreo);
            groupDatosPersonales.Controls.Add(textCorreo);

            // 
            // groupDatosAcademicos
            // 
            groupDatosAcademicos.Font = new Font(
                "Comic Sans MS",
                10F,
                FontStyle.Bold
            );
            groupDatosAcademicos.Location = new Point(20, 295);
            groupDatosAcademicos.Name = "groupDatosAcademicos";
            groupDatosAcademicos.Size = new Size(646, 85);
            groupDatosAcademicos.Text = "Datos académicos";

            // 
            // labelGrado
            // 
            labelGrado.AutoSize = true;
            labelGrado.Font = new Font("Comic Sans MS", 9F);
            labelGrado.Location = new Point(20, 38);
            labelGrado.Name = "labelGrado";
            labelGrado.Text = "Grado:";

            // 
            // comboGrado
            // 
            comboGrado.Font = new Font("Comic Sans MS", 9F);
            comboGrado.FormattingEnabled = true;
            comboGrado.Location = new Point(75, 35);
            comboGrado.Name = "comboGrado";
            comboGrado.Size = new Size(130, 25);

            // 
            // labelSeccion
            // 
            labelSeccion.AutoSize = true;
            labelSeccion.Font = new Font("Comic Sans MS", 9F);
            labelSeccion.Location = new Point(235, 38);
            labelSeccion.Name = "labelSeccion";
            labelSeccion.Text = "Sección:";

            // 
            // comboSeccion
            // 
            comboSeccion.Font = new Font("Comic Sans MS", 9F);
            comboSeccion.FormattingEnabled = true;
            comboSeccion.Location = new Point(300, 35);
            comboSeccion.Name = "comboSeccion";
            comboSeccion.Size = new Size(100, 25);

            // 
            // labelAnio
            // 
            labelAnio.AutoSize = true;
            labelAnio.Font = new Font("Comic Sans MS", 9F);
            labelAnio.Location = new Point(425, 38);
            labelAnio.Name = "labelAnio";
            labelAnio.Text = "Año:";

            // 
            // textAnio
            // 
            textAnio.Font = new Font("Comic Sans MS", 9F);
            textAnio.Location = new Point(465, 35);
            textAnio.Name = "textAnio";
            textAnio.Size = new Size(100, 24);

            groupDatosAcademicos.Controls.Add(labelGrado);
            groupDatosAcademicos.Controls.Add(comboGrado);
            groupDatosAcademicos.Controls.Add(labelSeccion);
            groupDatosAcademicos.Controls.Add(comboSeccion);
            groupDatosAcademicos.Controls.Add(labelAnio);
            groupDatosAcademicos.Controls.Add(textAnio);

            // 
            // botones
            // 

            buttonNuevo.Font = new Font("Comic Sans MS", 9F);
            buttonNuevo.Location = new Point(20, 395);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(120, 35);
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;

            buttonGuardar.Font = new Font("Comic Sans MS", 9F);
            buttonGuardar.Location = new Point(155, 395);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(120, 35);
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;

            buttonModificar.Font = new Font("Comic Sans MS", 9F);
            buttonModificar.Location = new Point(290, 395);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(120, 35);
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;

            buttonLimpiar.Font = new Font("Comic Sans MS", 9F);
            buttonLimpiar.Location = new Point(425, 395);
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
            groupBuscar.Location = new Point(20, 445);
            groupBuscar.Name = "groupBuscar";
            groupBuscar.Size = new Size(646, 70);
            groupBuscar.Text = "Buscar estudiante";

            // 
            // labelBuscar
            // 
            labelBuscar.AutoSize = true;
            labelBuscar.Font = new Font("Comic Sans MS", 8.5F);
            labelBuscar.Location = new Point(15, 30);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Text = "Código / nombre:";

            // 
            // textBuscar
            // 
            textBuscar.Font = new Font("Comic Sans MS", 9F);
            textBuscar.Location = new Point(120, 27);
            textBuscar.Name = "textBuscar";
            textBuscar.Size = new Size(300, 24);

            // 
            // buttonBuscar
            // 
            buttonBuscar.Font = new Font("Comic Sans MS", 9F);
            buttonBuscar.Location = new Point(435, 25);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(100, 28);
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;

            groupBuscar.Controls.Add(labelBuscar);
            groupBuscar.Controls.Add(textBuscar);
            groupBuscar.Controls.Add(buttonBuscar);

            // 
            // FrmEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(686, 539);

            Controls.Add(panelTitulo);
            Controls.Add(groupDatosPersonales);
            Controls.Add(groupDatosAcademicos);
            Controls.Add(buttonNuevo);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonLimpiar);
            Controls.Add(groupBuscar);

            Name = "FrmEstudiante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Estudiante";

            panelTitulo.ResumeLayout(false);
            groupDatosPersonales.ResumeLayout(false);
            groupDatosPersonales.PerformLayout();
            groupDatosAcademicos.ResumeLayout(false);
            groupDatosAcademicos.PerformLayout();
            groupBuscar.ResumeLayout(false);
            groupBuscar.PerformLayout();

            this.ResumeLayout(false);
        }

        #endregion

        private Panel panelTitulo;
        private Label labelTitulo;

        private GroupBox groupDatosPersonales;
        private GroupBox groupDatosAcademicos;
        private GroupBox groupBuscar;

        private Label labelCodigo;
        private Label labelNombre;
        private Label labelApellido;
        private Label labelDui;
        private Label labelFechaNacimiento;
        private Label labelTelefono;
        private Label labelCorreo;

        private Label labelGrado;
        private Label labelSeccion;
        private Label labelAnio;

        private TextBox textCodigo;
        private TextBox textNombre;
        private TextBox textApellido;
        private TextBox textDui;
        private TextBox textTelefono;
        private TextBox textCorreo;

        private DateTimePicker dateFechaNacimiento;

        private ComboBox comboGrado;
        private ComboBox comboSeccion;
        private TextBox textAnio;

        private Button buttonNuevo;
        private Button buttonGuardar;
        private Button buttonModificar;
        private Button buttonLimpiar;

        private Label labelBuscar;
        private TextBox textBuscar;
        private Button buttonBuscar;
    }
}