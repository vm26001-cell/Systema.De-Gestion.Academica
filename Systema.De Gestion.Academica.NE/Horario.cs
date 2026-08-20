using System;

namespace Systema.De_Gestion.Academica.EN
{
    public class Horario
    {
        public int IdHorario { get; set; }

        public string Grado { get; set; }

        public string Dia { get; set; }

        public string Materia { get; set; }

        public string Docente { get; set; }

        public string Aula { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFin { get; set; }
    }
}