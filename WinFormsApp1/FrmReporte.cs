using System;
using System.Windows.Forms;

namespace Systema.De.Gestion.Academica.UI
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Reporte generado correctamente.",
                "Sistema Académico",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}