using Microsoft.Data.SqlClient;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.DAL
{
    public class AsistenciaDAL
    {
        private readonly DBComun db;

        public AsistenciaDAL()
        {
            db = new DBComun();
        }

        // =====================================================
        // INSERTAR ASISTENCIA
        // =====================================================

        public bool Insertar(Asistencia asistencia)
        {
            using (SqlConnection conexion = db.ObtenerConexion())
            {
                string consulta = @"
                    INSERT INTO Asistencia
                    (
                        id_estudiante,
                        nombre_estudiante,
                        id_grado,
                        nombre_grado,
                        id_materia,
                        nombre_materia,
                        id_docente,
                        nombre_docente,
                        fecha,
                        estado
                    )
                    VALUES
                    (
                        @id_estudiante,
                        @nombre_estudiante,
                        @id_grado,
                        @nombre_grado,
                        @id_materia,
                        @nombre_materia,
                        @id_docente,
                        @nombre_docente,
                        @fecha,
                        @estado
                    )";

                using (SqlCommand comando =
                    new SqlCommand(consulta, conexion))
                {
                    // =========================================
                    // ESTUDIANTE
                    // =========================================

                    comando.Parameters.AddWithValue(
                        "@id_estudiante",
                        asistencia.IdEstudiante);

                    comando.Parameters.AddWithValue(
                        "@nombre_estudiante",
                        asistencia.NombreEstudiante);

                    // =========================================
                    // GRADO
                    // =========================================

                    comando.Parameters.AddWithValue(
                        "@id_grado",
                        asistencia.IdGrado);

                    comando.Parameters.AddWithValue(
                        "@nombre_grado",
                        asistencia.NombreGrado);

                    // =========================================
                    // MATERIA
                    // =========================================

                    comando.Parameters.AddWithValue(
                        "@id_materia",
                        asistencia.IdMateria);

                    comando.Parameters.AddWithValue(
                        "@nombre_materia",
                        asistencia.NombreMateria);

                    // =========================================
                    // DOCENTE
                    // =========================================

                    comando.Parameters.AddWithValue(
                        "@id_docente",
                        asistencia.IdDocente);

                    comando.Parameters.AddWithValue(
                        "@nombre_docente",
                        asistencia.NombreDocente);

                    // =========================================
                    // FECHA
                    // =========================================

                    comando.Parameters.AddWithValue(
                        "@fecha",
                        asistencia.Fecha);

                    // =========================================
                    // ESTADO
                    // =========================================

                    comando.Parameters.AddWithValue(
                        "@estado",
                        asistencia.Estado);

                    // =========================================
                    // EJECUTAR
                    // =========================================

                    conexion.Open();

                    int filasAfectadas =
                        comando.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
            }
        }
    }
}