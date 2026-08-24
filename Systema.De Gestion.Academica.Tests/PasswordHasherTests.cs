using Systema.De_Gestion.Academica.LN;
using Xunit;

namespace Systema.De_Gestion.Academica.Tests;

public class PasswordHasherTests
{
    [Fact]
    public void CrearHash_NoGuardaLaContrasenaEnTextoPlano()
    {
        const string contrasena = "ClaveSegura123*";
        string hash = PasswordHasher.CrearHash(contrasena);

        Assert.NotEqual(contrasena, hash);
        Assert.True(PasswordHasher.EsHashSeguro(hash));
    }

    [Fact]
    public void Verificar_AceptaLaContrasenaCorrecta()
    {
        const string contrasena = "ClaveSegura123*";
        string hash = PasswordHasher.CrearHash(contrasena);

        Assert.True(PasswordHasher.Verificar(contrasena, hash));
        Assert.False(PasswordHasher.Verificar("Incorrecta", hash));
    }

    [Fact]
    public void Verificar_RechazaUnHashMalFormado()
    {
        Assert.False(PasswordHasher.Verificar("clave", "PBKDF2-SHA256$abc$invalido$invalido"));
    }
}
