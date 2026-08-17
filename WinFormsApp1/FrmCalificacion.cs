using System;
using System.Windows.Forms;

namespace Systema.De.Gestion.Academica.UI
{
    public partial class FrmCalificacion : Form
    {
        public FrmCalificacion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Las calificaciones se guardaron correctamente.",
                "Sistema Académico",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}