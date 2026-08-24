using Systema.De_Gestion.Academica.DAL;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.BL
{
    public class AsistenciaBL
    {
        private static readonly HashSet<string> EstadosValidos =
            new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "Presente", "Ausente", "Tarde", "Justificado"
            };

        private readonly AsistenciaDAL asistenciaDAL = new AsistenciaDAL();

        public bool RegistrarAsistencia(Asistencia asistencia)
        {
            Validar(asistencia);
            return asistenciaDAL.Insertar(asistencia);
        }

        public int RegistrarAsistencias(IReadOnlyCollection<Asistencia> asistencias)
        {
            if (asistencias == null || asistencias.Count == 0)
                throw new ArgumentException("No hay asistencias para guardar.", nameof(asistencias));

            foreach (Asistencia item in asistencias)
                Validar(item);

            return asistenciaDAL.GuardarLote(asistencias);
        }

        public Dictionary<int, string> ObtenerEstados(int idGrado, int idMateria, DateTime fecha)
        {
            if (idGrado <= 0 || idMateria <= 0)
                return new Dictionary<int, string>();

            return asistenciaDAL.ObtenerEstados(idGrado, idMateria, fecha);
        }

        private static void Validar(Asistencia asistencia)
        {
            if (asistencia == null)
                throw new ArgumentNullException(nameof(asistencia));
            if (asistencia.IdEstudiante <= 0)
                throw new ArgumentException("El estudiante no es válido.");
            if (asistencia.IdGrado <= 0)
                throw new ArgumentException("El grado no es válido.");
            if (asistencia.IdMateria <= 0)
                throw new ArgumentException("La materia no es válida.");
            if (asistencia.IdDocente <= 0)
                throw new ArgumentException("El docente no es válido.");
            if (!EstadosValidos.Contains(asistencia.Estado))
                throw new ArgumentException("El estado de asistencia no es válido.");
        }
    }
}
