using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Systema.De_Gestion.Academica.EN;
using Systema.De_Gestion.Academica.LN;

namespace Systema.De_Gestion.Academica.UI
{
    public partial class FrmHorario : Form
    {
        private readonly HorarioBL horarioBL;

        private int idHorarioSeleccionado = 0;

        public FrmHorario()
        {
            InitializeComponent();

            horarioBL = new HorarioBL();

            CargarDatosIniciales();

            cmbGrado.SelectedIndexChanged += cmbGrado_SelectedIndexChanged;
            cmbDia.SelectedIndexChanged += cmbDia_SelectedIndexChanged;

            dgvHorario.CellClick += dgvHorario_CellClick;
        }

        // =====================================================
        // CARGAR DATOS INICIALES
        // =====================================================

        private void CargarDatosIniciales()
        {
            CargarGrados();
            CargarDias();
            CargarMaterias();
            CargarDocentes();
            CargarAulas();

            if (cmbGrado.Items.Count > 0)
                cmbGrado.SelectedIndex = 0;

            if (cmbDia.Items.Count > 0)
                cmbDia.SelectedIndex = 0;

            CargarHorarios();
        }

        // =====================================================
        // GRADOS
        // =====================================================

        private void CargarGrados()
        {
            cmbGrado.Items.Clear();

            cmbGrado.Items.Add("1° A");
            cmbGrado.Items.Add("1° B");
            cmbGrado.Items.Add("2° A");
            cmbGrado.Items.Add("2° B");
            cmbGrado.Items.Add("3° A");
            cmbGrado.Items.Add("3° B");
        }

        // =====================================================
        // DÍAS
        // =====================================================

        private void CargarDias()
        {
            cmbDia.Items.Clear();

            cmbDia.Items.Add("Lunes");
            cmbDia.Items.Add("Martes");
            cmbDia.Items.Add("Miércoles");
            cmbDia.Items.Add("Jueves");
            cmbDia.Items.Add("Viernes");
        }

        // =====================================================
        // MATERIAS
        // =====================================================

        private void CargarMaterias()
        {
            cmbMateria.Items.Clear();

            cmbMateria.Items.Add("Matemática");
            cmbMateria.Items.Add("Lenguaje");
            cmbMateria.Items.Add("Ciencias");
            cmbMateria.Items.Add("Inglés");
            cmbMateria.Items.Add("Informática");

            if (cmbMateria.Items.Count > 0)
                cmbMateria.SelectedIndex = 0;
        }

        // =====================================================
        // DOCENTES
        // =====================================================

        private void CargarDocentes()
        {
            cmbDocente.Items.Clear();

            cmbDocente.Items.Add("Carlos Gómez");
            cmbDocente.Items.Add("Ana Martínez");
            cmbDocente.Items.Add("Pedro Romero");

            if (cmbDocente.Items.Count > 0)
                cmbDocente.SelectedIndex = 0;
        }

        // =====================================================
        // AULAS
        // =====================================================

        private void CargarAulas()
        {
            cmbAula.Items.Clear();

            cmbAula.Items.Add("Aula 101");
            cmbAula.Items.Add("Aula 102");
            cmbAula.Items.Add("Aula 103");
            cmbAula.Items.Add("Lab. 1");
            cmbAula.Items.Add("Lab. 2");

            if (cmbAula.Items.Count > 0)
                cmbAula.SelectedIndex = 0;
        }

        // =====================================================
        // CARGAR HORARIOS
        // =====================================================

