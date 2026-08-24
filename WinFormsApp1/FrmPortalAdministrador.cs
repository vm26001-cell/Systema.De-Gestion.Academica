using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.UI
{
    public partial class FrmPortalAdministrador : Form
    {
        private readonly Usuario usuarioActual;

        public FrmPortalAdministrador(Usuario usuario)
        {
            usuarioActual = usuario ?? throw new ArgumentNullException(nameof(usuario));
            InitializeComponent();
            ConfigurarPermisos();
        }

        private void ConfigurarPermisos()
        {
            OcultarModulos();

            switch (usuarioActual.Rol)
            {
                case "Administrador":
                    Mostrar(buttonEstudiantes, groupEstudiantes);
                    Mostrar(buttonDocentes, groupDocentes);
                    Mostrar(buttonMaterias, groupMaterias);
                    Mostrar(buttonCalificaciones, groupCalificaciones);
                    Mostrar(buttonAsistencia, groupAsistencia);
                    Mostrar(buttonReportes, groupReportes);
                    Mostrar(buttonHorarios, groupHorarios);
                    labelTitulo.Text = "Portal Administrador";
                    break;

                case "Docente":
                    Mostrar(buttonCalificaciones, groupCalificaciones);
                    Mostrar(buttonAsistencia, groupAsistencia);
                    Mostrar(buttonReportes, groupReportes);
                    Mostrar(buttonHorarios, groupHorarios);
                    labelTitulo.Text = "Portal Docente";
                    break;

                case "Estudiante":
                    Mostrar(buttonReportes, groupReportes);
                    Mostrar(buttonHorarios, groupHorarios);
                    labelTitulo.Text = "Portal Estudiante";
                    break;

                case "Padre":
                    Mostrar(buttonReportes, groupReportes);
                    Mostrar(buttonHorarios, groupHorarios);
                    labelTitulo.Text = "Portal Padre";
                    break;

                default:
                    throw new UnauthorizedAccessException("El rol del usuario no está autorizado.");
            }

            labelBienvenida.Text = "Bienvenido, " + usuarioActual.UsuarioNombre;
        }

        private void OcultarModulos()
        {
            foreach (Control control in new Control[]
            {
                buttonEstudiantes, buttonDocentes, buttonMaterias,
                buttonCalificaciones, buttonAsistencia, buttonReportes, buttonHorarios,
                groupEstudiantes, groupDocentes, groupMaterias,
                groupCalificaciones, groupAsistencia, groupReportes, groupHorarios
            })
            {
                control.Visible = false;
            }
        }

        private static void Mostrar(Control boton, Control tarjeta)
        {
            boton.Visible = true;
            tarjeta.Visible = true;
        }

        private void buttonEstudiantes_Click(object sender, EventArgs e) => new FrmEstudiante().ShowDialog(this);
        private void buttonDocentes_Click(object sender, EventArgs e) => new FrmDocente().ShowDialog(this);
        private void buttonMaterias_Click(object sender, EventArgs e) => new FrmMateria().ShowDialog(this);
        private void buttonCalificaciones_Click(object sender, EventArgs e) => new FrmCalificacion().ShowDialog(this);
        private void buttonAsistencia_Click(object sender, EventArgs e) => new FrmAsistencia().ShowDialog(this);
        private void buttonReportes_Click(object sender, EventArgs e) => new FrmReporte(usuarioActual).ShowDialog(this);
        private void buttonHorarios_Click(object sender, EventArgs e) => new FrmHorario().ShowDialog(this);
    }
}
