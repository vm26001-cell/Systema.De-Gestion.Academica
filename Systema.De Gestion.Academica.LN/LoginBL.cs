using Systema.De_Gestion.Academica.DAL;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.LN
{
    public class LoginBL
    {
        private readonly LoginDAL loginDAL = new LoginDAL();

        public Usuario? ValidarLogin(string usuario, string contrasena, string rol)
        {
            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(contrasena) ||
                string.IsNullOrWhiteSpace(rol))
            {
                return null;
            }

            Usuario? encontrado = loginDAL.BuscarUsuarioActivo(usuario, rol);
            if (encontrado == null ||
                !PasswordHasher.Verificar(contrasena, encontrado.Contrasena))
            {
                return null;
            }

            // Compatibilidad segura: las cuentas antiguas en texto plano se
            // convierten automáticamente a PBKDF2 después del primer acceso válido.
            if (!PasswordHasher.EsHashSeguro(encontrado.Contrasena))
            {
                string nuevoHash = PasswordHasher.CrearHash(contrasena);
                loginDAL.ActualizarContrasena(encontrado.IdUsuario, nuevoHash);
                encontrado.Contrasena = string.Empty;
            }

            return encontrado;
        }
    }
}
