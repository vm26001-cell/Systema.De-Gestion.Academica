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

                    comando.Parameters.Add(
                        "@id_estudiante",
                        System.Data.SqlDbType.Int
                    ).Value = asistencia.IdEstudiante;

                    comando.Parameters.Add(
                        "@nombre_estudiante",
                        System.Data.SqlDbType.VarChar,
                        100
                    ).Value =
                        string.IsNullOrWhiteSpace(
                            asistencia.NombreEstudiante)
                        ? (object)System.DBNull.Value
                        : asistencia.NombreEstudiante;

                    // =========================================
                    // GRADO
                    // =========================================

                    comando.Parameters.Add(
                        "@id_grado",
                        System.Data.SqlDbType.Int
                    ).Value = asistencia.IdGrado;

                    comando.Parameters.Add(
                        "@nombre_grado",
                        System.Data.SqlDbType.VarChar,
                        50
                    ).Value =
                        string.IsNullOrWhiteSpace(
                            asistencia.NombreGrado)
                        ? (object)System.DBNull.Value
                        : asistencia.NombreGrado;

                    // =========================================
                    // MATERIA
                    // =========================================

                    comando.Parameters.Add(
                        "@id_materia",
                        System.Data.SqlDbType.Int
                    ).Value = asistencia.IdMateria;

                    comando.Parameters.Add(
                        "@nombre_materia",
                        System.Data.SqlDbType.VarChar,
                        100
                    ).Value =
                        string.IsNullOrWhiteSpace(
                            asistencia.NombreMateria)
                        ? (object)System.DBNull.Value
                        : asistencia.NombreMateria;

                    // =========================================
                    // DOCENTE
                    // =========================================

                    comando.Parameters.Add(
                        "@id_docente",
                        System.Data.SqlDbType.Int
                    ).Value = asistencia.IdDocente;

                    comando.Parameters.Add(
                        "@nombre_docente",
                        System.Data.SqlDbType.VarChar,
                        100
                    ).Value =
                        string.IsNullOrWhiteSpace(
                            asistencia.NombreDocente)
                        ? (object)System.DBNull.Value
                        : asistencia.NombreDocente;

                    // =========================================
                    // FECHA
                    // =========================================

                    comando.Parameters.Add(
                        "@fecha",
                        System.Data.SqlDbType.Date
                    ).Value = asistencia.Fecha.Date;

                    // =========================================
                    // ESTADO
                    // =========================================

                    comando.Parameters.Add(
                        "@estado",
                        System.Data.SqlDbType.VarChar,
                        20
                    ).Value = asistencia.Estado;

                    // =========================================
                    // ABRIR CONEXIÓN
                    // =========================================

                    conexion.Open();

                    // =========================================
                    // EJECUTAR INSERT
                    // =========================================

                    int filasAfectadas =
                        comando.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
            }
        }
    }
}