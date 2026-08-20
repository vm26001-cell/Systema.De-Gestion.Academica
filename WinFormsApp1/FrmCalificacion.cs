using System;
using System.Globalization;
using System.Windows.Forms;
using Systema.De_Gestion.Academica.BL;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.UI
{
    public partial class FrmCalificacion : Form
    {
        private readonly CalificacionBL calificacionBL;

        public FrmCalificacion()
        {
            InitializeComponent();

            calificacionBL =
                new CalificacionBL();
        }

        // =====================================================
        // BOTÓN GUARDAR
        // =====================================================

        private void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                // =============================================
                // VALIDAR GRADO
                // =============================================

                if (cmbGrado.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un grado.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // =============================================
                // VALIDAR PERIODO
                // =============================================

                if (cmbPeriodo.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un periodo.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // =============================================
                // VALIDAR MATERIA
                // =============================================

                if (cmbMateria.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione una materia.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // =============================================
                // VALIDAR DOCENTE
                // =============================================

                if (cmbDocente.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un docente.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // =============================================
                // VALIDAR TABLA
                // =============================================

                if (dgvCalificaciones.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No hay estudiantes para registrar.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // =============================================
                // OBTENER IDS
                // =============================================

                int idGrado =
                    cmbGrado.SelectedIndex + 1;

                int idMateria =
                    cmbMateria.SelectedIndex + 1;

                int idDocente =
                    cmbDocente.SelectedIndex + 1;

                string periodo =
                    cmbPeriodo.Text;

                int registrosGuardados = 0;

                // =============================================
                // RECORRER ESTUDIANTES
                // =============================================

                foreach (
                    DataGridViewRow fila
                    in dgvCalificaciones.Rows)
                {
                    if (fila.IsNewRow)
                    {
                        continue;
                    }

                    // =========================================
                    // CÓDIGO
                    // =========================================

                    string codigo =
                        fila.Cells["Codigo"]
                        .Value?
                        .ToString();

                    if (string.IsNullOrWhiteSpace(codigo))
                    {
                        continue;
                    }

                    // =========================================
                    // NOMBRE
                    // =========================================

                    string nombreEstudiante =
                        fila.Cells["Estudiante"]
                        .Value?
                        .ToString();

                    if (string.IsNullOrWhiteSpace(
                        nombreEstudiante))
                    {
                        MessageBox.Show(
                            "El estudiante " +
                            codigo +
                            " no tiene nombre.",
                            "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    // =========================================
                    // NOTA
                    // =========================================

                    string textoNota =
                        fila.Cells["Nota"]
                        .Value?
                        .ToString();

                    if (string.IsNullOrWhiteSpace(
                        textoNota))
                    {
                        MessageBox.Show(
                            "Ingrese una nota para " +
                            nombreEstudiante +
                            ".",
                            "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    // =========================================
                    // CONVERTIR NOTA
                    // =========================================

                    decimal nota;

                    bool notaValida =
                        decimal.TryParse(
                            textoNota,
                            NumberStyles.Number,
                            CultureInfo.InvariantCulture,
                            out nota);

                    if (!notaValida)
                    {
                        // Intentar con formato local
                        notaValida =
                            decimal.TryParse(
                                textoNota,
                                out nota);
                    }

                    if (!notaValida)
                    {
                        MessageBox.Show(
                            "La nota de " +
                            nombreEstudiante +
                            " no es válida.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    // =========================================
                    // VALIDAR 0 - 10
                    // =========================================

                    if (nota < 0 || nota > 10)
                    {
                        MessageBox.Show(
                            "La nota de " +
                            nombreEstudiante +
                            " debe estar entre 0 y 10.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    // =========================================
                    // CONVERTIR E001 -> 1
                    // =========================================

                    string numero =
                        codigo.Replace("E", "");

                    int idEstudiante;

                    if (!int.TryParse(
                        numero,
                        out idEstudiante))
                    {
                        MessageBox.Show(
                            "El código " +
                            codigo +
                            " no tiene un formato válido.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    // =========================================
                    // CREAR CALIFICACIÓN
                    // =========================================

                    Calificacion calificacion =
                        new Calificacion();

                    calificacion.IdEstudiante =
                        idEstudiante;

                    calificacion.NombreEstudiante =
                        nombreEstudiante;

                    calificacion.IdGrado =
                        idGrado;

                    calificacion.NombreGrado =
                        cmbGrado.Text;

                    calificacion.IdMateria =
                        idMateria;

                    calificacion.NombreMateria =
                        cmbMateria.Text;

                    calificacion.IdDocente =
                        idDocente;

                    calificacion.NombreDocente =
                        cmbDocente.Text;

                    calificacion.Periodo =
                        periodo;

                    calificacion.Nota =
                        nota;

                    // =========================================
                    // GUARDAR
                    // =========================================

                    bool resultado =
                        calificacionBL
                        .RegistrarCalificacion(
                            calificacion);

                    if (resultado)
                    {
                        registrosGuardados++;
                    }
                }

                // =============================================
                // RESULTADO
                // =============================================

                if (registrosGuardados > 0)
                {
                    MessageBox.Show(
                        "Se guardaron " +
                        registrosGuardados +
                        " calificaciones correctamente.",
                        "Registro exitoso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    dgvCalificaciones.Rows.Clear();

                    dgvCalificaciones.Rows.Add("", "", "");
                    dgvCalificaciones.Rows.Add("", "", "");
                    dgvCalificaciones.Rows.Add("", "", "");
                    dgvCalificaciones.Rows.Add("", "", "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar la calificación:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // BOTÓN CANCELAR
        // =====================================================

        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}