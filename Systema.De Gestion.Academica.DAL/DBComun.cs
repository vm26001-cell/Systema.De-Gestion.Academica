using Microsoft.Data.SqlClient;

namespace Systema.De_Gestion.Academica.DAL
{
    public class DBComun
    {
        private readonly string cadenaConexion =
            @"Server=M19-CIII;Database=SistemaAcademico;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}