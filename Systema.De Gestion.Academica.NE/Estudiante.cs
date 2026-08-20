namespace Systema.De_Gestion.Academica.EN
{
    public class Estudiante
    {
        public int IdEstudiante { get; set; }

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DUI { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Telefono { get; set; }
        public string Correo { get; set; }

        public string Grado { get; set; }
        public string Seccion { get; set; }

        public int Anio { get; set; }
    }
}