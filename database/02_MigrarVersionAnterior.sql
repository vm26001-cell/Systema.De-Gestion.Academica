USE SistemaAcademico;
GO

IF OBJECT_ID(N'dbo.Rol', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Rol
    (
        id_rol INT NOT NULL CONSTRAINT PK_Rol PRIMARY KEY,
        nombre NVARCHAR(30) NOT NULL CONSTRAINT UQ_Rol_Nombre UNIQUE
    );
END;
GO

MERGE dbo.Rol AS destino
USING (VALUES
    (1, N'Administrador'), (2, N'Docente'),
    (3, N'Padre'), (4, N'Estudiante')) AS origen(id_rol, nombre)
ON destino.id_rol = origen.id_rol
WHEN MATCHED THEN UPDATE SET nombre = origen.nombre
WHEN NOT MATCHED THEN INSERT (id_rol, nombre) VALUES (origen.id_rol, origen.nombre);
GO

IF COL_LENGTH(N'dbo.Usuario', N'id_estudiante') IS NULL
    ALTER TABLE dbo.Usuario ADD id_estudiante INT NULL;
GO

IF COL_LENGTH(N'dbo.Usuario', N'password') IS NOT NULL
    ALTER TABLE dbo.Usuario ALTER COLUMN [password] NVARCHAR(300) NOT NULL;
GO

IF OBJECT_ID(N'dbo.GradoAcademico', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.GradoAcademico
    (
        id_grado INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_GradoAcademico PRIMARY KEY,
        nombre NVARCHAR(60) NOT NULL CONSTRAINT UQ_GradoAcademico_Nombre UNIQUE,
        orden INT NOT NULL,
        activo BIT NOT NULL CONSTRAINT DF_GradoAcademico_Activo DEFAULT (1)
    );
END;
GO

MERGE dbo.GradoAcademico AS destino
USING (VALUES
    (N'1° A', 1), (N'1° B', 2), (N'1° C', 3),
    (N'2° A', 4), (N'2° B', 5), (N'2° C', 6),
    (N'3° A', 7), (N'3° B', 8), (N'3° C', 9),
    (N'4° A', 10), (N'5° A', 11), (N'6° A', 12),
    (N'7° A', 13), (N'8° A', 14), (N'9° A', 15),
    (N'1° Bachillerato A', 16), (N'2° Bachillerato A', 17)
) AS origen(nombre, orden)
ON destino.nombre = origen.nombre
WHEN MATCHED THEN UPDATE SET orden = origen.orden, activo = 1
WHEN NOT MATCHED THEN INSERT (nombre, orden, activo) VALUES (origen.nombre, origen.orden, 1);
GO

PRINT N'Migración preparada. Las contraseñas antiguas se convertirán a PBKDF2 en el siguiente inicio de sesión válido.';
GO
