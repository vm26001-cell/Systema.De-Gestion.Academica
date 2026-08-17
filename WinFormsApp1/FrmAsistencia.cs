using System;
using System.Windows.Forms;

namespace Systema.De.Gestion.Academica.UI
{
    public partial class FrmAsistencia : Form
    {
        public FrmAsistencia()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "La asistencia se guardó correctamente.",
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