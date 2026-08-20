using System;
using System.Collections.Generic;
using Systema.De_Gestion.Academica.DAL;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.LN
{
    public class MateriaBL
    {
        private readonly MateriaDAL materiaDAL;

        public MateriaBL()
        {
            materiaDAL = new MateriaDAL();
        }

        // =====================================================
        // GUARDAR
        // =====================================================

        public bool Guardar(Materia materia)
        {
            Validar(materia);

            Materia existente =
                materiaDAL.BuscarPorCodigo(
                    materia.Codigo);

            if (existente != null)
            {
                throw new Exception(
                    "Ya existe una materia con ese código.");
            }

            return materiaDAL.Insertar(materia);
        }

        // =====================================================
        // MODIFICAR
        // =====================================================

        public bool Modificar(Materia materia)
        {
            Validar(materia);

            Materia existente =
                materiaDAL.BuscarPorCodigo(
                    materia.Codigo);

            if (existente == null)
            {
                throw new Exception(
                    "No se encontró la materia.");
            }

            return materiaDAL.Modificar(materia);
        }

        // =====================================================
        // ELIMINAR
        // =====================================================

        public bool Eliminar(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
            {
                throw new Exception(
                    "Debe indicar el código de la materia.");
            }

            return materiaDAL.Eliminar(codigo);
        }

        // =====================================================
        // BUSCAR
        // =====================================================

        public List<Materia> Buscar(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return materiaDAL.ObtenerTodas();
            }

            return materiaDAL.Buscar(texto);
        }

        // =====================================================
        // OBTENER TODAS
        // =====================================================

        public List<Materia> ObtenerTodas()
        {
            return materiaDAL.ObtenerTodas();
        }

        // =====================================================
        // VALIDACIONES
        // =====================================================

        private void Validar(Materia materia)
        {
            if (materia == null)
            {
                throw new Exception(
                    "Los datos de la materia son obligatorios.");
            }

            if (string.IsNullOrWhiteSpace(materia.Codigo))
            {
                throw new Exception(
                    "El código es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(materia.Nombre))
            {
                throw new Exception(
                    "El nombre de la materia es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(materia.Grado))
            {
                throw new Exception(
                    "Debe seleccionar un grado.");
            }
        }
    }
}