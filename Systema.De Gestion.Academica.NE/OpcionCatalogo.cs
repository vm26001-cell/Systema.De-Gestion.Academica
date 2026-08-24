namespace Systema.De_Gestion.Academica.EN
{
    public class OpcionCatalogo
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;

        public override string ToString() => Nombre;
    }
}
