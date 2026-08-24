USE master;
GO

IF DB_ID(N'SistemaAcademico') IS NULL
    CREATE DATABASE SistemaAcademico;
GO

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
    (1, N'Administrador'),
    (2, N'Docente'),
    (3, N'Padre'),
    (4, N'Estudiante')) AS origen(id_rol, nombre)
ON destino.id_rol = origen.id_rol
WHEN MATCHED THEN UPDATE SET nombre = origen.nombre
WHEN NOT MATCHED THEN INSERT (id_rol, nombre) VALUES (origen.id_rol, origen.nombre);
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

IF OBJECT_ID(N'dbo.Estudiante', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Estudiante
    (
        IdEstudiante INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Estudiante PRIMARY KEY,
        Codigo NVARCHAR(20) NOT NULL CONSTRAINT UQ_Estudiante_Codigo UNIQUE,
        Nombre NVARCHAR(60) NOT NULL,
        Apellido NVARCHAR(60) NOT NULL,
        DUI NVARCHAR(10) NULL,
        FechaNacimiento DATE NOT NULL,
        Telefono NVARCHAR(20) NULL,
        Correo NVARCHAR(120) NULL,
        Grado NVARCHAR(40) NOT NULL,
        Seccion NVARCHAR(10) NOT NULL,
        Anio INT NOT NULL,
        CONSTRAINT CK_Estudiante_Anio CHECK (Anio BETWEEN 2000 AND 2100)
    );

    CREATE UNIQUE INDEX UX_Estudiante_DUI
        ON dbo.Estudiante(DUI)
        WHERE DUI IS NOT NULL;
END;
GO

IF OBJECT_ID(N'dbo.Usuario', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Usuario
    (
        id_usuario INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Usuario PRIMARY KEY,
        nombre_usuario NVARCHAR(50) NOT NULL CONSTRAINT UQ_Usuario_Nombre UNIQUE,
        [password] NVARCHAR(300) NOT NULL,
        estado NVARCHAR(10) NOT NULL CONSTRAINT DF_Usuario_Estado DEFAULT (N'Activo'),
        id_rol INT NOT NULL,
        id_estudiante INT NULL,
        CONSTRAINT FK_Usuario_Rol FOREIGN KEY (id_rol) REFERENCES dbo.Rol(id_rol),
        CONSTRAINT FK_Usuario_Estudiante FOREIGN KEY (id_estudiante) REFERENCES dbo.Estudiante(IdEstudiante),
        CONSTRAINT CK_Usuario_Estado CHECK (estado IN (N'Activo', N'Inactivo'))
    );
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Usuario WHERE nombre_usuario = N'admin')
BEGIN
    INSERT dbo.Usuario(nombre_usuario, [password], estado, id_rol, id_estudiante)
    VALUES
    (
        N'admin',
        N'PBKDF2-SHA256$100000$AQIDBAUGBwgJCgsMDQ4PEA==$4Py5dZzgjy6/E650wxH0Dn/U6JDJ9lu1BMJqh316uFI=',
        N'Activo',
        1,
        NULL
    );
END;
GO

IF OBJECT_ID(N'dbo.Docente', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Docente
    (
        id_docente INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Docente PRIMARY KEY,
        codigo NVARCHAR(20) NOT NULL CONSTRAINT UQ_Docente_Codigo UNIQUE,
        nombre NVARCHAR(60) NOT NULL,
        apellido NVARCHAR(60) NOT NULL,
        dui NVARCHAR(10) NOT NULL CONSTRAINT UQ_Docente_DUI UNIQUE,
        telefono NVARCHAR(20) NULL,
        correo NVARCHAR(120) NULL,
        especialidad NVARCHAR(100) NOT NULL,
        materia NVARCHAR(100) NULL
    );
END;
GO

IF OBJECT_ID(N'dbo.Materia', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Materia
    (
        IdMateria INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Materia PRIMARY KEY,
        Codigo NVARCHAR(20) NOT NULL CONSTRAINT UQ_Materia_Codigo UNIQUE,
        Nombre NVARCHAR(100) NOT NULL,
        Descripcion NVARCHAR(300) NULL,
        Grado NVARCHAR(60) NOT NULL,
        Docente NVARCHAR(120) NULL
    );
END;
GO

IF OBJECT_ID(N'dbo.Horario', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Horario
    (
        IdHorario INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Horario PRIMARY KEY,
        Grado NVARCHAR(60) NOT NULL,
        Dia NVARCHAR(15) NOT NULL,
        Materia NVARCHAR(100) NOT NULL,
        Docente NVARCHAR(120) NOT NULL,
        Aula NVARCHAR(40) NOT NULL,
        HoraInicio TIME(0) NOT NULL,
        HoraFin TIME(0) NOT NULL,
        CONSTRAINT CK_Horario_Horas CHECK (HoraInicio < HoraFin),
        CONSTRAINT CK_Horario_Dia CHECK (Dia IN
            (N'Lunes', N'Martes', N'Miércoles', N'Jueves', N'Viernes'))
    );
END;
GO

IF OBJECT_ID(N'dbo.Calificacion', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Calificacion
    (
        id_calificacion INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Calificacion PRIMARY KEY,
        id_estudiante INT NOT NULL,
        nombre_estudiante NVARCHAR(120) NOT NULL,
        id_grado INT NOT NULL,
        nombre_grado NVARCHAR(60) NOT NULL,
        id_materia INT NOT NULL,
        nombre_materia NVARCHAR(100) NOT NULL,
        id_docente INT NOT NULL,
        nombre_docente NVARCHAR(120) NOT NULL,
        periodo NVARCHAR(50) NOT NULL,
        nota DECIMAL(4,2) NOT NULL,
        CONSTRAINT FK_Calificacion_Estudiante FOREIGN KEY (id_estudiante) REFERENCES dbo.Estudiante(IdEstudiante),
        CONSTRAINT FK_Calificacion_Grado FOREIGN KEY (id_grado) REFERENCES dbo.GradoAcademico(id_grado),
        CONSTRAINT FK_Calificacion_Materia FOREIGN KEY (id_materia) REFERENCES dbo.Materia(IdMateria),
        CONSTRAINT FK_Calificacion_Docente FOREIGN KEY (id_docente) REFERENCES dbo.Docente(id_docente),
        CONSTRAINT CK_Calificacion_Nota CHECK (nota BETWEEN 0 AND 10),
        CONSTRAINT UQ_Calificacion UNIQUE (id_estudiante, id_grado, id_materia, periodo)
    );
END;
GO

IF OBJECT_ID(N'dbo.Asistencia', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Asistencia
    (
        id_asistencia INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Asistencia PRIMARY KEY,
        id_estudiante INT NOT NULL,
        nombre_estudiante NVARCHAR(120) NOT NULL,
        id_grado INT NOT NULL,
        nombre_grado NVARCHAR(60) NOT NULL,
        id_materia INT NOT NULL,
        nombre_materia NVARCHAR(100) NOT NULL,
        id_docente INT NOT NULL,
        nombre_docente NVARCHAR(120) NOT NULL,
        fecha DATE NOT NULL,
        estado NVARCHAR(20) NOT NULL,
        CONSTRAINT FK_Asistencia_Estudiante FOREIGN KEY (id_estudiante) REFERENCES dbo.Estudiante(IdEstudiante),
        CONSTRAINT FK_Asistencia_Grado FOREIGN KEY (id_grado) REFERENCES dbo.GradoAcademico(id_grado),
        CONSTRAINT FK_Asistencia_Materia FOREIGN KEY (id_materia) REFERENCES dbo.Materia(IdMateria),
        CONSTRAINT FK_Asistencia_Docente FOREIGN KEY (id_docente) REFERENCES dbo.Docente(id_docente),
        CONSTRAINT CK_Asistencia_Estado CHECK (estado IN
            (N'Presente', N'Ausente', N'Tarde', N'Justificado')),
        CONSTRAINT UQ_Asistencia UNIQUE (id_estudiante, id_materia, fecha)
    );
END;
GO

PRINT N'Base de datos SistemaAcademico instalada correctamente.';
GO
