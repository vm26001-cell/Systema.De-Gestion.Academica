using Systema.De_Gestion.Academica.DAL;
using Systema.De_Gestion.Academica.EN;

namespace Systema.De_Gestion.Academica.LN
{
    public class LoginBL
    {
        private readonly LoginDAL loginDAL;

        public LoginBL()
        {
            loginDAL = new LoginDAL();
        }

        public Usuario ValidarLogin(
            string usuario,
            string contrasena,
            string rol)
        {
            if (string.IsNullOrWhiteSpace(usuario))
                return null;

            if (string.IsNullOrWhiteSpace(contrasena))
                return null;

            if (string.IsNullOrWhiteSpace(rol))
                return null;

            return loginDAL.ValidarLogin(
                usuario,
                contrasena,
                rol);
        }
    }
}