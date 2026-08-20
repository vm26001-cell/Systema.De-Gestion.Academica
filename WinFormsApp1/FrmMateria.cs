using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Systema.De_Gestion.Academica.EN;
using Systema.De_Gestion.Academica.LN;

namespace Systema.De_Gestion.Academica.UI
{
    public partial class FrmMateria : Form
    {
        private readonly MateriaBL materiaBL;

        private string codigoSeleccionado = "";

        public FrmMateria()
        {
            InitializeComponent();

            materiaBL = new MateriaBL();

            ConfigurarEventos();
            CargarGrados();
            CargarDocentes();
            CargarMaterias();
        }

        // =====================================================
        // EVENTOS
        // =====================================================

        private void ConfigurarEventos()
        {
            buttonNuevo.Click += buttonNuevo_Click;
            buttonGuardar.Click += buttonGuardar_Click;
            buttonModificar.Click += buttonModificar_Click;
            buttonLimpiar.Click += buttonLimpiar_Click;
            buttonBuscar.Click += buttonBuscar_Click;

            textBuscar.KeyDown += textBuscar_KeyDown;
        }

        // =====================================================
        // GRADOS
        // =====================================================

        private void CargarGrados()
        {
            comboGrado.Items.Clear();

            comboGrado.Items.Add("1° A");
            comboGrado.Items.Add("1° B");
            comboGrado.Items.Add("2° A");
            comboGrado.Items.Add("2° B");
            comboGrado.Items.Add("3° A");
            comboGrado.Items.Add("3° B");

            if (comboGrado.Items.Count > 0)
            {
                comboGrado.SelectedIndex = 0;
            }
        }

        // =====================================================
        // DOCENTES
        // =====================================================

        private void CargarDocentes()
        {
            comboDocente.Items.Clear();

            comboDocente.Items.Add("Carlos Gómez");
            comboDocente.Items.Add("Ana Martínez");
            comboDocente.Items.Add("Pedro Romero");

            if (comboDocente.Items.Count > 0)
            {
                comboDocente.SelectedIndex = 0;
            }
        }

        // =====================================================
        // CARGAR MATERIAS
        // =====================================================

        private void CargarMaterias()
        {
            try
            {
                List<Materia> lista =
                    materiaBL.ObtenerTodas();

                // Actualmente tu formulario no tiene
                // DataGridView para mostrar todas.
                // Se utiliza principalmente el buscador.
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
        // NUEVO
        // =====================================================

        private void buttonNuevo_Click(
            object sender,
            EventArgs e)
        {
            LimpiarFormulario();

            textCodigo.ReadOnly = false;
            codigoSeleccionado = "";

            textCodigo.Focus();
        }

        // =====================================================
        // GUARDAR
        // =====================================================

        private void buttonGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                Materia materia =
                    ObtenerDatosFormulario();

                bool resultado =
                    materiaBL.Guardar(materia);

                if (resultado)
                {
                    MessageBox.Show(
                        "Materia guardada correctamente.",
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

        private void buttonModificar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    codigoSeleccionado))
                {
                    MessageBox.Show(
                        "Primero busque una materia para modificar.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Materia materia =
                    ObtenerDatosFormulario();

                materia.Codigo =
                    codigoSeleccionado;

                bool resultado =
                    materiaBL.Modificar(materia);

                if (resultado)
                {
                    MessageBox.Show(
                        "Materia modificada correctamente.",
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

        private void buttonBuscar_Click(
            object sender,
            EventArgs e)
        {
            BuscarMateria();
        }

        // =====================================================
        // BUSCAR CON ENTER
        // =====================================================

        private void textBuscar_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarMateria();

                e.SuppressKeyPress = true;
            }
        }

        // =====================================================
        // MÉTODO BUSCAR
        // =====================================================

        private void BuscarMateria()
        {
            try
            {
                string texto =
                    textBuscar.Text.Trim();

                if (string.IsNullOrWhiteSpace(texto))
                {
                    MessageBox.Show(
                        "Escriba un código o nombre para buscar.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                List<Materia> resultados =
                    materiaBL.Buscar(texto);

                if (resultados.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontró ninguna materia.",
                        "Buscar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                if (resultados.Count > 1)
                {
                    MessageBox.Show(
                        "Se encontraron varias materias. " +
                        "Escriba un código más específico.",
                        "Buscar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                CargarMateria(
                    resultados[0]);
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
        // CARGAR MATERIA EN EL FORMULARIO
        // =====================================================

        private void CargarMateria(
            Materia materia)
        {
            codigoSeleccionado =
                materia.Codigo;

            textCodigo.Text =
                materia.Codigo;

            textNombre.Text =
                materia.Nombre;

            textDescripcion.Text =
                materia.Descripcion;

            comboGrado.Text =
                materia.Grado;

            comboDocente.Text =
                materia.Docente;

            textCodigo.ReadOnly = true;
        }

        // =====================================================
        // OBTENER DATOS
        // =====================================================

        private Materia ObtenerDatosFormulario()
        {
            return new Materia
            {
                Codigo =
                    textCodigo.Text.Trim(),

                Nombre =
                    textNombre.Text.Trim(),

                Descripcion =
                    textDescripcion.Text.Trim(),

                Grado =
                    comboGrado.Text.Trim(),

                Docente =
                    comboDocente.Text.Trim()
            };
        }

        // =====================================================
        // LIMPIAR
        // =====================================================

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
            textDescripcion.Clear();
            textBuscar.Clear();

            if (comboGrado.Items.Count > 0)
            {
                comboGrado.SelectedIndex = 0;
            }

            if (comboDocente.Items.Count > 0)
            {
                comboDocente.SelectedIndex = 0;
            }

            codigoSeleccionado = "";

            textCodigo.ReadOnly = false;

            textCodigo.Focus();
        }
    }
}