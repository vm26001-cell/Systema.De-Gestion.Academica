using Microsoft.Data.SqlClient;
using System.Data;

namespace Systema.De_Gestion.Academica.DAL
{
    public class ReporteDAL
    {
        private readonly DBComun db = new DBComun();

        public DataTable ObtenerCalificaciones(int idEstudiante, string periodo)
        {
            const string consulta = @"
                SELECT nombre_materia AS Materia,
                       nota AS Nota
                FROM Calificacion
                WHERE id_estudiante = @idEstudiante
                  AND periodo = @periodo
                ORDER BY nombre_materia;";

            var tabla = new DataTable();
            using SqlConnection conexion = db.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.Add("@idEstudiante", SqlDbType.Int).Value = idEstudiante;
            comando.Parameters.Add("@periodo", SqlDbType.NVarChar, 50).Value = periodo;
            using SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);
            return tabla;
        }

        public decimal ObtenerPromedio(int idEstudiante, string periodo)
        {
            const string consulta = @"
                SELECT AVG(CAST(nota AS decimal(10,2)))
                FROM Calificacion
                WHERE id_estudiante = @idEstudiante
                  AND periodo = @periodo;";

            using SqlConnection conexion = db.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.Add("@idEstudiante", SqlDbType.Int).Value = idEstudiante;
            comando.Parameters.Add("@periodo", SqlDbType.NVarChar, 50).Value = periodo;
            conexion.Open();
            object? resultado = comando.ExecuteScalar();
            return resultado == null || resultado == DBNull.Value
                ? 0m
                : Convert.ToDecimal(resultado);
        }
    }
}
