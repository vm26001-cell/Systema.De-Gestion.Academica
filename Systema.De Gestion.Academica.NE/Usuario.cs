namespace Systema.De_Gestion.Academica.EN
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string UsuarioNombre { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
        public string Rol { get; set; } = string.Empty;
        public int? IdEstudiante { get; set; }
    }
}
