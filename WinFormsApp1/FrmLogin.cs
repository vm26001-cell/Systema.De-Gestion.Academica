using System;
using System.Windows.Forms;
using Systema.De_Gestion.Academica.EN;
using Systema.De_Gestion.Academica.LN;

namespace Systema.De_Gestion.Academica.UI
{
    public partial class FrmLogin : Form
    {
        private readonly LoginBL loginBL;

        public FrmLogin()
        {
            InitializeComponent();

            loginBL = new LoginBL();

            cmbRol.Items.Clear();
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Docente");
            cmbRol.Items.Add("Padre");

            cmbRol.SelectedIndex = 0;
        }

        private void lblOlvide_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Comuníquese con el administrador para recuperar su contraseña.",
                "Recuperar contraseña",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;
            string rol = cmbRol.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Ingrese su usuario.");
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Ingrese su contraseña.");
                txtContrasena.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(rol))
            {
                MessageBox.Show("Seleccione un rol.");
                cmbRol.Focus();
                return;
            }

            try
            {
                Usuario usuarioEncontrado =
                    loginBL.ValidarLogin(
                        usuario,
                        contrasena,
                        rol);

                if (usuarioEncontrado != null)
                {
                    MessageBox.Show(
                        "Bienvenido " + usuarioEncontrado.UsuarioNombre);

                    FrmPortalAdministrador principal = new FrmPortalAdministrador();
                    principal.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Usuario, contraseña o rol incorrectos.",
                        "Acceso denegado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtContrasena.Clear();
                    txtContrasena.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al iniciar sesión:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}