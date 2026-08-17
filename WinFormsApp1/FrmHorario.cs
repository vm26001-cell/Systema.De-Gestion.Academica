using System;
using System.Windows.Forms;

namespace Systema.De.Gestion.Academica.UI
{
    public partial class FrmHorario : Form
    {
        public FrmHorario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "El horario se guardó correctamente.",
                "Sistema Académico",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea cancelar?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cmbMateria.SelectedIndex = -1;
            cmbDocente.SelectedIndex = -1;
            cmbAula.SelectedIndex = -1;
            txtHoraInicio.Text = "";
            txtHoraFin.Text = "";
        }
    }
}