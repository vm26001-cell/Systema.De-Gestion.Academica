using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;

namespace Systema.De_Gestion.Academica.DAL
{
    public class ReporteDAL
    {
        private readonly DBComun db;

        public ReporteDAL()
        {
            db = new DBComun();
        }

        // =====================================================
        // OBTENER CALIFICACIONES DEL ESTUDIANTE
        // =====================================================

        public DataTable ObtenerCalificaciones(
            string nombreEstudiante,
            string nombreGrado,
            string periodo)
        {
            DataTable tabla =
                new DataTable();

            using (SqlConnection conexion =
                db.ObtenerConexion())
            {
                string consulta = @"
                    SELECT
                        nombre_materia AS Materia,
                        nota AS Nota
                    FROM Calificacion
                    WHERE nombre_estudiante = @nombreEstudiante
                    AND nombre_grado = @nombreGrado
                    AND periodo = @periodo
                    ORDER BY nombre_materia";

                using (SqlCommand comando =
                    new SqlCommand(
                        consulta,
                        conexion))
                {
                    comando.Parameters.Add(
                        "@nombreEstudiante",
                        SqlDbType.VarChar,
                        100
                    ).Value =
                        nombreEstudiante;

                    comando.Parameters.Add(
                        "@nombreGrado",
                        SqlDbType.VarChar,
                        50
                    ).Value =
                        nombreGrado;

                    comando.Parameters.Add(
                        "@periodo",
                        SqlDbType.VarChar,
                        50
                    ).Value =
                        periodo;

                    using (SqlDataAdapter adaptador =
                        new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }

        // =====================================================
        // OBTENER PROMEDIO
        // =====================================================

        public decimal ObtenerPromedio(
            string nombreEstudiante,
            string nombreGrado,
            string periodo)
        {
            using (SqlConnection conexion =
                db.ObtenerConexion())
            {
                string consulta = @"
                    SELECT AVG(nota)
                    FROM Calificacion
                    WHERE nombre_estudiante = @nombreEstudiante
                    AND nombre_grado = @nombreGrado
                    AND periodo = @periodo";

                using (SqlCommand comando =
                    new SqlCommand(
                        consulta,
                        conexion))
                {
                    comando.Parameters.Add(
                        "@nombreEstudiante",
                        SqlDbType.VarChar,
                        100
                    ).Value =
                        nombreEstudiante;

                    comando.Parameters.Add(
                        "@nombreGrado",
                        SqlDbType.VarChar,
                        50
                    ).Value =
                        nombreGrado;

                    comando.Parameters.Add(
                        "@periodo",
                        SqlDbType.VarChar,
                        50
                    ).Value =
                        periodo;

                    conexion.Open();

                    object resultado =
                        comando.ExecuteScalar();

                    if (resultado == null ||
                        resultado == DBNull.Value)
                    {
                        return 0;
                    }

                    return Convert.ToDecimal(
                        resultado);
                }
            }
        }
    }
}