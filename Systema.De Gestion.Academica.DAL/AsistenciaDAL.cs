using Microsoft.Data.SqlClient;
using System.Data;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.DAL
{
    public class AsistenciaDAL
    {
        private readonly DBComun db = new DBComun();

        public bool Insertar(Asistencia asistencia)
        {
            return GuardarLote(new[] { asistencia }) == 1;
        }

        public int GuardarLote(IReadOnlyCollection<Asistencia> asistencias)
        {
            if (asistencias.Count == 0)
                return 0;

            const string sql = @"
                UPDATE Asistencia
                SET nombre_estudiante = @nombreEstudiante,
                    nombre_grado = @nombreGrado,
                    nombre_materia = @nombreMateria,
                    nombre_docente = @nombreDocente,
                    estado = @estado
                WHERE id_estudiante = @idEstudiante
                  AND id_materia = @idMateria
                  AND fecha = @fecha;

                IF @@ROWCOUNT = 0
                BEGIN
                    INSERT INTO Asistencia
                    (id_estudiante, nombre_estudiante, id_grado, nombre_grado,
                     id_materia, nombre_materia, id_docente, nombre_docente,
                     fecha, estado)
                    VALUES
                    (@idEstudiante, @nombreEstudiante, @idGrado, @nombreGrado,
                     @idMateria, @nombreMateria, @idDocente, @nombreDocente,
                     @fecha, @estado);
                END;";

            using SqlConnection conexion = db.ObtenerConexion();
            conexion.Open();
            using SqlTransaction transaccion = conexion.BeginTransaction();

            try
            {
                using SqlCommand comando = new SqlCommand(sql, conexion, transaccion);
                comando.Parameters.Add("@idEstudiante", SqlDbType.Int);
                comando.Parameters.Add("@nombreEstudiante", SqlDbType.NVarChar, 120);
                comando.Parameters.Add("@idGrado", SqlDbType.Int);
                comando.Parameters.Add("@nombreGrado", SqlDbType.NVarChar, 60);
                comando.Parameters.Add("@idMateria", SqlDbType.Int);
                comando.Parameters.Add("@nombreMateria", SqlDbType.NVarChar, 100);
                comando.Parameters.Add("@idDocente", SqlDbType.Int);
                comando.Parameters.Add("@nombreDocente", SqlDbType.NVarChar, 120);
                comando.Parameters.Add("@fecha", SqlDbType.Date);
                comando.Parameters.Add("@estado", SqlDbType.NVarChar, 20);

                int guardadas = 0;
                foreach (Asistencia item in asistencias)
                {
                    comando.Parameters["@idEstudiante"].Value = item.IdEstudiante;
                    comando.Parameters["@nombreEstudiante"].Value = item.NombreEstudiante;
                    comando.Parameters["@idGrado"].Value = item.IdGrado;
                    comando.Parameters["@nombreGrado"].Value = item.NombreGrado;
                    comando.Parameters["@idMateria"].Value = item.IdMateria;
                    comando.Parameters["@nombreMateria"].Value = item.NombreMateria;
                    comando.Parameters["@idDocente"].Value = item.IdDocente;
                    comando.Parameters["@nombreDocente"].Value = item.NombreDocente;
                    comando.Parameters["@fecha"].Value = item.Fecha.Date;
                    comando.Parameters["@estado"].Value = item.Estado;
                    comando.ExecuteNonQuery();
                    guardadas++;
                }

                transaccion.Commit();
                return guardadas;
            }
            catch
            {
                transaccion.Rollback();
                throw;
            }
        }

        public Dictionary<int, string> ObtenerEstados(
            int idGrado,
            int idMateria,
            DateTime fecha)
        {
            const string sql = @"
                SELECT id_estudiante, estado
                FROM Asistencia
                WHERE id_grado = @idGrado
                  AND id_materia = @idMateria
                  AND fecha = @fecha;";

            var estados = new Dictionary<int, string>();
            using SqlConnection conexion = db.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.Add("@idGrado", SqlDbType.Int).Value = idGrado;
            comando.Parameters.Add("@idMateria", SqlDbType.Int).Value = idMateria;
            comando.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha.Date;
            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
                estados[Convert.ToInt32(reader["id_estudiante"])] =
                    Convert.ToString(reader["estado"]) ?? "Presente";

            return estados;
        }
    }
}
