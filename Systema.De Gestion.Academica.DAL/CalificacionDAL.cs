using Microsoft.Data.SqlClient;
using System.Data;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.DAL
{
    public class CalificacionDAL
    {
        private readonly DBComun db = new DBComun();

        public bool Insertar(Calificacion calificacion)
        {
            return GuardarLote(new[] { calificacion }) == 1;
        }

        public int GuardarLote(IReadOnlyCollection<Calificacion> calificaciones)
        {
            if (calificaciones.Count == 0)
                return 0;

            const string sql = @"
                UPDATE Calificacion
                SET nombre_estudiante = @nombreEstudiante,
                    nombre_grado = @nombreGrado,
                    nombre_materia = @nombreMateria,
                    nombre_docente = @nombreDocente,
                    nota = @nota
                WHERE id_estudiante = @idEstudiante
                  AND id_grado = @idGrado
                  AND id_materia = @idMateria
                  AND periodo = @periodo;

                IF @@ROWCOUNT = 0
                BEGIN
                    INSERT INTO Calificacion
                    (id_estudiante, nombre_estudiante, id_grado, nombre_grado,
                     id_materia, nombre_materia, id_docente, nombre_docente,
                     periodo, nota)
                    VALUES
                    (@idEstudiante, @nombreEstudiante, @idGrado, @nombreGrado,
                     @idMateria, @nombreMateria, @idDocente, @nombreDocente,
                     @periodo, @nota);
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
                comando.Parameters.Add("@periodo", SqlDbType.NVarChar, 50);
                var parametroNota = comando.Parameters.Add("@nota", SqlDbType.Decimal);
                parametroNota.Precision = 4;
                parametroNota.Scale = 2;

                int guardadas = 0;
                foreach (Calificacion item in calificaciones)
                {
                    comando.Parameters["@idEstudiante"].Value = item.IdEstudiante;
                    comando.Parameters["@nombreEstudiante"].Value = item.NombreEstudiante;
                    comando.Parameters["@idGrado"].Value = item.IdGrado;
                    comando.Parameters["@nombreGrado"].Value = item.NombreGrado;
                    comando.Parameters["@idMateria"].Value = item.IdMateria;
                    comando.Parameters["@nombreMateria"].Value = item.NombreMateria;
                    comando.Parameters["@idDocente"].Value = item.IdDocente;
                    comando.Parameters["@nombreDocente"].Value = item.NombreDocente;
                    comando.Parameters["@periodo"].Value = item.Periodo;
                    comando.Parameters["@nota"].Value = item.Nota;
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

        public Dictionary<int, decimal> ObtenerNotas(
            int idGrado,
            int idMateria,
            string periodo)
        {
            const string sql = @"
                SELECT id_estudiante, nota
                FROM Calificacion
                WHERE id_grado = @idGrado
                  AND id_materia = @idMateria
                  AND periodo = @periodo;";

            var notas = new Dictionary<int, decimal>();
            using SqlConnection conexion = db.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.Add("@idGrado", SqlDbType.Int).Value = idGrado;
            comando.Parameters.Add("@idMateria", SqlDbType.Int).Value = idMateria;
            comando.Parameters.Add("@periodo", SqlDbType.NVarChar, 50).Value = periodo;
            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
                notas[Convert.ToInt32(reader["id_estudiante"])] = Convert.ToDecimal(reader["nota"]);

            return notas;
        }
    }
}
