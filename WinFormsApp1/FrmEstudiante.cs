using System;
using System.Windows.Forms;
using Systema.De_Gestion.Academica.EN;
using Systema.De_Gestion.Academica.LN;

namespace Systema.De_Gestion.Academica.UI
{
    public partial class FrmEstudiante : Form
    {
        private readonly EstudianteBL estudianteBL;

        public FrmEstudiante()
        {
            InitializeComponent();

            estudianteBL = new EstudianteBL();

            CargarCombos();

            buttonNuevo.Click += buttonNuevo_Click;
            buttonGuardar.Click += buttonGuardar_Click;
            buttonModificar.Click += buttonModificar_Click;
            buttonLimpiar.Click += buttonLimpiar_Click;
            buttonBuscar.Click += buttonBuscar_Click;
        }

        // =====================================================
        // CARGAR COMBOS
        // =====================================================

        private void CargarCombos()
        {
            comboGrado.Items.Clear();

            comboGrado.Items.Add("1°");
            comboGrado.Items.Add("2°");
            comboGrado.Items.Add("3°");
            comboGrado.Items.Add("4°");
            comboGrado.Items.Add("5°");
            comboGrado.Items.Add("6°");
            comboGrado.Items.Add("7°");
            comboGrado.Items.Add("8°");
            comboGrado.Items.Add("9°");
            comboGrado.Items.Add("1° Bachillerato");
            comboGrado.Items.Add("2° Bachillerato");

            comboSeccion.Items.Clear();

            comboSeccion.Items.Add("A");
            comboSeccion.Items.Add("B");
            comboSeccion.Items.Add("C");

            comboGrado.SelectedIndex = -1;
            comboSeccion.SelectedIndex = -1;
        }

        // =====================================================
        // NUEVO
        // =====================================================

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();

            textCodigo.Focus();
        }

        // =====================================================
        // GUARDAR
        // =====================================================

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante estudiante = ObtenerDatosFormulario();

                bool resultado =
                    estudianteBL.Guardar(estudiante);

                if (resultado)
                {
                    MessageBox.Show(
                        "Estudiante guardado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // MODIFICAR
        // =====================================================

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante estudiante = ObtenerDatosFormulario();

                bool resultado =
                    estudianteBL.Modificar(estudiante);

                if (resultado)
                {
                    MessageBox.Show(
                        "Estudiante modificado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // BUSCAR
        // =====================================================

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = textBuscar.Text.Trim();

                if (string.IsNullOrWhiteSpace(texto))
                {
                    MessageBox.Show(
                        "Ingrese un código o nombre.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Si parece código, buscar directamente
                Estudiante estudiante =
                    estudianteBL.BuscarPorCodigo(texto);

                if (estudiante != null)
                {
                    MostrarDatos(estudiante);
                    return;
                }

                // Si no encontró por código,
                // buscar por nombre/apellido
                var resultados =
                    estudianteBL.Buscar(texto);

                if (resultados.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontró ningún estudiante.",
                        "Buscar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                if (resultados.Count == 1)
                {
                    MostrarDatos(resultados[0]);
                    return;
                }

                MessageBox.Show(
                    "Se encontraron " +
                    resultados.Count +
                    " estudiantes. " +
                    "Use el código exacto para seleccionar uno.",
                    "Buscar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // LIMPIAR
        // =====================================================

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        // =====================================================
        // OBTENER DATOS DEL FORMULARIO
        // =====================================================

        private Estudiante ObtenerDatosFormulario()
        {
            int anio;

            if (!int.TryParse(textAnio.Text.Trim(), out anio))
            {
                throw new Exception(
                    "El año debe ser un número.");
            }

            return new Estudiante
            {
                Codigo = textCodigo.Text.Trim(),

                Nombre = textNombre.Text.Trim(),

                Apellido = textApellido.Text.Trim(),

                DUI = textDui.Text.Trim(),

                FechaNacimiento =
                    dateFechaNacimiento.Value.Date,

                Telefono =
                    textTelefono.Text.Trim(),

                Correo =
                    textCorreo.Text.Trim(),

                Grado =
                    comboGrado.Text.Trim(),

                Seccion =
                    comboSeccion.Text.Trim(),

                Anio = anio
            };
        }

        // =====================================================
        // MOSTRAR ESTUDIANTE
        // =====================================================

        private void MostrarDatos(Estudiante estudiante)
        {
            textCodigo.Text = estudiante.Codigo;
            textNombre.Text = estudiante.Nombre;
            textApellido.Text = estudiante.Apellido;
            textDui.Text = estudiante.DUI;

            dateFechaNacimiento.Value =
                estudiante.FechaNacimiento;

            textTelefono.Text = estudiante.Telefono;
            textCorreo.Text = estudiante.Correo;

            comboGrado.Text = estudiante.Grado;
            comboSeccion.Text = estudiante.Seccion;

            textAnio.Text =
                estudiante.Anio.ToString();
        }

        // =====================================================
        // LIMPIAR FORMULARIO
        // =====================================================

        private void LimpiarFormulario()
        {
            textCodigo.Clear();
            textNombre.Clear();
            textApellido.Clear();
            textDui.Clear();
            textTelefono.Clear();
            textCorreo.Clear();
            textAnio.Clear();
            textBuscar.Clear();

            comboGrado.SelectedIndex = -1;
            comboSeccion.SelectedIndex = -1;

            dateFechaNacimiento.Value =
                DateTime.Today;
        }
    }
}