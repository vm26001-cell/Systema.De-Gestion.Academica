using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.DAL
{
    public class DocenteDAL
    {
        private readonly DBComun db;

        public DocenteDAL()
        {
            db = new DBComun();
        }

        // ==========================================
        // INSERTAR
        // ==========================================

        public bool Insertar(Docente docente)
        {
            using (SqlConnection conexion = db.ObtenerConexion())
            {
                string consulta = @"
                    INSERT INTO Docente
                    (
                        codigo,
                        nombre,
                        apellido,
                        dui,
                        telefono,
                        correo,
                        especialidad,
                        materia
                    )
                    VALUES
                    (
                        @codigo,
                        @nombre,
                        @apellido,
                        @dui,
                        @telefono,
                        @correo,
                        @especialidad,
                        @materia
                    )";

                using (SqlCommand comando =
                    new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@codigo",
                        docente.Codigo);

                    comando.Parameters.AddWithValue(
                        "@nombre",
                        docente.Nombre);

                    comando.Parameters.AddWithValue(
                        "@apellido",
                        docente.Apellido);

                    comando.Parameters.AddWithValue(
                        "@dui",
                        docente.Dui);

                    comando.Parameters.AddWithValue(
                        "@telefono",
                        docente.Telefono);

                    comando.Parameters.AddWithValue(
                        "@correo",
                        docente.Correo);

                    comando.Parameters.AddWithValue(
                        "@especialidad",
                        docente.Especialidad);

                    comando.Parameters.AddWithValue(
                        "@materia",
                        docente.Materia);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }


        // ==========================================
        // BUSCAR
        // ==========================================

        public List<Docente> Buscar(string texto)
        {
            List<Docente> lista =
                new List<Docente>();

            using (SqlConnection conexion =
                db.ObtenerConexion())
            {
                string consulta = @"
                    SELECT
                        id_docente,
                        codigo,
                        nombre,
                        apellido,
                        dui,
                        telefono,
                        correo,
                        especialidad,
                        materia
                    FROM Docente
                    WHERE codigo LIKE @texto
                       OR nombre LIKE @texto
                       OR apellido LIKE @texto
                       OR dui LIKE @texto";

                using (SqlCommand comando =
                    new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@texto",
                        "%" + texto + "%");

                    conexion.Open();

                    using (SqlDataReader reader =
                        comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(
                                new Docente
                                {
                                    IdDocente =
                                        Convert.ToInt32(
                                            reader["id_docente"]),

                                    Codigo =
                                        reader["codigo"].ToString(),

                                    Nombre =
                                        reader["nombre"].ToString(),

                                    Apellido =
                                        reader["apellido"].ToString(),

                                    Dui =
                                        reader["dui"].ToString(),

                                    Telefono =
                                        reader["telefono"].ToString(),

                                    Correo =
                                        reader["correo"].ToString(),

                                    Especialidad =
                                        reader["especialidad"].ToString(),

                                    Materia =
                                        reader["materia"].ToString()
                                }
                            );
                        }
                    }
                }
            }

            return lista;
        }


        // ==========================================
        // MODIFICAR
        // ==========================================

        public bool Modificar(Docente docente)
        {
            using (SqlConnection conexion =
                db.ObtenerConexion())
            {
                string consulta = @"
                    UPDATE Docente
                    SET
                        codigo = @codigo,
                        nombre = @nombre,
                        apellido = @apellido,
                        dui = @dui,
                        telefono = @telefono,
                        correo = @correo,
                        especialidad = @especialidad,
                        materia = @materia
                    WHERE id_docente = @id_docente";

                using (SqlCommand comando =
                    new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@id_docente",
                        docente.IdDocente);

                    comando.Parameters.AddWithValue(
                        "@codigo",
                        docente.Codigo);

                    comando.Parameters.AddWithValue(
                        "@nombre",
                        docente.Nombre);

                    comando.Parameters.AddWithValue(
                        "@apellido",
                        docente.Apellido);

                    comando.Parameters.AddWithValue(
                        "@dui",
                        docente.Dui);

                    comando.Parameters.AddWithValue(
                        "@telefono",
                        docente.Telefono);

                    comando.Parameters.AddWithValue(
                        "@correo",
                        docente.Correo);

                    comando.Parameters.AddWithValue(
                        "@especialidad",
                        docente.Especialidad);

                    comando.Parameters.AddWithValue(
                        "@materia",
                        docente.Materia);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}