using System;
using Microsoft.Data.SqlClient;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.DAL
{
    public class LoginDAL
    {
        private readonly DBComun db = new DBComun();

        public Usuario ValidarLogin(
            string usuario,
            string contrasena,
            string rol)
        {
            Usuario usuarioEncontrado = null;

            int idRol;

            switch (rol)
            {
                case "Administrador":
                    idRol = 1;
                    break;

                case "Docente":
                    idRol = 2;
                    break;

                case "Padre":
                    idRol = 3;
                    break;

                case "Estudiante":
                    idRol = 4;
                    break;

                default:
                    return null;
            }

            using (SqlConnection conexion = db.ObtenerConexion())
            {
                string consulta = @"
                    SELECT
                        id_usuario,
                        nombre_usuario,
                        [password],
                        estado,
                        id_rol
                    FROM Usuario
                    WHERE nombre_usuario = @usuario
                    AND [password] = @contrasena
                    AND id_rol = @idRol
                    AND estado = 'Activo'";

                using (SqlCommand comando =
                    new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@usuario",
                        usuario);

                    comando.Parameters.AddWithValue(
                        "@contrasena",
                        contrasena);

                    comando.Parameters.AddWithValue(
                        "@idRol",
                        idRol);

                    conexion.Open();

                    using (SqlDataReader reader =
                        comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuarioEncontrado = new Usuario
                            {
                                IdUsuario =
                                    Convert.ToInt32(
                                        reader["id_usuario"]),

                                UsuarioNombre =
                                    reader["nombre_usuario"]
                                    .ToString(),

                                Contrasena =
                                    reader["password"]
                                    .ToString(),

                                Rol =
                                    reader["id_rol"]
                                    .ToString()
                            };
                        }
                    }
                }
            }

            return usuarioEncontrado;
        }
    }
}