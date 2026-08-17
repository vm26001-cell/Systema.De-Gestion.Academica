namespace Systema.De.Gestion.Academica.UI
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblIcono;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;

        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;

        private System.Windows.Forms.ComboBox cmbRol;

        private System.Windows.Forms.Button btnIngresar;

        private System.Windows.Forms.Label lblOlvide;

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

            this.lblIcono =
                new System.Windows.Forms.Label();

            this.lblTitulo =
                new System.Windows.Forms.Label();

            this.lblSubtitulo =
                new System.Windows.Forms.Label();

            this.lblUsuario =
                new System.Windows.Forms.Label();

            this.txtUsuario =
                new System.Windows.Forms.TextBox();

            this.lblContrasena =
                new System.Windows.Forms.Label();

            this.txtContrasena =
                new System.Windows.Forms.TextBox();

            this.cmbRol =
                new System.Windows.Forms.ComboBox();

            this.btnIngresar =
                new System.Windows.Forms.Button();

            this.lblOlvide =
                new System.Windows.Forms.Label();

            this.SuspendLayout();

            // ==========================================
            // FORMULARIO
            // ==========================================

            this.BackColor =
                System.Drawing.Color.White;

            this.ClientSize =
                new System.Drawing.Size(420, 600);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Sistema Académico - Iniciar Sesión";

            // ==========================================
            // ICONO
            // ==========================================

            this.lblIcono.AutoSize = false;

            this.lblIcono.Font =
                new System.Drawing.Font(
                    "Segoe UI Symbol",
                    50F
                );

            this.lblIcono.Location =
                new System.Drawing.Point(135, 25);

            this.lblIcono.Size =
                new System.Drawing.Size(150, 90);

            this.lblIcono.Text =
                "🎓";

            this.lblIcono.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // ==========================================
            // TITULO
            // ==========================================

            this.lblTitulo.AutoSize = false;

            this.lblTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    18F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblTitulo.Location =
                new System.Drawing.Point(40, 120);

            this.lblTitulo.Size =
                new System.Drawing.Size(340, 40);

            this.lblTitulo.Text =
                "SISTEMA ACADÉMICO";

            this.lblTitulo.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // ==========================================
            // SUBTITULO
            // ==========================================

            this.lblSubtitulo.AutoSize = false;

            this.lblSubtitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblSubtitulo.Location =
                new System.Drawing.Point(40, 165);

            this.lblSubtitulo.Size =
                new System.Drawing.Size(340, 30);

            this.lblSubtitulo.Text =
                "Iniciar Sesión";

            this.lblSubtitulo.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // ==========================================
            // LABEL USUARIO
            // ==========================================

            this.lblUsuario.AutoSize = true;

            this.lblUsuario.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F
                );

            this.lblUsuario.Location =
                new System.Drawing.Point(55, 215);

            this.lblUsuario.Text =
                "👤  Usuario";

            // ==========================================
            // TEXTBOX USUARIO
            // ==========================================

            this.txtUsuario.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtUsuario.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F
                );

            this.txtUsuario.Location =
                new System.Drawing.Point(55, 240);

            this.txtUsuario.Size =
                new System.Drawing.Size(310, 30);

            this.txtUsuario.PlaceholderText =
                "Ingrese su usuario";

            // ==========================================
            // LABEL CONTRASEÑA
            // ==========================================

            this.lblContrasena.AutoSize = true;

            this.lblContrasena.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F
                );

            this.lblContrasena.Location =
                new System.Drawing.Point(55, 290);

            this.lblContrasena.Text =
                "🔒  Contraseña";

            // ==========================================
            // TEXTBOX CONTRASEÑA
            // ==========================================

            this.txtContrasena.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtContrasena.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F
                );

            this.txtContrasena.Location =
                new System.Drawing.Point(55, 315);

            this.txtContrasena.Size =
                new System.Drawing.Size(310, 30);

            this.txtContrasena.UseSystemPasswordChar =
                true;

            this.txtContrasena.PlaceholderText =
                "Ingrese su contraseña";

            // ==========================================
            // COMBOBOX ROL
            // ==========================================

            this.cmbRol.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbRol.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F
                );

            this.cmbRol.FormattingEnabled = true;

            this.cmbRol.Location =
                new System.Drawing.Point(55, 365);

            this.cmbRol.Size =
                new System.Drawing.Size(310, 28);

            this.cmbRol.Items.AddRange(
                new object[]
                {
                    "Administrador",
                    "Docente",
                    "Estudiante"
                }
            );

            // ==========================================
            // BOTON INGRESAR
            // ==========================================

            this.btnIngresar.BackColor =
                System.Drawing.Color.FromArgb(
                    45,
                    45,
                    45
                );

            this.btnIngresar.FlatAppearance.BorderSize =
                0;

            this.btnIngresar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnIngresar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnIngresar.ForeColor =
                System.Drawing.Color.White;

            this.btnIngresar.Location =
                new System.Drawing.Point(55, 415);

            this.btnIngresar.Size =
                new System.Drawing.Size(310, 42);

            this.btnIngresar.Text =
                "Ingresar";

            this.btnIngresar.UseVisualStyleBackColor =
                false;

            this.btnIngresar.Click +=
                new System.EventHandler(
                    this.btnIngresar_Click
                );

            // ==========================================
            // OLVIDE CONTRASEÑA
            // ==========================================

            this.lblOlvide.AutoSize = false;

            this.lblOlvide.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.lblOlvide.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F
                );

            this.lblOlvide.Location =
                new System.Drawing.Point(55, 475);

            this.lblOlvide.Size =
                new System.Drawing.Size(310, 30);

            this.lblOlvide.Text =
                "¿Olvidó su contraseña?";

            this.lblOlvide.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            this.lblOlvide.Click +=
                new System.EventHandler(
                    this.lblOlvide_Click
                );

            // ==========================================
            // AGREGAR CONTROLES
            // ==========================================

            this.Controls.Add(
                this.lblIcono
            );

            this.Controls.Add(
                this.lblTitulo
            );

            this.Controls.Add(
                this.lblSubtitulo
            );

            this.Controls.Add(
                this.lblUsuario
            );

            this.Controls.Add(
                this.txtUsuario
            );

            this.Controls.Add(
                this.lblContrasena
            );

            this.Controls.Add(
                this.txtContrasena
            );

            this.Controls.Add(
                this.cmbRol
            );

            this.Controls.Add(
                this.btnIngresar
            );

            this.Controls.Add(
                this.lblOlvide
            );

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}