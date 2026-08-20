using Microsoft.Data.SqlClient;
using System;
using System.Data;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.DAL
{
    public class CalificacionDAL
    {
        private readonly DBComun db;

        public CalificacionDAL()
        {
            db = new DBComun();
        }

        // =====================================================
        // INSERTAR CALIFICACIÓN
        // =====================================================

        public bool Insertar(Calificacion calificacion)
        {
            using (SqlConnection conexion = db.ObtenerConexion())
            {
                string consulta = @"
                    INSERT INTO Calificacion
                    (
                        id_estudiante,
                        nombre_estudiante,
                        id_grado,
                        nombre_grado,
                        id_materia,
                        nombre_materia,
                        id_docente,
                        nombre_docente,
                        periodo,
                        nota
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
                        @periodo,
                        @nota
                    )";

                using (SqlCommand comando =
                    new SqlCommand(consulta, conexion))
                {
                    // =========================================
                    // ESTUDIANTE
                    // =========================================

                    comando.Parameters.Add(
                        "@id_estudiante",
                        SqlDbType.Int
                    ).Value =
                        calificacion.IdEstudiante;

                    comando.Parameters.Add(
                        "@nombre_estudiante",
                        SqlDbType.VarChar,
                        100
                    ).Value =
                        calificacion.NombreEstudiante;

                    // =========================================
                    // GRADO
                    // =========================================

                    comando.Parameters.Add(
                        "@id_grado",
                        SqlDbType.Int
                    ).Value =
                        calificacion.IdGrado;

                    comando.Parameters.Add(
                        "@nombre_grado",
                        SqlDbType.VarChar,
                        50
                    ).Value =
                        calificacion.NombreGrado;

                    // =========================================
                    // MATERIA
                    // =========================================

                    comando.Parameters.Add(
                        "@id_materia",
                        SqlDbType.Int
                    ).Value =
                        calificacion.IdMateria;

                    comando.Parameters.Add(
                        "@nombre_materia",
                        SqlDbType.VarChar,
                        100
                    ).Value =
                        calificacion.NombreMateria;

                    // =========================================
                    // DOCENTE
                    // =========================================

                    comando.Parameters.Add(
                        "@id_docente",
                        SqlDbType.Int
                    ).Value =
                        calificacion.IdDocente;

                    comando.Parameters.Add(
                        "@nombre_docente",
                        SqlDbType.VarChar,
                        100
                    ).Value =
                        calificacion.NombreDocente;

                    // =========================================
                    // PERIODO
                    // =========================================

                    comando.Parameters.Add(
                        "@periodo",
                        SqlDbType.VarChar,
                        50
                    ).Value =
                        calificacion.Periodo;

                    // =========================================
                    // NOTA
                    // =========================================

                    comando.Parameters.Add(
                        "@nota",
                        SqlDbType.Decimal
                    ).Value =
                        calificacion.Nota;

                    // =========================================
                    // ABRIR CONEXIÓN
                    // =========================================

                    conexion.Open();

                    // =========================================
                    // EJECUTAR
                    // =========================================

                    int filasAfectadas =
                        comando.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
            }
        }
    }
}