        private void CargarHorarios()
        {
            try
            {
                string grado = cmbGrado.Text;
                string dia = cmbDia.Text;

                if (string.IsNullOrWhiteSpace(grado) ||
                    string.IsNullOrWhiteSpace(dia))
                {
                    return;
                }

                List<Horario> lista =
                    horarioBL.BuscarPorGradoDia(
                        grado,
                        dia);

                dgvHorario.Rows.Clear();

                foreach (Horario horario in lista)
                {
                    dgvHorario.Rows.Add(
                        horario.HoraInicio.ToString(@"hh\:mm")
                        + " - "
                        + horario.HoraFin.ToString(@"hh\:mm"),

                        horario.Materia,

                        horario.Docente,

                        horario.Aula
                    );

                    int fila =
                        dgvHorario.Rows.Count - 1;

                    dgvHorario.Rows[fila].Tag =
                        horario.IdHorario;
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
        // CAMBIAR GRADO
        // =====================================================

        private void cmbGrado_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            CargarHorarios();
        }

        // =====================================================
        // CAMBIAR DÍA
        // =====================================================

        private void cmbDia_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            CargarHorarios();
        }

        // =====================================================
        // NUEVO
        // =====================================================

        private void btnNuevo_Click(
            object sender,
            EventArgs e)
        {
            LimpiarFormulario();

            idHorarioSeleccionado = 0;

            cmbMateria.Focus();
        }

        // =====================================================
        // GUARDAR
        // =====================================================

        private void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                Horario horario =
                    ObtenerDatosFormulario();

                bool resultado;

                if (idHorarioSeleccionado == 0)
                {
                    resultado =
                        horarioBL.Guardar(horario);

                    if (resultado)
                    {
                        MessageBox.Show(
                            "Horario guardado correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    horario.IdHorario =
                        idHorarioSeleccionado;

                    resultado =
                        horarioBL.Modificar(horario);

                    if (resultado)
                    {
                        MessageBox.Show(
                            "Horario modificado correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }

                if (resultado)
                {
                    LimpiarFormulario();
                    CargarHorarios();
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
        // CANCELAR
        // =====================================================

        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            LimpiarFormulario();

            idHorarioSeleccionado = 0;
        }

        // =====================================================
        // SELECCIONAR HORARIO
        // =====================================================

        private void dgvHorario_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvHorario.Rows[e.RowIndex].Tag == null)
                return;

            int id =
                Convert.ToInt32(
                    dgvHorario.Rows[e.RowIndex].Tag);

            idHorarioSeleccionado = id;

            CargarHorarioSeleccionado(id);
        }

        // =====================================================
        // CARGAR HORARIO SELECCIONADO
        // =====================================================

        private void CargarHorarioSeleccionado(
            int id)
        {
            try
            {
                List<Horario> lista =
                    horarioBL.ObtenerTodos();

                Horario horario =
                    lista.Find(
                        x => x.IdHorario == id);

                if (horario == null)
                    return;

                cmbGrado.Text =
                    horario.Grado;

                cmbDia.Text =
                    horario.Dia;

                cmbMateria.Text =
                    horario.Materia;

                cmbDocente.Text =
                    horario.Docente;

                cmbAula.Text =
                    horario.Aula;

                txtHoraInicio.Text =
                    horario.HoraInicio
                        .ToString(@"hh\:mm");

                txtHoraFin.Text =
                    horario.HoraFin
                        .ToString(@"hh\:mm");
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
        // OBTENER DATOS DEL FORMULARIO
        // =====================================================

        private Horario ObtenerDatosFormulario()
        {
            TimeSpan horaInicio;
            TimeSpan horaFin;

            if (!TimeSpan.TryParse(
                    txtHoraInicio.Text.Trim(),
                    out horaInicio))
            {
                throw new Exception(
                    "La hora de inicio no es válida. Use HH:mm.");
            }

            if (!TimeSpan.TryParse(
                    txtHoraFin.Text.Trim(),
                    out horaFin))
            {
                throw new Exception(
                    "La hora de fin no es válida. Use HH:mm.");
            }

            return new Horario
            {
                IdHorario = idHorarioSeleccionado,

                Grado =
                    cmbGrado.Text.Trim(),

                Dia =
                    cmbDia.Text.Trim(),

                Materia =
                    cmbMateria.Text.Trim(),

                Docente =
                    cmbDocente.Text.Trim(),

                Aula =
                    cmbAula.Text.Trim(),

                HoraInicio =
                    horaInicio,

                HoraFin =
                    horaFin
            };
        }

        // =====================================================
        // LIMPIAR
        // =====================================================

        private void LimpiarFormulario()
        {
            idHorarioSeleccionado = 0;

            if (cmbMateria.Items.Count > 0)
                cmbMateria.SelectedIndex = 0;

            if (cmbDocente.Items.Count > 0)
                cmbDocente.SelectedIndex = 0;

            if (cmbAula.Items.Count > 0)
                cmbAula.SelectedIndex = 0;

            txtHoraInicio.Text = "08:00";
            txtHoraFin.Text = "09:00";

            dgvHorario.ClearSelection();
        }
    }
}