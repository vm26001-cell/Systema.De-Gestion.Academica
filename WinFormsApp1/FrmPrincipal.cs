using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Bienvenido al Sistema de Gestión Académica",
                "Inicio",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnPanelPrincipal_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Panel Principal",
                "Sistema Académico",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Resumen del Sistema",
                "Resumen",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Módulo de Estudiantes",
                "Estudiantes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Módulo de Docentes",
                "Docentes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Módulo de Materias",
                "Materias",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Módulo de Calificaciones",
                "Calificaciones",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Módulo de Asistencia",
                "Asistencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea salir?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}