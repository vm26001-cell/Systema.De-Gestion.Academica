# Seguridad

## Información sensible

No publique contraseñas reales ni cadenas de conexión con usuarios y claves dentro del repositorio. Utilice `WinFormsApp1/appsettings.json` solamente con autenticación integrada o configure la variable `SISTEMA_ACADEMICO_CONNECTION_STRING` en el equipo donde se ejecuta la aplicación.

## Contraseñas

La aplicación utiliza PBKDF2-SHA256 con sal aleatoria, 100 000 iteraciones y comparación en tiempo constante. Las instalaciones anteriores que todavía tengan contraseñas en texto plano las actualizan automáticamente después del primer inicio de sesión válido.

## Cuenta inicial

La contraseña `Admin123*` es exclusivamente para una instalación nueva de demostración. Debe cambiarse antes de ingresar información real.

## Reportar un problema

No publique credenciales ni datos personales en un issue. Describa el módulo afectado, la versión y los pasos necesarios para reproducir el problema sin incluir información privada de estudiantes o docentes.
