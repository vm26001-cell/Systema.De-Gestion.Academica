using System;
using System.Data;
using Systema.De_Gestion.Academica.DAL;

namespace Systema.De_Gestion.Academica.BL
{
    public class ReporteBL
    {
        private readonly ReporteDAL reporteDAL;

        public ReporteBL()
        {
            reporteDAL =
                new ReporteDAL();
        }

        // =====================================================
        // OBTENER CALIFICACIONES
        // =====================================================

        public DataTable ObtenerCalificaciones(
            string estudiante,
            string grado,
            string periodo)
        {
            if (string.IsNullOrWhiteSpace(estudiante))
            {
                throw new Exception(
                    "Debe seleccionar un estudiante.");
            }

            if (string.IsNullOrWhiteSpace(grado))
            {
                throw new Exception(
                    "Debe seleccionar un grado.");
            }

            if (string.IsNullOrWhiteSpace(periodo))
            {
                throw new Exception(
                    "Debe seleccionar un periodo.");
            }

            return reporteDAL.ObtenerCalificaciones(
                estudiante,
                grado,
                periodo);
        }

        // =====================================================
        // OBTENER PROMEDIO
        // =====================================================

        public decimal ObtenerPromedio(
            string estudiante,
            string grado,
            string periodo)
        {
            return reporteDAL.ObtenerPromedio(
                estudiante,
                grado,
                periodo);
        }
    }
}