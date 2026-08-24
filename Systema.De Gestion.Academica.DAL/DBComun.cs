using Microsoft.Data.SqlClient;
using System.Text.Json;

namespace Systema.De_Gestion.Academica.DAL
{
    public class DBComun
    {
        private static readonly Lazy<string> CadenaConexion =
            new Lazy<string>(CargarCadenaConexion);

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion.Value);
        }

        private static string CargarCadenaConexion()
        {
            string? desdeEntorno = Environment.GetEnvironmentVariable(
                "SISTEMA_ACADEMICO_CONNECTION_STRING");

            if (!string.IsNullOrWhiteSpace(desdeEntorno))
                return desdeEntorno;

            string ruta = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
            if (!File.Exists(ruta))
            {
                throw new InvalidOperationException(
                    "No se encontró appsettings.json. Copie appsettings.example.json " +
                    "como appsettings.json y configure la conexión a SQL Server.");
            }

            using JsonDocument documento = JsonDocument.Parse(File.ReadAllText(ruta));
            if (documento.RootElement.TryGetProperty("ConnectionStrings", out JsonElement conexiones) &&
                conexiones.TryGetProperty("SistemaAcademico", out JsonElement valor) &&
                !string.IsNullOrWhiteSpace(valor.GetString()))
            {
                return valor.GetString()!;
            }

            throw new InvalidOperationException(
                "La conexión 'ConnectionStrings:SistemaAcademico' no está configurada.");
        }
    }
}
