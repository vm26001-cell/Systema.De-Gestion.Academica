using Systema.De_Gestion.Academica.EN;
using Systema.De_Gestion.Academica.LN;

namespace Systema.De_Gestion.Academica.UI
{
    public partial class FrmLogin : Form
    {
        private readonly LoginBL loginBL = new LoginBL();

        public FrmLogin()
        {
            InitializeComponent();

            cmbRol.Items.Clear();
            cmbRol.Items.AddRange(new object[]
            {
                "Administrador",
                "Docente",
                "Padre",
                "Estudiante"
            });
            cmbRol.SelectedIndex = 0;
            AcceptButton = btnIngresar;
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
            string rol = cmbRol.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(usuario))
            {
                MostrarValidacion("Ingrese su usuario.", txtUsuario);
                return;
            }

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                MostrarValidacion("Ingrese su contraseña.", txtContrasena);
                return;
            }

            if (string.IsNullOrWhiteSpace(rol))
            {
                MostrarValidacion("Seleccione un rol.", cmbRol);
                return;
            }

            try
            {
                Usuario? usuarioEncontrado = loginBL.ValidarLogin(usuario, contrasena, rol);
                if (usuarioEncontrado == null)
                {
                    MessageBox.Show(
                        "Usuario, contraseña o rol incorrectos.",
                        "Acceso denegado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtContrasena.Clear();
                    txtContrasena.Focus();
                    return;
                }

                MessageBox.Show(
                    "Bienvenido, " + usuarioEncontrado.UsuarioNombre + ".",
                    "Acceso correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                var principal = new FrmPortalAdministrador(usuarioEncontrado);
                principal.FormClosed += (_, _) => Close();
                principal.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible iniciar sesión.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static void MostrarValidacion(string mensaje, Control control)
        {
            MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }
    }
}
