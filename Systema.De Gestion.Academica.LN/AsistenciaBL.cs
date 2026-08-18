using System;
using Systema.De_Gestion.Academica.DAL;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.BL
{
    public class AsistenciaBL
    {
        private readonly AsistenciaDAL asistenciaDAL = new AsistenciaDAL();

        public bool RegistrarAsistencia(Asistencia asistencia)
        {
            if (asistencia.IdEstudiante <= 0)
                throw new Exception("Seleccione un estudiante.");

            if (asistencia.IdGrado <= 0)
                throw new Exception("Seleccione un grado.");

            if (asistencia.IdMateria <= 0)
                throw new Exception("Seleccione una materia.");

            if (asistencia.IdDocente <= 0)
                throw new Exception("Seleccione un docente.");

            if (string.IsNullOrWhiteSpace(asistencia.Estado))
                throw new Exception("Seleccione el estado de la asistencia.");


            return asistenciaDAL.Insertar(asistencia);
        }
    }
}