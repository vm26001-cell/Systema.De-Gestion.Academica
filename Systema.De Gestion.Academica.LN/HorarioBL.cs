using System;
using System.Collections.Generic;
using Systema.De_Gestion.Academica.DAL;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.LN
{
    public class HorarioBL
    {
        private readonly HorarioDAL horarioDAL;

        public HorarioBL()
        {
            horarioDAL = new HorarioDAL();
        }

        // =====================================================
        // GUARDAR
        // =====================================================

        public bool Guardar(Horario horario)
        {
            ValidarHorario(horario);

            if (horarioDAL.ExisteConflicto(horario))
            {
                throw new Exception(
                    "Existe un conflicto de horario para ese grado, día y hora.");
            }

            return horarioDAL.Insertar(horario);
        }

        // =====================================================
        // MODIFICAR
        // =====================================================

        public bool Modificar(Horario horario)
        {
            ValidarHorario(horario);

            return horarioDAL.Modificar(horario);
        }

        // =====================================================
        // ELIMINAR
        // =====================================================

        public bool Eliminar(int idHorario)
        {
            if (idHorario <= 0)
            {
                throw new Exception(
                    "El horario seleccionado no es válido.");
            }

            return horarioDAL.Eliminar(idHorario);
        }

        // =====================================================
        // OBTENER TODOS
        // =====================================================

        public List<Horario> ObtenerTodos()
        {
            return horarioDAL.ObtenerTodos();
        }

        // =====================================================
        // BUSCAR POR GRADO Y DÍA
        // =====================================================

        public List<Horario> BuscarPorGradoDia(
            string grado,
            string dia)
        {
            if (string.IsNullOrWhiteSpace(grado))
            {
                throw new Exception(
                    "Debe seleccionar un grado.");
            }

            if (string.IsNullOrWhiteSpace(dia))
            {
                throw new Exception(
                    "Debe seleccionar un día.");
            }

            return horarioDAL.BuscarPorGradoDia(
                grado,
                dia);
        }

        // =====================================================
        // VALIDACIONES
        // =====================================================

        private void ValidarHorario(Horario horario)
        {
            if (horario == null)
            {
                throw new Exception(
                    "Los datos del horario son obligatorios.");
            }

            if (string.IsNullOrWhiteSpace(horario.Grado))
            {
                throw new Exception(
                    "Debe seleccionar el grado.");
            }

            if (string.IsNullOrWhiteSpace(horario.Dia))
            {
                throw new Exception(
                    "Debe seleccionar el día.");
            }

            if (string.IsNullOrWhiteSpace(horario.Materia))
            {
                throw new Exception(
                    "Debe seleccionar la materia.");
            }

            if (string.IsNullOrWhiteSpace(horario.Docente))
            {
                throw new Exception(
                    "Debe seleccionar el docente.");
            }

            if (string.IsNullOrWhiteSpace(horario.Aula))
            {
                throw new Exception(
                    "Debe seleccionar el aula.");
            }

            if (horario.HoraInicio >= horario.HoraFin)
            {
                throw new Exception(
                    "La hora de inicio debe ser menor que la hora de fin.");
            }
        }
    }
}