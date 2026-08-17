namespace Systema.De_Gestion.Academica.UI
{
    partial class FrmPortalAdministrador
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
            panelMenu = new Panel();
            panelContenido = new Panel();

            labelSistema = new Label();
            labelTitulo = new Label();
            labelBienvenida = new Label();

            buttonInicio = new Button();
            buttonEstudiantes = new Button();
            buttonDocentes = new Button();
            buttonMaterias = new Button();
            buttonCalificaciones = new Button();
            buttonAsistencia = new Button();
            buttonReportes = new Button();
            buttonHorarios = new Button();
            buttonCerrarSesion = new Button();

            groupEstudiantes = new GroupBox();
            groupDocentes = new GroupBox();
            groupMaterias = new GroupBox();
            groupCalificaciones = new GroupBox();
            groupAsistencia = new GroupBox();
            groupReportes = new GroupBox();
            groupHorarios = new GroupBox();

            labelEstudiantes = new Label();
            labelDocentes = new Label();
            labelMaterias = new Label();
            labelCalificaciones = new Label();
            labelAsistencia = new Label();
            labelReportes = new Label();
            labelHorarios = new Label();

            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(35, 45, 55);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(175, 539);
            panelMenu.TabIndex = 0;

            // 
            // labelSistema
            // 
            labelSistema.AutoSize = false;
            labelSistema.Font = new Font(
                "Comic Sans MS",
                12F,
                FontStyle.Bold
            );
            labelSistema.ForeColor = Color.White;
            labelSistema.Location = new Point(5, 15);
            labelSistema.Name = "labelSistema";
            labelSistema.Size = new Size(165, 55);
            labelSistema.Text = "SISTEMA\nACADÉMICO";
            labelSistema.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // buttonInicio
            // 
            buttonInicio.BackColor = Color.FromArgb(50, 60, 70);
            buttonInicio.FlatAppearance.BorderSize = 0;
            buttonInicio.FlatStyle = FlatStyle.Flat;
            buttonInicio.Font = new Font("Comic Sans MS", 9F);
            buttonInicio.ForeColor = Color.White;
            buttonInicio.Location = new Point(8, 85);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(159, 32);
            buttonInicio.Text = "Inicio";
            buttonInicio.UseVisualStyleBackColor = false;

            // 
            // buttonEstudiantes
            // 
            buttonEstudiantes.BackColor = Color.FromArgb(50, 60, 70);
            buttonEstudiantes.FlatAppearance.BorderSize = 0;
            buttonEstudiantes.FlatStyle = FlatStyle.Flat;
            buttonEstudiantes.Font = new Font("Comic Sans MS", 9F);
            buttonEstudiantes.ForeColor = Color.White;
            buttonEstudiantes.Location = new Point(8, 123);
            buttonEstudiantes.Name = "buttonEstudiantes";
            buttonEstudiantes.Size = new Size(159, 32);
            buttonEstudiantes.Text = "Estudiantes";
            buttonEstudiantes.UseVisualStyleBackColor = false;

            // 
            // buttonDocentes
            // 
            buttonDocentes.BackColor = Color.FromArgb(50, 60, 70);
            buttonDocentes.FlatAppearance.BorderSize = 0;
            buttonDocentes.FlatStyle = FlatStyle.Flat;
            buttonDocentes.Font = new Font("Comic Sans MS", 9F);
            buttonDocentes.ForeColor = Color.White;
            buttonDocentes.Location = new Point(8, 161);
            buttonDocentes.Name = "buttonDocentes";
            buttonDocentes.Size = new Size(159, 32);
            buttonDocentes.Text = "Docentes";
            buttonDocentes.UseVisualStyleBackColor = false;

            // 
            // buttonMaterias
            // 
            buttonMaterias.BackColor = Color.FromArgb(50, 60, 70);
            buttonMaterias.FlatAppearance.BorderSize = 0;
            buttonMaterias.FlatStyle = FlatStyle.Flat;
            buttonMaterias.Font = new Font("Comic Sans MS", 9F);
            buttonMaterias.ForeColor = Color.White;
            buttonMaterias.Location = new Point(8, 199);
            buttonMaterias.Name = "buttonMaterias";
            buttonMaterias.Size = new Size(159, 32);
            buttonMaterias.Text = "Materias";
            buttonMaterias.UseVisualStyleBackColor = false;

            // 
            // buttonCalificaciones
            // 
            buttonCalificaciones.BackColor = Color.FromArgb(50, 60, 70);
            buttonCalificaciones.FlatAppearance.BorderSize = 0;
            buttonCalificaciones.FlatStyle = FlatStyle.Flat;
            buttonCalificaciones.Font = new Font("Comic Sans MS", 9F);
            buttonCalificaciones.ForeColor = Color.White;
            buttonCalificaciones.Location = new Point(8, 237);
            buttonCalificaciones.Name = "buttonCalificaciones";
            buttonCalificaciones.Size = new Size(159, 32);
            buttonCalificaciones.Text = "Calificaciones";
            buttonCalificaciones.UseVisualStyleBackColor = false;

            // 
            // buttonAsistencia
            // 
            buttonAsistencia.BackColor = Color.FromArgb(50, 60, 70);
            buttonAsistencia.FlatAppearance.BorderSize = 0;
            buttonAsistencia.FlatStyle = FlatStyle.Flat;
            buttonAsistencia.Font = new Font("Comic Sans MS", 9F);
            buttonAsistencia.ForeColor = Color.White;
            buttonAsistencia.Location = new Point(8, 275);
            buttonAsistencia.Name = "buttonAsistencia";
            buttonAsistencia.Size = new Size(159, 32);
            buttonAsistencia.Text = "Asistencia";
            buttonAsistencia.UseVisualStyleBackColor = false;

            // 
            // buttonReportes
            // 
            buttonReportes.BackColor = Color.FromArgb(50, 60, 70);
            buttonReportes.FlatAppearance.BorderSize = 0;
            buttonReportes.FlatStyle = FlatStyle.Flat;
            buttonReportes.Font = new Font("Comic Sans MS", 9F);
            buttonReportes.ForeColor = Color.White;
            buttonReportes.Location = new Point(8, 313);
            buttonReportes.Name = "buttonReportes";
            buttonReportes.Size = new Size(159, 32);
            buttonReportes.Text = "Reportes";
            buttonReportes.UseVisualStyleBackColor = false;

            // 
            // buttonHorarios
            // 
            buttonHorarios.BackColor = Color.FromArgb(50, 60, 70);
            buttonHorarios.FlatAppearance.BorderSize = 0;
            buttonHorarios.FlatStyle = FlatStyle.Flat;
            buttonHorarios.Font = new Font("Comic Sans MS", 9F);
            buttonHorarios.ForeColor = Color.White;
            buttonHorarios.Location = new Point(8, 351);
            buttonHorarios.Name = "buttonHorarios";
            buttonHorarios.Size = new Size(159, 32);
            buttonHorarios.Text = "Horarios";
            buttonHorarios.UseVisualStyleBackColor = false;

            // 
            // buttonCerrarSesion
            // 
            buttonCerrarSesion.BackColor = Color.FromArgb(130, 50, 50);
            buttonCerrarSesion.FlatAppearance.BorderSize = 0;
            buttonCerrarSesion.FlatStyle = FlatStyle.Flat;
            buttonCerrarSesion.Font = new Font("Comic Sans MS", 9F);
            buttonCerrarSesion.ForeColor = Color.White;
            buttonCerrarSesion.Location = new Point(8, 485);
            buttonCerrarSesion.Name = "buttonCerrarSesion";
            buttonCerrarSesion.Size = new Size(159, 32);
            buttonCerrarSesion.Text = "Cerrar sesión";
            buttonCerrarSesion.UseVisualStyleBackColor = false;

            // Agregar controles al menú
            panelMenu.Controls.Add(labelSistema);
            panelMenu.Controls.Add(buttonInicio);
            panelMenu.Controls.Add(buttonEstudiantes);
            panelMenu.Controls.Add(buttonDocentes);
            panelMenu.Controls.Add(buttonMaterias);
            panelMenu.Controls.Add(buttonCalificaciones);
            panelMenu.Controls.Add(buttonAsistencia);
            panelMenu.Controls.Add(buttonReportes);
            panelMenu.Controls.Add(buttonHorarios);
            panelMenu.Controls.Add(buttonCerrarSesion);

            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.White;
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(175, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(511, 539);
            panelContenido.TabIndex = 1;

            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font(
                "Comic Sans MS",
                18F,
                FontStyle.Bold
            );
            labelTitulo.Location = new Point(25, 20);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(260, 34);
            labelTitulo.Text = "Portal Administrador";

            // 
            // labelBienvenida
            // 
            labelBienvenida.AutoSize = true;
            labelBienvenida.Font = new Font(
                "Comic Sans MS",
                10F
            );
            labelBienvenida.Location = new Point(28, 60);
            labelBienvenida.Name = "labelBienvenida";
            labelBienvenida.Size = new Size(180, 19);
            labelBienvenida.Text = "Bienvenido, Administrador";

            // 
            // groupEstudiantes
            // 
            groupEstudiantes.Font = new Font(
                "Comic Sans MS",
                9F,
                FontStyle.Bold
            );
            groupEstudiantes.Location = new Point(25, 100);
            groupEstudiantes.Name = "groupEstudiantes";
            groupEstudiantes.Size = new Size(145, 100);
            groupEstudiantes.Text = "Estudiantes";

            // 
            // labelEstudiantes
            // 
            labelEstudiantes.AutoSize = true;
            labelEstudiantes.Font = new Font("Comic Sans MS", 8F);
            labelEstudiantes.Location = new Point(15, 40);
            labelEstudiantes.Name = "labelEstudiantes";
            labelEstudiantes.Text = "Gestionar estudiantes";

            groupEstudiantes.Controls.Add(labelEstudiantes);

            // 
            // groupDocentes
            // 
            groupDocentes.Font = new Font(
                "Comic Sans MS",
                9F,
                FontStyle.Bold
            );
            groupDocentes.Location = new Point(185, 100);
            groupDocentes.Name = "groupDocentes";
            groupDocentes.Size = new Size(145, 100);
            groupDocentes.Text = "Docentes";

            // 
            // labelDocentes
            // 
            labelDocentes.AutoSize = true;
            labelDocentes.Font = new Font("Comic Sans MS", 8F);
            labelDocentes.Location = new Point(15, 40);
            labelDocentes.Name = "labelDocentes";
            labelDocentes.Text = "Gestionar docentes";

            groupDocentes.Controls.Add(labelDocentes);

            // 
            // groupMaterias
            // 
            groupMaterias.Font = new Font(
                "Comic Sans MS",
                9F,
                FontStyle.Bold
            );
            groupMaterias.Location = new Point(345, 100);
            groupMaterias.Name = "groupMaterias";
            groupMaterias.Size = new Size(145, 100);
            groupMaterias.Text = "Materias";

            // 
            // labelMaterias
            // 
            labelMaterias.AutoSize = true;
            labelMaterias.Font = new Font("Comic Sans MS", 8F);
            labelMaterias.Location = new Point(15, 40);
            labelMaterias.Name = "labelMaterias";
            labelMaterias.Text = "Gestionar materias";

            groupMaterias.Controls.Add(labelMaterias);

            // 
            // groupCalificaciones
            // 
            groupCalificaciones.Font = new Font(
                "Comic Sans MS",
                8.5F,
                FontStyle.Bold
            );
            groupCalificaciones.Location = new Point(25, 215);
            groupCalificaciones.Name = "groupCalificaciones";
            groupCalificaciones.Size = new Size(145, 100);
            groupCalificaciones.Text = "Calificaciones";

            // 
            // labelCalificaciones
            // 
            labelCalificaciones.AutoSize = true;
            labelCalificaciones.Font = new Font("Comic Sans MS", 8F);
            labelCalificaciones.Location = new Point(15, 40);
            labelCalificaciones.Name = "labelCalificaciones";
            labelCalificaciones.Text = "Registro de notas";

            groupCalificaciones.Controls.Add(labelCalificaciones);

            // 
            // groupAsistencia
            // 
            groupAsistencia.Font = new Font(
                "Comic Sans MS",
                9F,
                FontStyle.Bold
            );
            groupAsistencia.Location = new Point(185, 215);
            groupAsistencia.Name = "groupAsistencia";
            groupAsistencia.Size = new Size(145, 100);
            groupAsistencia.Text = "Asistencia";

            // 
            // labelAsistencia
            // 
            labelAsistencia.AutoSize = true;
            labelAsistencia.Font = new Font("Comic Sans MS", 8F);
            labelAsistencia.Location = new Point(15, 40);
            labelAsistencia.Name = "labelAsistencia";
            labelAsistencia.Text = "Control de asistencia";

            groupAsistencia.Controls.Add(labelAsistencia);

            // 
            // groupReportes
            // 
            groupReportes.Font = new Font(
                "Comic Sans MS",
                9F,
                FontStyle.Bold
            );
            groupReportes.Location = new Point(345, 215);
            groupReportes.Name = "groupReportes";
            groupReportes.Size = new Size(145, 100);
            groupReportes.Text = "Reportes";

            // 
            // labelReportes
            // 
            labelReportes.AutoSize = true;
            labelReportes.Font = new Font("Comic Sans MS", 8F);
            labelReportes.Location = new Point(15, 40);
            labelReportes.Name = "labelReportes";
            labelReportes.Text = "Reportes académicos";

            groupReportes.Controls.Add(labelReportes);

            // 
            // groupHorarios
            // 
            groupHorarios.Font = new Font(
                "Comic Sans MS",
                9F,
                FontStyle.Bold
            );
            groupHorarios.Location = new Point(25, 330);
            groupHorarios.Name = "groupHorarios";
            groupHorarios.Size = new Size(145, 100);
            groupHorarios.Text = "Horarios";

            // 
            // labelHorarios
            // 
            labelHorarios.AutoSize = true;
            labelHorarios.Font = new Font("Comic Sans MS", 8F);
            labelHorarios.Location = new Point(15, 40);
            labelHorarios.Name = "labelHorarios";
            labelHorarios.Text = "Gestión de horarios";

            groupHorarios.Controls.Add(labelHorarios);

            // Agregar contenido
            panelContenido.Controls.Add(labelTitulo);
            panelContenido.Controls.Add(labelBienvenida);
            panelContenido.Controls.Add(groupEstudiantes);
            panelContenido.Controls.Add(groupDocentes);
            panelContenido.Controls.Add(groupMaterias);
            panelContenido.Controls.Add(groupCalificaciones);
            panelContenido.Controls.Add(groupAsistencia);
            panelContenido.Controls.Add(groupReportes);
            panelContenido.Controls.Add(groupHorarios);

            // 
            // FrmPortalAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(686, 539);

            Controls.Add(panelContenido);
            Controls.Add(panelMenu);

            Name = "FrmPortalAdministrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Portal Administrador";

            this.ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelContenido;

        private Label labelSistema;
        private Label labelTitulo;
        private Label labelBienvenida;

        private Button buttonInicio;
        private Button buttonEstudiantes;
        private Button buttonDocentes;
        private Button buttonMaterias;
        private Button buttonCalificaciones;
        private Button buttonAsistencia;
        private Button buttonReportes;
        private Button buttonHorarios;
        private Button buttonCerrarSesion;

        private GroupBox groupEstudiantes;
        private GroupBox groupDocentes;
        private GroupBox groupMaterias;
        private GroupBox groupCalificaciones;
        private GroupBox groupAsistencia;
        private GroupBox groupReportes;
        private GroupBox groupHorarios;

        private Label labelEstudiantes;
        private Label labelDocentes;
        private Label labelMaterias;
        private Label labelCalificaciones;
        private Label labelAsistencia;
        private Label labelReportes;
        private Label labelHorarios;
    }
}