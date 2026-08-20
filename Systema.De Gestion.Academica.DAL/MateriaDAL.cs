using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.DAL
{
    public class MateriaDAL
    {
        private readonly DBComun dbComun;

        public MateriaDAL()
        {
            dbComun = new DBComun();
        }

        // =====================================================
        // INSERTAR
        // =====================================================

        public bool Insertar(Materia materia)
        {
            using (SqlConnection conexion = dbComun.ObtenerConexion())
            {
                string sql = @"
                    INSERT INTO Materia
                    (
                        Codigo,
                        Nombre,
                        Descripcion,
                        Grado,
                        Docente
                    )
                    VALUES
                    (
                        @Codigo,
                        @Nombre,
                        @Descripcion,
                        @Grado,
                        @Docente
                    )";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@Codigo",
                        materia.Codigo);

                    comando.Parameters.AddWithValue(
                        "@Nombre",
                        materia.Nombre);

                    comando.Parameters.AddWithValue(
                        "@Descripcion",
                        string.IsNullOrWhiteSpace(materia.Descripcion)
                            ? (object)DBNull.Value
                            : materia.Descripcion);

                    comando.Parameters.AddWithValue(
                        "@Grado",
                        materia.Grado);

                    comando.Parameters.AddWithValue(
                        "@Docente",
                        string.IsNullOrWhiteSpace(materia.Docente)
                            ? (object)DBNull.Value
                            : materia.Docente);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // =====================================================
        // MODIFICAR
        // =====================================================

        public bool Modificar(Materia materia)
        {
            using (SqlConnection conexion = dbComun.ObtenerConexion())
            {
                string sql = @"
                    UPDATE Materia
                    SET
                        Nombre = @Nombre,
                        Descripcion = @Descripcion,
                        Grado = @Grado,
                        Docente = @Docente
                    WHERE Codigo = @Codigo";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@Codigo",
                        materia.Codigo);

                    comando.Parameters.AddWithValue(
                        "@Nombre",
                        materia.Nombre);

                    comando.Parameters.AddWithValue(
                        "@Descripcion",
                        string.IsNullOrWhiteSpace(materia.Descripcion)
                            ? (object)DBNull.Value
                            : materia.Descripcion);

                    comando.Parameters.AddWithValue(
                        "@Grado",
                        materia.Grado);

                    comando.Parameters.AddWithValue(
                        "@Docente",
                        string.IsNullOrWhiteSpace(materia.Docente)
                            ? (object)DBNull.Value
                            : materia.Docente);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // =====================================================
        // ELIMINAR
        // =====================================================

        public bool Eliminar(string codigo)
        {
            using (SqlConnection conexion = dbComun.ObtenerConexion())
            {
                string sql = @"
                    DELETE FROM Materia
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

        // =====================================================
        // BUSCAR POR CÓDIGO
        // =====================================================

        public Materia BuscarPorCodigo(string codigo)
        {
            using (SqlConnection conexion = dbComun.ObtenerConexion())
            {
                string sql = @"
                    SELECT
                        IdMateria,
                        Codigo,
                        Nombre,
                        Descripcion,
                        Grado,
                        Docente
                    FROM Materia
                    WHERE Codigo = @Codigo";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@Codigo",
                        codigo);

                    conexion.Open();

                    using (SqlDataReader reader =
                           comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return CrearMateria(reader);
                        }
                    }
                }
            }

            return null;
        }

        // =====================================================
        // BUSCAR
        // =====================================================

        public List<Materia> Buscar(string texto)
        {
            List<Materia> lista =
                new List<Materia>();

            using (SqlConnection conexion =
                   dbComun.ObtenerConexion())
            {
                string sql = @"
                    SELECT
                        IdMateria,
                        Codigo,
                        Nombre,
                        Descripcion,
                        Grado,
                        Docente
                    FROM Materia
                    WHERE Codigo LIKE @Texto
                       OR Nombre LIKE @Texto
                       OR Grado LIKE @Texto
                       OR Docente LIKE @Texto
                    ORDER BY Nombre";

                using (SqlCommand comando =
                       new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@Texto",
                        "%" + texto + "%");

                    conexion.Open();

                    using (SqlDataReader reader =
                           comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(
                                CrearMateria(reader));
                        }
                    }
                }
            }

            return lista;
        }

        // =====================================================
        // OBTENER TODAS
        // =====================================================

        public List<Materia> ObtenerTodas()
        {
            List<Materia> lista =
                new List<Materia>();

            using (SqlConnection conexion =
                   dbComun.ObtenerConexion())
            {
                string sql = @"
                    SELECT
                        IdMateria,
                        Codigo,
                        Nombre,
                        Descripcion,
                        Grado,
                        Docente
                    FROM Materia
                    ORDER BY Nombre";

                using (SqlCommand comando =
                       new SqlCommand(sql, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader =
                           comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(
                                CrearMateria(reader));
                        }
                    }
                }
            }

            return lista;
        }

        // =====================================================
        // CONVERTIR READER A OBJETO
        // =====================================================

        private Materia CrearMateria(
            SqlDataReader reader)
        {
            Materia materia = new Materia();

            materia.IdMateria =
                Convert.ToInt32(
                    reader["IdMateria"]);

            materia.Codigo =
                reader["Codigo"].ToString();

            materia.Nombre =
                reader["Nombre"].ToString();

            materia.Descripcion =
                reader["Descripcion"] == DBNull.Value
                    ? ""
                    : reader["Descripcion"].ToString();

            materia.Grado =
                reader["Grado"].ToString();

            materia.Docente =
                reader["Docente"] == DBNull.Value
                    ? ""
                    : reader["Docente"].ToString();

            return materia;
        }
    }
}