using System.Collections.Generic;
using Systema.De_Gestion.Academica.DAL;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.BL
{
    public class DocenteBL
    {
        private readonly DocenteDAL docenteDAL;

        public DocenteBL()
        {
            docenteDAL = new DocenteDAL();
        }

        public bool Insertar(Docente docente)
        {
            return docenteDAL.Insertar(docente);
        }

        public List<Docente> Buscar(string texto)
        {
            return docenteDAL.Buscar(texto);
        }

        public bool Modificar(Docente docente)
        {
            return docenteDAL.Modificar(docente);
        }
    }
}