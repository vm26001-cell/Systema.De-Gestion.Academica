using Microsoft.Data.SqlClient;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.DAL
{
    public class CatalogoDAL
    {
        private readonly DBComun db = new DBComun();

        public List<OpcionCatalogo> ObtenerGrados()
        {
            const string sql = @"
                SELECT id_grado, nombre
                FROM GradoAcademico
                WHERE activo = 1
                ORDER BY orden;";

            return ObtenerOpciones(sql, "id_grado", "nombre");
        }

        public List<OpcionCatalogo> ObtenerMaterias()
        {
            const string sql = @"
                SELECT IdMateria, Nombre
                FROM Materia
                ORDER BY Nombre;";

            return ObtenerOpciones(sql, "IdMateria", "Nombre");
        }

        public List<OpcionCatalogo> ObtenerDocentes()
        {
            const string sql = @"
                SELECT id_docente,
                       LTRIM(RTRIM(nombre + ' ' + apellido)) AS nombre_completo
                FROM Docente
                ORDER BY nombre, apellido;";

            return ObtenerOpciones(sql, "id_docente", "nombre_completo");
        }

        public List<Estudiante> ObtenerEstudiantesPorGrado(int idGrado)
        {
            const string sql = @"
                SELECT e.IdEstudiante, e.Codigo, e.Nombre, e.Apellido,
                       e.DUI, e.FechaNacimiento, e.Telefono, e.Correo,
                       e.Grado, e.Seccion, e.Anio
                FROM Estudiante e
                INNER JOIN GradoAcademico g
                    ON g.nombre = LTRIM(RTRIM(e.Grado + ' ' + e.Seccion))
                WHERE g.id_grado = @idGrado
                ORDER BY e.Nombre, e.Apellido;";

            var estudiantes = new List<Estudiante>();
            using SqlConnection conexion = db.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.Add("@idGrado", System.Data.SqlDbType.Int).Value = idGrado;
            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
                estudiantes.Add(CrearEstudiante(reader));

            return estudiantes;
        }

        public Estudiante? ObtenerEstudiantePorId(int idEstudiante)
        {
            const string sql = @"
                SELECT IdEstudiante, Codigo, Nombre, Apellido, DUI,
                       FechaNacimiento, Telefono, Correo, Grado, Seccion, Anio
                FROM Estudiante
                WHERE IdEstudiante = @idEstudiante;";

            using SqlConnection conexion = db.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.Add("@idEstudiante", System.Data.SqlDbType.Int).Value = idEstudiante;
            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();
            return reader.Read() ? CrearEstudiante(reader) : null;
        }

        private List<OpcionCatalogo> ObtenerOpciones(
            string sql,
            string columnaId,
            string columnaNombre)
        {
            var opciones = new List<OpcionCatalogo>();
            using SqlConnection conexion = db.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(sql, conexion);
            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                opciones.Add(new OpcionCatalogo
                {
                    Id = Convert.ToInt32(reader[columnaId]),
                    Nombre = Convert.ToString(reader[columnaNombre]) ?? string.Empty
                });
            }

            return opciones;
        }

        private static Estudiante CrearEstudiante(SqlDataReader reader)
        {
            return new Estudiante
            {
                IdEstudiante = Convert.ToInt32(reader["IdEstudiante"]),
                Codigo = Convert.ToString(reader["Codigo"]) ?? string.Empty,
                Nombre = Convert.ToString(reader["Nombre"]) ?? string.Empty,
                Apellido = Convert.ToString(reader["Apellido"]) ?? string.Empty,
                DUI = reader["DUI"] == DBNull.Value ? string.Empty : Convert.ToString(reader["DUI"]) ?? string.Empty,
                FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                Telefono = reader["Telefono"] == DBNull.Value ? string.Empty : Convert.ToString(reader["Telefono"]) ?? string.Empty,
                Correo = reader["Correo"] == DBNull.Value ? string.Empty : Convert.ToString(reader["Correo"]) ?? string.Empty,
                Grado = Convert.ToString(reader["Grado"]) ?? string.Empty,
                Seccion = Convert.ToString(reader["Seccion"]) ?? string.Empty,
                Anio = Convert.ToInt32(reader["Anio"])
            };
        }
    }
}
