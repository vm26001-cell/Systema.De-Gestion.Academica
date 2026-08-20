using System;
using System.Windows.Forms;
using Systema.De_Gestion.Academica.BL;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.UI
{
    public partial class FrmDocente : Form
    {
        private readonly DocenteBL docenteBL;

        private int idDocenteSeleccionado = 0;

        public FrmDocente()
        {
            InitializeComponent();

            docenteBL = new DocenteBL();

            CargarMaterias();

            buttonGuardar.Click += buttonGuardar_Click;
            buttonLimpiar.Click += buttonLimpiar_Click;
            buttonBuscar.Click += buttonBuscar_Click;
            buttonModificar.Click += buttonModificar_Click;
            buttonNuevo.Click += buttonNuevo_Click;
        }


        // ==========================================
        // MATERIAS
        // ==========================================

        private void CargarMaterias()
        {
            comboMateria.Items.Clear();

            comboMateria.Items.Add("Matemática");
            comboMateria.Items.Add("Lenguaje");
            comboMateria.Items.Add("Ciencias");
            comboMateria.Items.Add("Inglés");
            comboMateria.Items.Add("Informática");

            if (comboMateria.Items.Count > 0)
                comboMateria.SelectedIndex = 0;
        }


        // ==========================================
        // GUARDAR
        // ==========================================

        private void buttonGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textCodigo.Text))
                {
                    MessageBox.Show(
                        "Ingrese el código del docente.");
                    textCodigo.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(textNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del docente.");
                    textNombre.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(textApellido.Text))
                {
                    MessageBox.Show(
                        "Ingrese el apellido del docente.");
                    textApellido.Focus();
                    return;
                }

                Docente docente = new Docente();

                docente.Codigo =
                    textCodigo.Text.Trim();

                docente.Nombre =
                    textNombre.Text.Trim();

                docente.Apellido =
                    textApellido.Text.Trim();

                docente.Dui =
                    textDui.Text.Trim();

                docente.Telefono =
                    textTelefono.Text.Trim();

                docente.Correo =
                    textCorreo.Text.Trim();

                docente.Especialidad =
                    textEspecialidad.Text.Trim();

                docente.Materia =
                    comboMateria.Text;

                bool resultado =
                    docenteBL.Insertar(docente);

                if (resultado)
                {
                    MessageBox.Show(
                        "Docente guardado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo guardar el docente.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el docente:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ==========================================
        // BUSCAR
        // ==========================================

        private void buttonBuscar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                string texto =
                    textBuscar.Text.Trim();

                var lista =
                    docenteBL.Buscar(texto);

                if (lista.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontró ningún docente.",
                        "Buscar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                // Si encuentra uno, cargarlo directamente
                Docente docente = lista[0];

                idDocenteSeleccionado =
                    docente.IdDocente;

                textCodigo.Text =
                    docente.Codigo;

                textNombre.Text =
                    docente.Nombre;

                textApellido.Text =
                    docente.Apellido;

                textDui.Text =
                    docente.Dui;

                textTelefono.Text =
                    docente.Telefono;

                textCorreo.Text =
                    docente.Correo;

                textEspecialidad.Text =
                    docente.Especialidad;

                comboMateria.Text =
                    docente.Materia;

                MessageBox.Show(
                    "Docente encontrado.",
                    "Buscar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ==========================================
        // MODIFICAR
        // ==========================================

        private void buttonModificar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (idDocenteSeleccionado == 0)
                {
                    MessageBox.Show(
                        "Primero busque el docente que desea modificar.",
                        "Modificar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Docente docente = new Docente();

                docente.IdDocente =
                    idDocenteSeleccionado;

                docente.Codigo =
                    textCodigo.Text.Trim();

                docente.Nombre =
                    textNombre.Text.Trim();

                docente.Apellido =
                    textApellido.Text.Trim();

                docente.Dui =
                    textDui.Text.Trim();

                docente.Telefono =
                    textTelefono.Text.Trim();

                docente.Correo =
                    textCorreo.Text.Trim();

                docente.Especialidad =
                    textEspecialidad.Text.Trim();

                docente.Materia =
                    comboMateria.Text;

                bool resultado =
                    docenteBL.Modificar(docente);

                if (resultado)
                {
                    MessageBox.Show(
                        "Docente modificado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo modificar el docente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al modificar:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ==========================================
        // NUEVO
        // ==========================================

        private void buttonNuevo_Click(
            object sender,
            EventArgs e)
        {
            LimpiarFormulario();

            textCodigo.Focus();
        }


        // ==========================================
        // LIMPIAR
        // ==========================================

        private void buttonLimpiar_Click(
            object sender,
            EventArgs e)
        {
            LimpiarFormulario();
        }


        private void LimpiarFormulario()
        {
            textCodigo.Clear();
            textNombre.Clear();
            textApellido.Clear();
            textDui.Clear();
            textTelefono.Clear();
            textCorreo.Clear();
            textEspecialidad.Clear();
            textBuscar.Clear();

            if (comboMateria.Items.Count > 0)
                comboMateria.SelectedIndex = 0;

            idDocenteSeleccionado = 0;
        }
    }
}