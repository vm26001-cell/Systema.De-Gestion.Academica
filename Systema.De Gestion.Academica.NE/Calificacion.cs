using System;

namespace Systema.De_Gestion.Academica.EN
{
    public class Calificacion
    {
        public int IdCalificacion { get; set; }

        public int IdEstudiante { get; set; }

        public string NombreEstudiante { get; set; }

        public int IdGrado { get; set; }

        public string NombreGrado { get; set; }

        public int IdMateria { get; set; }

        public string NombreMateria { get; set; }

        public int IdDocente { get; set; }

        public string NombreDocente { get; set; }

        public string Periodo { get; set; }

        public decimal Nota { get; set; }
    }
}