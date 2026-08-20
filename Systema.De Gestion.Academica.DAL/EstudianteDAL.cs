using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.DAL
{
    public class EstudianteDAL
    {
        private readonly DBComun dbComun;

        public EstudianteDAL()
        {
            dbComun = new DBComun();
        }

        // =========================================================
        // INSERTAR ESTUDIANTE
        // =========================================================
        public bool Insertar(Estudiante estudiante)
        {
            using (SqlConnection conexion = dbComun.ObtenerConexion())
            {
                string sql = @"
                    INSERT INTO Estudiante
                    (
                        Codigo,
                        Nombre,
                        Apellido,
                        DUI,
                        FechaNacimiento,
                        Telefono,
                        Correo,
                        Grado,
                        Seccion,
                        Anio
                    )
                    VALUES
                    (
                        @Codigo,
                        @Nombre,
                        @Apellido,
                        @DUI,
                        @FechaNacimiento,
                        @Telefono,
                        @Correo,
                        @Grado,
                        @Seccion,
                        @Anio
                    )";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@Codigo",
                        estudiante.Codigo);

                    comando.Parameters.AddWithValue(
                        "@Nombre",
                        estudiante.Nombre);

                    comando.Parameters.AddWithValue(
                        "@Apellido",
                        estudiante.Apellido);

                    comando.Parameters.AddWithValue(
                        "@DUI",
                        string.IsNullOrWhiteSpace(estudiante.DUI)
                            ? (object)DBNull.Value
                            : estudiante.DUI);

                    comando.Parameters.AddWithValue(
                        "@FechaNacimiento",
                        estudiante.FechaNacimiento);

                    comando.Parameters.AddWithValue(
                        "@Telefono",
                        string.IsNullOrWhiteSpace(estudiante.Telefono)
                            ? (object)DBNull.Value
                            : estudiante.Telefono);

                    comando.Parameters.AddWithValue(
                        "@Correo",
                        string.IsNullOrWhiteSpace(estudiante.Correo)
                            ? (object)DBNull.Value
                            : estudiante.Correo);

                    comando.Parameters.AddWithValue(
                        "@Grado",
                        estudiante.Grado);

                    comando.Parameters.AddWithValue(
                        "@Seccion",
                        estudiante.Seccion);

                    comando.Parameters.AddWithValue(
                        "@Anio",
                        estudiante.Anio);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // =========================================================
        // MODIFICAR ESTUDIANTE
        // =========================================================
        public bool Modificar(Estudiante estudiante)
        {
            using (SqlConnection conexion = dbComun.ObtenerConexion())
            {
                string sql = @"
                    UPDATE Estudiante
                    SET
                        Nombre = @Nombre,
                        Apellido = @Apellido,
                        DUI = @DUI,
                        FechaNacimiento = @FechaNacimiento,
                        Telefono = @Telefono,
                        Correo = @Correo,
                        Grado = @Grado,
                        Seccion = @Seccion,
                        Anio = @Anio
                    WHERE Codigo = @Codigo";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@Codigo",
                        estudiante.Codigo);

                    comando.Parameters.AddWithValue(
                        "@Nombre",
                        estudiante.Nombre);

                    comando.Parameters.AddWithValue(
                        "@Apellido",
                        estudiante.Apellido);

                    comando.Parameters.AddWithValue(
                        "@DUI",
                        string.IsNullOrWhiteSpace(estudiante.DUI)
                            ? (object)DBNull.Value
                            : estudiante.DUI);

                    comando.Parameters.AddWithValue(
                        "@FechaNacimiento",
                        estudiante.FechaNacimiento);

                    comando.Parameters.AddWithValue(
                        "@Telefono",
                        string.IsNullOrWhiteSpace(estudiante.Telefono)
                            ? (object)DBNull.Value
                            : estudiante.Telefono);

                    comando.Parameters.AddWithValue(
                        "@Correo",
                        string.IsNullOrWhiteSpace(estudiante.Correo)
                            ? (object)DBNull.Value
                            : estudiante.Correo);

                    comando.Parameters.AddWithValue(
                        "@Grado",
                        estudiante.Grado);

                    comando.Parameters.AddWithValue(
                        "@Seccion",
                        estudiante.Seccion);

                    comando.Parameters.AddWithValue(
                        "@Anio",
                        estudiante.Anio);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // =========================================================
        // BUSCAR ESTUDIANTE POR CÓDIGO
        // =========================================================
        public Estudiante BuscarPorCodigo(string codigo)
        {
            using (SqlConnection conexion = dbComun.ObtenerConexion())
            {
                string sql = @"
                    SELECT
                        IdEstudiante,
                        Codigo,
                        Nombre,
                        Apellido,
                        DUI,
                        FechaNacimiento,
                        Telefono,
                        Correo,
                        Grado,
                        Seccion,
                        Anio
                    FROM Estudiante
                    WHERE Codigo = @Codigo";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@Codigo",
                        codigo);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return CrearEstudiante(reader);
                        }
                    }
                }
            }

            return null;
        }

        // =========================================================
        // BUSCAR POR CÓDIGO, NOMBRE O APELLIDO
        // =========================================================
        public List<Estudiante> Buscar(string texto)
        {
            List<Estudiante> lista = new List<Estudiante>();

            using (SqlConnection conexion = dbComun.ObtenerConexion())
            {
                string sql = @"
                    SELECT
                        IdEstudiante,
                        Codigo,
                        Nombre,
                        Apellido,
                        DUI,
                        FechaNacimiento,
                        Telefono,
                        Correo,
                        Grado,
                        Seccion,
                        Anio
                    FROM Estudiante
                    WHERE Codigo LIKE @Texto
                       OR Nombre LIKE @Texto
                       OR Apellido LIKE @Texto
                    ORDER BY Nombre, Apellido";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@Texto",
                        "%" + texto + "%");

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(CrearEstudiante(reader));
                        }
                    }
                }
            }

            return lista;
        }

        // =========================================================
        // ELIMINAR ESTUDIANTE
        // =========================================================
        public bool Eliminar(string codigo)
        {
            using (SqlConnection conexion = dbComun.ObtenerConexion())
            {
                string sql = @"
                    DELETE FROM Estudiante
                    WHERE Codigo = @Codigo";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@Codigo",
                        codigo);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // =========================================================
        // CONVERTIR SqlDataReader A OBJETO ESTUDIANTE
        // =========================================================
        private Estudiante CrearEstudiante(SqlDataReader reader)
        {
            Estudiante estudiante = new Estudiante();

            estudiante.IdEstudiante =
                Convert.ToInt32(reader["IdEstudiante"]);

            estudiante.Codigo =
                reader["Codigo"].ToString();

            estudiante.Nombre =
                reader["Nombre"].ToString();

            estudiante.Apellido =
                reader["Apellido"].ToString();

            estudiante.DUI =
                reader["DUI"] == DBNull.Value
                    ? ""
                    : reader["DUI"].ToString();

            estudiante.FechaNacimiento =
                Convert.ToDateTime(
                    reader["FechaNacimiento"]);

            estudiante.Telefono =
                reader["Telefono"] == DBNull.Value
                    ? ""
                    : reader["Telefono"].ToString();

            estudiante.Correo =
                reader["Correo"] == DBNull.Value
                    ? ""
                    : reader["Correo"].ToString();

            estudiante.Grado =
                reader["Grado"].ToString();

            estudiante.Seccion =
                reader["Seccion"].ToString();

            estudiante.Anio =
                Convert.ToInt32(reader["Anio"]);

            return estudiante;
        }
    }
}
