using System.Data;
using Systema.De_Gestion.Academica.DAL;

namespace Systema.De_Gestion.Academica.BL
{
    public class ReporteBL
    {
        private readonly ReporteDAL reporteDAL = new ReporteDAL();

        public DataTable ObtenerCalificaciones(int idEstudiante, string periodo)
        {
            Validar(idEstudiante, periodo);
            return reporteDAL.ObtenerCalificaciones(idEstudiante, periodo);
        }

        public decimal ObtenerPromedio(int idEstudiante, string periodo)
        {
            Validar(idEstudiante, periodo);
            return reporteDAL.ObtenerPromedio(idEstudiante, periodo);
        }

        private static void Validar(int idEstudiante, string periodo)
        {
            if (idEstudiante <= 0)
                throw new ArgumentException("Debe seleccionar un estudiante.");
            if (string.IsNullOrWhiteSpace(periodo))
                throw new ArgumentException("Debe seleccionar un periodo.");
        }
    }
}
