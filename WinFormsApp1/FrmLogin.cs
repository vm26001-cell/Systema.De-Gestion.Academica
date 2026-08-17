using System;
using System.Windows.Forms;

namespace Systema.De.Gestion.Academica.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show(
                    "Ingrese su usuario.",
                    "Sistema Académico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show(
                    "Ingrese su contraseña.",
                    "Sistema Académico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtContrasena.Focus();
                return;
            }

            if (cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un rol.",
                    "Sistema Académico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbRol.Focus();
                return;
            }

            MessageBox.Show(
                "Inicio de sesión correcto.",
                "Sistema Académico",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void lblOlvide_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Comuníquese con el administrador del sistema.",
                "Recuperar contraseña",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}