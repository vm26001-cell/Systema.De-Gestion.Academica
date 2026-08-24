# Sistema de Gestión Académica

Aplicación de escritorio desarrollada con C# WinForms, .NET 8 y SQL Server para administrar estudiantes, docentes, materias, horarios, calificaciones, asistencia y reportes académicos.

## Funciones principales

- Inicio de sesión con roles: Administrador, Docente, Padre y Estudiante.
- Contraseñas protegidas con PBKDF2-SHA256 y actualización automática de cuentas antiguas.
- Registro y búsqueda de estudiantes, docentes y materias.
- Gestión de horarios con validación de conflictos.
- Registro de calificaciones y asistencia usando estudiantes reales de la base de datos.
- Guardado por lotes dentro de transacciones: si un registro falla, no quedan datos incompletos.
- Reportes de calificaciones y promedio.
- Acceso restringido según el rol del usuario.

## Arquitectura

| Proyecto | Responsabilidad |
|---|---|
| `Systema.De Gestion.Academica.NE` | Entidades del dominio |
| `Systema.De Gestion.Academica.DAL` | Consultas y conexión con SQL Server |
| `Systema.De Gestion.Academica.LN` | Validaciones y reglas de negocio |
| `WinFormsApp1` | Interfaz gráfica WinForms |
| `Systema.De Gestion.Academica.Tests` | Pruebas automatizadas |

La interfaz no ejecuta SQL directamente. Las solicitudes pasan por la lógica de negocio antes de llegar a la capa de datos.

## Requisitos

- Windows 10 u 11.
- Visual Studio 2022 con la carga de trabajo **Desarrollo de escritorio de .NET**.
- .NET 8 SDK.
- SQL Server 2019 o superior, SQL Server Express o LocalDB.

## Instalación

1. Clone o descargue el repositorio.
2. Abra `database/01_CrearBaseDatos.sql` en SQL Server Management Studio.
3. Ejecute todo el script.
4. Revise `WinFormsApp1/appsettings.json` y cambie el servidor si no utiliza LocalDB.
5. Abra `Systema.De Gestion.Academica.sln` en Visual Studio.
6. Establezca `Systema.De Gestion.Academica.UI` como proyecto de inicio.
7. Compile y ejecute.

También puede establecer la conexión sin modificar archivos mediante la variable de entorno:

```powershell
$env:SISTEMA_ACADEMICO_CONNECTION_STRING = "Server=SERVIDOR;Database=SistemaAcademico;Trusted_Connection=True;TrustServerCertificate=True;"
```

## Acceso inicial

- Usuario: `admin`
- Contraseña: `Admin123*`
- Rol: `Administrador`

Esta cuenta existe únicamente para la instalación inicial. Cambie su contraseña antes de utilizar datos reales.

## Actualizar una instalación anterior

1. Haga una copia de seguridad de `SistemaAcademico`.
2. Ejecute `database/02_MigrarVersionAnterior.sql`.
3. Inicie sesión normalmente.

Las contraseñas antiguas en texto plano se reemplazan automáticamente por un hash PBKDF2 después del primer inicio de sesión correcto.

## Compilar y probar desde terminal

```powershell
dotnet restore "Systema.De Gestion.Academica.sln"
dotnet build "Systema.De Gestion.Academica.sln" --configuration Release
dotnet test "Systema.De Gestion.Academica.Tests/Systema.De Gestion.Academica.Tests.csproj"
```

GitHub Actions ejecuta estos pasos automáticamente en cada cambio enviado a `master` y en cada pull request.

## Roles y permisos

| Módulo | Administrador | Docente | Estudiante | Padre |
|---|:---:|:---:|:---:|:---:|
| Estudiantes, docentes y materias | Sí | No | No | No |
| Registrar calificaciones | Sí | Sí | No | No |
| Registrar asistencia | Sí | Sí | No | No |
| Consultar reportes | Sí | Sí | Propios | Del estudiante vinculado |
| Consultar horarios | Sí | Sí | Sí | Sí |

Para limitar reportes de estudiantes y padres, vincule la cuenta con `Usuario.id_estudiante`.

## Buenas prácticas incluidas

- Consultas SQL parametrizadas.
- Conexiones, comandos y lectores cerrados mediante `using`.
- Cadena de conexión fuera del código fuente.
- Contraseñas sin comparación directa en SQL.
- Restricciones, claves foráneas e índices únicos en la base de datos.
- IDs reales tomados de SQL Server; no se calculan con `SelectedIndex + 1`.
- Dependencias NuGet mínimas.
- Pruebas de seguridad para el sistema de contraseñas.

## Equipo

Proyecto académico desarrollado para la Escuela Superior Franciscana Especializada – AGAPE.
