using System;
using System.Windows.Forms;

namespace Systema.De_Gestion.Academica.UI
{
    public partial class FrmPortalAdministrador : Form
    {
        private string rolUsuario;

        public FrmPortalAdministrador(string rol)
        {
            InitializeComponent();

            rolUsuario = rol;

            ConfigurarPermisos();
        }

        private void ConfigurarPermisos()
        {
            // Primero ocultamos todo
            buttonEstudiantes.Visible = false;
            buttonDocentes.Visible = false;
            buttonMaterias.Visible = false;
            buttonCalificaciones.Visible = false;
            buttonAsistencia.Visible = false;
            buttonReportes.Visible = false;
            buttonHorarios.Visible = false;

            groupEstudiantes.Visible = false;
            groupDocentes.Visible = false;
            groupMaterias.Visible = false;
            groupCalificaciones.Visible = false;
            groupAsistencia.Visible = false;
            groupReportes.Visible = false;
            groupHorarios.Visible = false;

            // ADMINISTRADOR
            if (rolUsuario == "Administrador")
            {
                buttonEstudiantes.Visible = true;
                buttonDocentes.Visible = true;
                buttonMaterias.Visible = true;
                buttonCalificaciones.Visible = true;
                buttonAsistencia.Visible = true;
                buttonReportes.Visible = true;
                buttonHorarios.Visible = true;

                groupEstudiantes.Visible = true;
                groupDocentes.Visible = true;
                groupMaterias.Visible = true;
                groupCalificaciones.Visible = true;
                groupAsistencia.Visible = true;
                groupReportes.Visible = true;
                groupHorarios.Visible = true;

                labelTitulo.Text = "Portal Administrador";
                labelBienvenida.Text = "Bienvenido, Administrador";
            }

            // DOCENTE
            else if (rolUsuario == "Docente")
            {
                buttonCalificaciones.Visible = true;
                buttonAsistencia.Visible = true;
                buttonHorarios.Visible = true;

                groupCalificaciones.Visible = true;
                groupAsistencia.Visible = true;
                groupHorarios.Visible = true;

                labelTitulo.Text = "Portal Docente";
                labelBienvenida.Text = "Bienvenido, Docente";
            }

            // ESTUDIANTE
            else if (rolUsuario == "Estudiante")
            {
                buttonCalificaciones.Visible = true;
                buttonAsistencia.Visible = true;
                buttonHorarios.Visible = true;

                groupCalificaciones.Visible = true;
                groupAsistencia.Visible = true;
                groupHorarios.Visible = true;

                labelTitulo.Text = "Portal Estudiante";
                labelBienvenida.Text = "Bienvenido, Estudiante";
            }

            // PADRE
            else if (rolUsuario == "Padre")
            {
                buttonCalificaciones.Visible = true;
                buttonAsistencia.Visible = true;

                groupCalificaciones.Visible = true;
                groupAsistencia.Visible = true;

                labelTitulo.Text = "Portal Padre";
                labelBienvenida.Text = "Bienvenido, Padre";
            }
        }

        private void buttonEstudiantes_Click(object sender, EventArgs e)
        {
            FrmEstudiante frm = new FrmEstudiante();
            frm.Show();
        }

        private void buttonDocentes_Click(object sender, EventArgs e)
        {
            FrmDocente frm = new FrmDocente();
            frm.Show();
        }

        private void buttonMaterias_Click(object sender, EventArgs e)
        {
            FrmMateria frm = new FrmMateria();
            frm.Show();
        }

        private void buttonCalificaciones_Click(object sender, EventArgs e)
        {
            FrmCalificacion frm = new FrmCalificacion();
            frm.Show();
        }

        private void buttonAsistencia_Click(object sender, EventArgs e)
        {
            FrmAsistencia frm = new FrmAsistencia();
            frm.Show();
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            FrmReporte frm = new FrmReporte();
            frm.Show();
        }

        private void buttonHorarios_Click(object sender, EventArgs e)
        {
            FrmHorario frm = new FrmHorario();
            frm.Show();
        }
    }
}