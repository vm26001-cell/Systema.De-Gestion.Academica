using System;
using Systema.De_Gestion.Academica.DAL;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.BL
{
    public class CalificacionBL
    {
        private readonly CalificacionDAL calificacionDAL;

        public CalificacionBL()
        {
            calificacionDAL = new CalificacionDAL();
        }

        // =====================================================
        // REGISTRAR CALIFICACIÓN
        // =====================================================

        public bool RegistrarCalificacion(
            Calificacion calificacion)
        {
            if (calificacion == null)
            {
                throw new Exception(
                    "Los datos de la calificación son obligatorios.");
            }

            if (calificacion.IdEstudiante <= 0)
            {
                throw new Exception(
                    "El estudiante no es válido.");
            }

            if (string.IsNullOrWhiteSpace(
                calificacion.NombreEstudiante))
            {
                throw new Exception(
                    "El nombre del estudiante es obligatorio.");
            }

            if (calificacion.IdGrado <= 0)
            {
                throw new Exception(
                    "El grado no es válido.");
            }

            if (string.IsNullOrWhiteSpace(
                calificacion.NombreGrado))
            {
                throw new Exception(
                    "El grado es obligatorio.");
            }

            if (calificacion.IdMateria <= 0)
            {
                throw new Exception(
                    "La materia no es válida.");
            }

            if (string.IsNullOrWhiteSpace(
                calificacion.NombreMateria))
            {
                throw new Exception(
                    "La materia es obligatoria.");
            }

            if (calificacion.IdDocente <= 0)
            {
                throw new Exception(
                    "El docente no es válido.");
            }

            if (string.IsNullOrWhiteSpace(
                calificacion.NombreDocente))
            {
                throw new Exception(
                    "El docente es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(
                calificacion.Periodo))
            {
                throw new Exception(
                    "El periodo es obligatorio.");
            }

            // =========================================
            // VALIDAR NOTA
            // =========================================

            if (calificacion.Nota < 0 ||
                calificacion.Nota > 10)
            {
                throw new Exception(
                    "La nota debe estar entre 0 y 10.");
            }

            return calificacionDAL.Insertar(
                calificacion);
        }
    }
}