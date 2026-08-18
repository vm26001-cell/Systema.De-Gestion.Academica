using System;
using System.Windows.Forms;
using Systema.De.Gestion.Academica.UI;

namespace Systema.De_Gestion.Academica.UI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inicio");
        }

        private void btnPanelPrincipal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Panel Principal");
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resumen");
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            FrmEstudiante formulario = new FrmEstudiante();
            formulario.ShowDialog();
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            FrmDocente formulario = new FrmDocente();
            formulario.ShowDialog();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            FrmMateria formulario = new FrmMateria();
            formulario.ShowDialog();
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            FrmCalificacion formulario = new FrmCalificacion();
            formulario.ShowDialog();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            FrmAsistencia formulario = new FrmAsistencia();
            formulario.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}