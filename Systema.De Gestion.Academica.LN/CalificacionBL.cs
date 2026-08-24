using Systema.De_Gestion.Academica.DAL;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.BL
{
    public class CalificacionBL
    {
        private readonly CalificacionDAL calificacionDAL = new CalificacionDAL();

        public bool RegistrarCalificacion(Calificacion calificacion)
        {
            Validar(calificacion);
            return calificacionDAL.Insertar(calificacion);
        }

        public int RegistrarCalificaciones(IReadOnlyCollection<Calificacion> calificaciones)
        {
            if (calificaciones == null || calificaciones.Count == 0)
                throw new ArgumentException("No hay calificaciones para guardar.", nameof(calificaciones));

            foreach (Calificacion item in calificaciones)
                Validar(item);

            return calificacionDAL.GuardarLote(calificaciones);
        }

        public Dictionary<int, decimal> ObtenerNotas(int idGrado, int idMateria, string periodo)
        {
            if (idGrado <= 0 || idMateria <= 0 || string.IsNullOrWhiteSpace(periodo))
                return new Dictionary<int, decimal>();

            return calificacionDAL.ObtenerNotas(idGrado, idMateria, periodo);
        }

        private static void Validar(Calificacion calificacion)
        {
            if (calificacion == null)
                throw new ArgumentNullException(nameof(calificacion));
            if (calificacion.IdEstudiante <= 0)
                throw new ArgumentException("El estudiante no es válido.");
            if (string.IsNullOrWhiteSpace(calificacion.NombreEstudiante))
                throw new ArgumentException("El nombre del estudiante es obligatorio.");
            if (calificacion.IdGrado <= 0 || string.IsNullOrWhiteSpace(calificacion.NombreGrado))
                throw new ArgumentException("El grado no es válido.");
            if (calificacion.IdMateria <= 0 || string.IsNullOrWhiteSpace(calificacion.NombreMateria))
                throw new ArgumentException("La materia no es válida.");
            if (calificacion.IdDocente <= 0 || string.IsNullOrWhiteSpace(calificacion.NombreDocente))
                throw new ArgumentException("El docente no es válido.");
            if (string.IsNullOrWhiteSpace(calificacion.Periodo))
                throw new ArgumentException("El periodo es obligatorio.");
            if (calificacion.Nota < 0 || calificacion.Nota > 10)
                throw new ArgumentOutOfRangeException(nameof(calificacion.Nota), "La nota debe estar entre 0 y 10.");
        }
    }
}
