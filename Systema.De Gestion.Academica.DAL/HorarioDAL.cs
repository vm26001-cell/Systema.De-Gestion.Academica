using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using Systema.De_Gestion.Academica.EN;
using Systema.De_Gestion.Academica.DAL;

namespace Systema.De_Gestion.Academica.DAL
{
    public class HorarioDAL
    {
        private readonly DBComun dbComun;

        public HorarioDAL()
        {
            dbComun = new DBComun();
        }

        // =====================================================
        // INSERTAR HORARIO
        // =====================================================

        public bool Insertar(Horario horario)
        {
            using (SqlConnection conexion = dbComun.ObtenerConexion())
            {
                string sql = @"
                    INSERT INTO Horario
                    (
                        Grado,
                        Dia,
                        Materia,
                        Docente,
                        Aula,
                        HoraInicio,
                        HoraFin
                    )
                    VALUES
                    (
                        @Grado,
                        @Dia,
                        @Materia,
                        @Docente,
                        @Aula,
                        @HoraInicio,
                        @HoraFin
                    )";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@Grado",
                        horario.Grado);

                    comando.Parameters.AddWithValue(
                        "@Dia",
                        horario.Dia);

                    comando.Parameters.AddWithValue(
                        "@Materia",
                        horario.Materia);

                    comando.Parameters.AddWithValue(
                        "@Docente",
                        horario.Docente);

                    comando.Parameters.AddWithValue(
                        "@Aula",
                        horario.Aula);

                    comando.Parameters.AddWithValue(
                        "@HoraInicio",
                        horario.HoraInicio);

                    comando.Parameters.AddWithValue(
                        "@HoraFin",
                        horario.HoraFin);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // =====================================================
        // MODIFICAR HORARIO
        // =====================================================

        public bool Modificar(Horario horario)
        {
            using (SqlConnection conexion = dbComun.ObtenerConexion())
            {
                string sql = @"
                    UPDATE Horario
                    SET
                        Grado = @Grado,
                        Dia = @Dia,
                        Materia = @Materia,
                        Docente = @Docente,
                        Aula = @Aula,
                        HoraInicio = @HoraInicio,
                        HoraFin = @HoraFin
                    WHERE IdHorario = @IdHorario";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@IdHorario",
                        horario.IdHorario);

                    comando.Parameters.AddWithValue(
                        "@Grado",
                        horario.Grado);

                    comando.Parameters.AddWithValue(
                        "@Dia",
                        horario.Dia);

                    comando.Parameters.AddWithValue(
                        "@Materia",
                        horario.Materia);

                    comando.Parameters.AddWithValue(
                        "@Docente",
                        horario.Docente);

                    comando.Parameters.AddWithValue(
                        "@Aula",
                        horario.Aula);

                    comando.Parameters.AddWithValue(
                        "@HoraInicio",
                        horario.HoraInicio);

                    comando.Parameters.AddWithValue(
                        "@HoraFin",
                        horario.HoraFin);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // =====================================================
        // ELIMINAR HORARIO
        // =====================================================

        public bool Eliminar(int idHorario)
        {
            using (SqlConnection conexion = dbComun.ObtenerConexion())
            {
                string sql = @"
                    DELETE FROM Horario
                    WHERE IdHorario = @IdHorario";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@IdHorario",
                        idHorario);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // =====================================================
        // OBTENER TODOS
        // =====================================================

        public List<Horario> ObtenerTodos()
        {
            List<Horario> lista = new List<Horario>();

            using (SqlConnection conexion = dbComun.ObtenerConexion())
            {
                string sql = @"
                    SELECT
                        IdHorario,
                        Grado,
                        Dia,
                        Materia,
                        Docente,
                        Aula,
                        HoraInicio,
                        HoraFin
                    FROM Horario
                    ORDER BY
                        Grado,
                        Dia,
                        HoraInicio";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(CrearHorario(reader));
                        }
                    }
                }
            }

            return lista;
        }

        // =====================================================
        // BUSCAR POR GRADO Y DÍA
        // =====================================================

        public List<Horario> BuscarPorGradoDia(
            string grado,
            string dia)
        {
            List<Horario> lista = new List<Horario>();

            using (SqlConnection conexion = dbComun.ObtenerConexion())
            {
                string sql = @"
                    SELECT
                        IdHorario,
                        Grado,
                        Dia,
                        Materia,
                        Docente,
                        Aula,
                        HoraInicio,
                        HoraFin
                    FROM Horario
                    WHERE Grado = @Grado
                    AND Dia = @Dia
                    ORDER BY HoraInicio";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@Grado",
                        grado);

                    comando.Parameters.AddWithValue(
                        "@Dia",
                        dia);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(CrearHorario(reader));
                        }
                    }
                }
            }

            return lista;
        }

        // =====================================================
        // VERIFICAR CONFLICTO DE HORARIO
        // =====================================================

        public bool ExisteConflicto(
            Horario horario)
        {
            using (SqlConnection conexion = dbComun.ObtenerConexion())
            {
                string sql = @"
                    SELECT COUNT(*)
                    FROM Horario
                    WHERE Grado = @Grado
                    AND Dia = @Dia
                    AND
                    (
                        @HoraInicio < HoraFin
                        AND
                        @HoraFin > HoraInicio
                    )";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@Grado",
                        horario.Grado);

                    comando.Parameters.AddWithValue(
                        "@Dia",
                        horario.Dia);

                    comando.Parameters.AddWithValue(
                        "@HoraInicio",
                        horario.HoraInicio);

                    comando.Parameters.AddWithValue(
                        "@HoraFin",
                        horario.HoraFin);

                    conexion.Open();

                    int cantidad =
                        Convert.ToInt32(
                            comando.ExecuteScalar());

                    return cantidad > 0;
                }
            }
        }

        // =====================================================
        // CONVERTIR READER A HORARIO
        // =====================================================

        private Horario CrearHorario(
            SqlDataReader reader)
        {
            Horario horario = new Horario();

            horario.IdHorario =
                Convert.ToInt32(
                    reader["IdHorario"]);

            horario.Grado =
                reader["Grado"].ToString();

            horario.Dia =
                reader["Dia"].ToString();

            horario.Materia =
                reader["Materia"].ToString();

            horario.Docente =
                reader["Docente"].ToString();

            horario.Aula =
                reader["Aula"].ToString();

            horario.HoraInicio =
                (TimeSpan)reader["HoraInicio"];

            horario.HoraFin =
                (TimeSpan)reader["HoraFin"];

            return horario;
        }
    }
}