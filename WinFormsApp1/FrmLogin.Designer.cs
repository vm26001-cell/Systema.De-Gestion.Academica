namespace Systema.De_Gestion.Academica.UI
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
            lblIcono = new Label();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            cmbRol = new ComboBox();
            btnIngresar = new Button();
            lblOlvide = new Label();
            SuspendLayout();
            // 
            // lblIcono
            // 
            lblIcono.Font = new Font("Segoe UI Symbol", 50F);
            lblIcono.Location = new Point(135, 25);
            lblIcono.Name = "lblIcono";
            lblIcono.Size = new Size(150, 90);
            lblIcono.TabIndex = 0;
            lblIcono.Text = "🎓";
            lblIcono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(40, 120);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(340, 40);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "SISTEMA ACADÉMICO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSubtitulo.Location = new Point(40, 165);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(340, 30);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Iniciar Sesión";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F);
            lblUsuario.Location = new Point(55, 215);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(65, 15);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "👤  Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.Location = new Point(55, 240);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese su usuario";
            txtUsuario.Size = new Size(310, 25);
            txtUsuario.TabIndex = 4;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 9F);
            lblContrasena.Location = new Point(55, 290);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(85, 15);
            lblContrasena.TabIndex = 5;
            lblContrasena.Text = "🔒  Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.Font = new Font("Segoe UI", 10F);
            txtContrasena.Location = new Point(55, 315);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PlaceholderText = "Ingrese su contraseña";
            txtContrasena.Size = new Size(310, 25);
            txtContrasena.TabIndex = 6;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Font = new Font("Segoe UI", 9F);
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Docente", "Estudiante", "Padre" });
            cmbRol.Location = new Point(55, 365);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(310, 23);
            cmbRol.TabIndex = 7;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(45, 45, 45);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(55, 415);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(310, 42);
            btnIngresar.TabIndex = 8;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblOlvide
            // 
            lblOlvide.Cursor = Cursors.Hand;
            lblOlvide.Font = new Font("Segoe UI", 9F);
            lblOlvide.Location = new Point(55, 475);
            lblOlvide.Name = "lblOlvide";
            lblOlvide.Size = new Size(310, 30);
            lblOlvide.TabIndex = 9;
            lblOlvide.Text = "¿Olvidó su contraseña?";
            lblOlvide.TextAlign = ContentAlignment.MiddleCenter;
            lblOlvide.Click += lblOlvide_Click;
            // 
            // FrmLogin
            // 
            BackColor = Color.White;
            ClientSize = new Size(420, 600);
            Controls.Add(lblIcono);
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(cmbRol);
            Controls.Add(btnIngresar);
            Controls.Add(lblOlvide);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Académico - Iniciar Sesión";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}