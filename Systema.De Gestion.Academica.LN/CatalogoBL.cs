using Systema.De_Gestion.Academica.DAL;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.LN
{
    public class CatalogoBL
    {
        private readonly CatalogoDAL catalogoDAL = new CatalogoDAL();

        public List<OpcionCatalogo> ObtenerGrados() => catalogoDAL.ObtenerGrados();
        public List<OpcionCatalogo> ObtenerMaterias() => catalogoDAL.ObtenerMaterias();
        public List<OpcionCatalogo> ObtenerDocentes() => catalogoDAL.ObtenerDocentes();

        public List<Estudiante> ObtenerEstudiantesPorGrado(int idGrado)
        {
            if (idGrado <= 0)
                throw new ArgumentException("El grado no es válido.", nameof(idGrado));

            return catalogoDAL.ObtenerEstudiantesPorGrado(idGrado);
        }

        public Estudiante? ObtenerEstudiantePorId(int idEstudiante)
        {
            if (idEstudiante <= 0)
                return null;

            return catalogoDAL.ObtenerEstudiantePorId(idEstudiante);
        }
    }
}
