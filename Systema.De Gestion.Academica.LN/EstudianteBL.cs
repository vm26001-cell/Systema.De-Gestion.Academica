using System;
using System.Collections.Generic;
using Systema.De_Gestion.Academica.DAL;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.LN
{
    public class EstudianteBL
    {
        private readonly EstudianteDAL estudianteDAL;

        public EstudianteBL()
        {
            estudianteDAL = new EstudianteDAL();
        }

        // =====================================================
        // GUARDAR
        // =====================================================

        public bool Guardar(Estudiante estudiante)
        {
            ValidarEstudiante(estudiante);

            Estudiante existente =
                estudianteDAL.BuscarPorCodigo(estudiante.Codigo);

            if (existente != null)
            {
                throw new Exception(
                    "Ya existe un estudiante con ese código.");
            }

            return estudianteDAL.Insertar(estudiante);
        }

        // =====================================================
        // MODIFICAR
        // =====================================================

        public bool Modificar(Estudiante estudiante)
        {
            ValidarEstudiante(estudiante);

            Estudiante existente =
                estudianteDAL.BuscarPorCodigo(estudiante.Codigo);

            if (existente == null)
            {
                throw new Exception(
                    "No existe un estudiante con ese código.");
            }

            return estudianteDAL.Modificar(estudiante);
        }

        // =====================================================
        // BUSCAR
        // =====================================================

        public Estudiante BuscarPorCodigo(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
            {
                throw new Exception(
                    "Debe ingresar un código.");
            }

            return estudianteDAL.BuscarPorCodigo(codigo);
        }

        // =====================================================
        // BUSCAR VARIOS
        // =====================================================

        public List<Estudiante> Buscar(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                throw new Exception(
                    "Ingrese un código o nombre para buscar.");
            }

            return estudianteDAL.Buscar(texto);
        }

        // =====================================================
        // ELIMINAR
        // =====================================================

        public bool Eliminar(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
            {
                throw new Exception(
                    "Debe ingresar el código del estudiante.");
            }

            return estudianteDAL.Eliminar(codigo);
        }

        // =====================================================
        // VALIDACIONES
        // =====================================================

        private void ValidarEstudiante(Estudiante estudiante)
        {
            if (estudiante == null)
            {
                throw new Exception(
                    "Los datos del estudiante son obligatorios.");
            }

            if (string.IsNullOrWhiteSpace(estudiante.Codigo))
            {
                throw new Exception(
                    "El código es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(estudiante.Nombre))
            {
                throw new Exception(
                    "El nombre es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(estudiante.Apellido))
            {
                throw new Exception(
                    "El apellido es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(estudiante.Grado))
            {
                throw new Exception(
                    "Debe seleccionar el grado.");
            }

            if (string.IsNullOrWhiteSpace(estudiante.Seccion))
            {
                throw new Exception(
                    "Debe seleccionar la sección.");
            }

            if (estudiante.Anio <= 0)
            {
                throw new Exception(
                    "El año académico no es válido.");
            }
        }
    }
}