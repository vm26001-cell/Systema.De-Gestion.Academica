using System;
using System.Windows.Forms;
using Systema.De_Gestion.Academica.BL;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.UI
{
    public partial class FrmAsistencia : Form
    {
        private readonly AsistenciaBL asistenciaBL =
            new AsistenciaBL();

        public FrmAsistencia()
        {
            InitializeComponent();
        }

        // ==========================================
        // BOTÓN GUARDAR
        // ==========================================

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar grado
                if (cmbGrado.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un grado.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                // Validar materia
                if (cmbMateria.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione una materia.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                // Validar docente
                if (cmbDocente.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un docente.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                // Validar que existan estudiantes
                if (dgvAsistencia.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No hay estudiantes para registrar.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                int gradoId = cmbGrado.SelectedIndex + 1;
                int materiaId = cmbMateria.SelectedIndex + 1;
                int docenteId = cmbDocente.SelectedIndex + 1;

                int registrosGuardados = 0;

                // ==========================================
                // RECORRER ESTUDIANTES
                // ==========================================

                foreach (DataGridViewRow fila in dgvAsistencia.Rows)
                {
                    if (fila.IsNewRow)
                        continue;

                    // Código del estudiante
                    string codigo =
                        fila.Cells["Codigo"].Value?.ToString();

                    // Estado
                    string estado =
                        fila.Cells["Estado"].Value?.ToString();

                    if (string.IsNullOrWhiteSpace(codigo))
                    {
                        continue;
                    }

                    if (string.IsNullOrWhiteSpace(estado))
                    {
                        MessageBox.Show(
                            "El estudiante " + codigo +
                            " no tiene un estado seleccionado.",
                            "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }

                    // ==========================================
                    // CONVERTIR E001, E002, E003...
                    // A ID NUMÉRICO
                    // ==========================================

                    int idEstudiante;

                    string numero =
                        codigo.Replace("E", "");

                    if (!int.TryParse(numero, out idEstudiante))
                    {
                        MessageBox.Show(
                            "El código del estudiante " +
                            codigo +
                            " no tiene un formato válido.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        return;
                    }

                    // ==========================================
                    // CREAR ASISTENCIA
                    // ==========================================

                    Asistencia asistencia = new Asistencia();

                    asistencia.IdEstudiante = idEstudiante;

                    asistencia.NombreEstudiante =
                        fila.Cells["Estudiante"].Value?.ToString();

                    asistencia.IdGrado =
                        cmbGrado.SelectedIndex + 1;

                    asistencia.NombreGrado =
                        cmbGrado.Text;

                    asistencia.IdMateria =
                        cmbMateria.SelectedIndex + 1;

                    asistencia.NombreMateria =
                        cmbMateria.Text;

                    asistencia.IdDocente =
                        cmbDocente.SelectedIndex + 1;

                    asistencia.NombreDocente =
                        cmbDocente.Text;

                    asistencia.Fecha =
                        dtpFecha.Value.Date;

                    asistencia.Estado =
                        fila.Cells["Estado"].Value?.ToString();

                    // ==========================================
                    // GUARDAR
                    // ==========================================

                    bool resultado =
                        asistenciaBL.RegistrarAsistencia(
                            asistencia
                        );

                    if (resultado)
                    {
                        registrosGuardados++;
                    }
                }

                // ==========================================
                // RESULTADO
                // ==========================================

                MessageBox.Show(
                    "Se guardaron " +
                    registrosGuardados +
                    " registros de asistencia correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information

                );
                dgvAsistencia.Rows.Clear();

                dgvAsistencia.Rows.Add("", "", "Presente");
                dgvAsistencia.Rows.Add("", "", "Presente");
                dgvAsistencia.Rows.Add("", "", "Presente");
                dgvAsistencia.Rows.Add("", "", "Presente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar la asistencia:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ==========================================
        // BOTÓN CANCELAR
        // ==========================================

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}