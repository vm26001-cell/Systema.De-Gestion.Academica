using System.Security.Cryptography;
using System.Text;

namespace Systema.De_Gestion.Academica.LN
{
    public static class PasswordHasher
    {
        private const string Algoritmo = "PBKDF2-SHA256";
        private const int Iteraciones = 100_000;
        private const int TamanoSal = 16;
        private const int TamanoHash = 32;

        public static string CrearHash(string contrasena)
        {
            if (string.IsNullOrWhiteSpace(contrasena))
                throw new ArgumentException("La contraseña es obligatoria.", nameof(contrasena));

            byte[] sal = RandomNumberGenerator.GetBytes(TamanoSal);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                contrasena,
                sal,
                Iteraciones,
                HashAlgorithmName.SHA256,
                TamanoHash);

            return string.Join(
                "$",
                Algoritmo,
                Iteraciones.ToString(System.Globalization.CultureInfo.InvariantCulture),
                Convert.ToBase64String(sal),
                Convert.ToBase64String(hash));
        }

        public static bool EsHashSeguro(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor) &&
                   valor.StartsWith(Algoritmo + "$", StringComparison.Ordinal);
        }

        public static bool Verificar(string contrasena, string valorGuardado)
        {
            if (string.IsNullOrEmpty(contrasena) || string.IsNullOrEmpty(valorGuardado))
                return false;

            if (!EsHashSeguro(valorGuardado))
                return CompararTextoConstante(contrasena, valorGuardado);

            string[] partes = valorGuardado.Split('$');
            if (partes.Length != 4 ||
                !int.TryParse(partes[1], out int iteraciones) ||
                iteraciones < 10_000)
            {
                return false;
            }

            try
            {
                byte[] sal = Convert.FromBase64String(partes[2]);
                byte[] hashEsperado = Convert.FromBase64String(partes[3]);
                byte[] hashCalculado = Rfc2898DeriveBytes.Pbkdf2(
                    contrasena,
                    sal,
                    iteraciones,
                    HashAlgorithmName.SHA256,
                    hashEsperado.Length);

                return CryptographicOperations.FixedTimeEquals(hashCalculado, hashEsperado);
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private static bool CompararTextoConstante(string izquierda, string derecha)
        {
            byte[] a = SHA256.HashData(Encoding.UTF8.GetBytes(izquierda));
            byte[] b = SHA256.HashData(Encoding.UTF8.GetBytes(derecha));
            return CryptographicOperations.FixedTimeEquals(a, b);
        }
    }
}
