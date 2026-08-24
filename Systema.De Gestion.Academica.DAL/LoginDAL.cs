using Microsoft.Data.SqlClient;
using System.Data;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.DAL
{
    public class LoginDAL
    {
        private readonly DBComun db = new DBComun();

        public Usuario? BuscarUsuarioActivo(string nombreUsuario, string rol)
        {
            const string consulta = @"
                SELECT TOP (1)
                    u.id_usuario,
                    u.nombre_usuario,
                    u.[password],
                    r.nombre AS rol,
                    u.id_estudiante
                FROM Usuario u
                INNER JOIN Rol r ON r.id_rol = u.id_rol
                WHERE u.nombre_usuario = @usuario
                  AND r.nombre = @rol
                  AND u.estado = 'Activo';";

            using SqlConnection conexion = db.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.Add("@usuario", SqlDbType.NVarChar, 50).Value = nombreUsuario;
            comando.Parameters.Add("@rol", SqlDbType.NVarChar, 30).Value = rol;
            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();
            if (!reader.Read())
                return null;

            return new Usuario
            {
                IdUsuario = Convert.ToInt32(reader["id_usuario"]),
                UsuarioNombre = Convert.ToString(reader["nombre_usuario"]) ?? string.Empty,
                Contrasena = Convert.ToString(reader["password"]) ?? string.Empty,
                Rol = Convert.ToString(reader["rol"]) ?? string.Empty,
                IdEstudiante = reader["id_estudiante"] == DBNull.Value
                    ? null
                    : Convert.ToInt32(reader["id_estudiante"])
            };
        }

        public void ActualizarContrasena(int idUsuario, string nuevoHash)
        {
            const string consulta = @"
                UPDATE Usuario
                SET [password] = @hash
                WHERE id_usuario = @idUsuario;";

            using SqlConnection conexion = db.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.Add("@hash", SqlDbType.NVarChar, 300).Value = nuevoHash;
            comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
            conexion.Open();
            comando.ExecuteNonQuery();
        }
    }
}
