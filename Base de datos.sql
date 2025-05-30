CREATE DATABASE GymDB;
GO

USE GymDB;
GO

-- Tabla Miembros (agregué el campo Rol para diferenciar Administrador y Miembro, y Activo para "borrado" lógico)
CREATE TABLE Miembros (
   UsuarioID INT IDENTITY(1,1) PRIMARY KEY,
   Nombre NVARCHAR(100) NOT NULL,
   Email NVARCHAR(200) NOT NULL,
   Telefono NVARCHAR(50) NULL,
   TipoMembresia NVARCHAR(50) NOT NULL,
   FechaVencimientoMembresia DATETIME NOT NULL,
   Rol NVARCHAR(50) NOT NULL,  -- Ejemplo: 'Administrador' o 'Miembro'
   Activo BIT NOT NULL DEFAULT 1
);
GO

-- Tabla Entrenadores
CREATE TABLE Entrenadores (
   EntrenadorID INT IDENTITY(1,1) PRIMARY KEY,
   Nombre NVARCHAR(100) NOT NULL,
   Especialidad NVARCHAR(100) NOT NULL,
   Disponibilidad NVARCHAR(100) NOT NULL
);
GO

-- Tabla Clases
CREATE TABLE Clases (
   ClaseID INT IDENTITY(1,1) PRIMARY KEY,
   NombreClase NVARCHAR(100) NOT NULL,
   Horario DATETIME NOT NULL,
   Duracion INT NOT NULL,
   CapacidadMaxima INT NOT NULL,
   EntrenadorID INT NOT NULL,
   CONSTRAINT FK_Clases_Entrenadores FOREIGN KEY (EntrenadorID) REFERENCES Entrenadores(EntrenadorID)
);
GO

-- Tabla Reservas
CREATE TABLE Reservas (
   ReservaID INT IDENTITY(1,1) PRIMARY KEY,
   UsuarioID INT NOT NULL,
   ClaseID INT NOT NULL,
   FechaReserva DATETIME NOT NULL,
   Estado NVARCHAR(20) NOT NULL CHECK (Estado IN ('Activa', 'Cancelada')),
   FechaCancelacion DATETIME NULL,
   CONSTRAINT FK_Reservas_Miembros FOREIGN KEY (UsuarioID) REFERENCES Miembros(UsuarioID),
   CONSTRAINT FK_Reservas_Clases FOREIGN KEY (ClaseID) REFERENCES Clases(ClaseID)
);
GO

-- Tabla Acceso
CREATE TABLE Acceso (
   AccesoID INT IDENTITY(1,1) PRIMARY KEY,
   UsuarioID INT NOT NULL,
   FechaAcceso DATETIME NOT NULL,
   ClaseID INT NOT NULL,
   EstadoAcceso NVARCHAR(20) NOT NULL CHECK (EstadoAcceso IN ('Permitido', 'Denegado')),
   CONSTRAINT FK_Acceso_Miembros FOREIGN KEY (UsuarioID) REFERENCES Miembros(UsuarioID),
   CONSTRAINT FK_Acceso_Clases FOREIGN KEY (ClaseID) REFERENCES Clases(ClaseID)
);
GO

-- Crear Miembro
CREATE PROCEDURE SP_CrearMiembro 
    @Nombre NVARCHAR(100),
    @Email NVARCHAR(200),
    @Telefono NVARCHAR(50),
    @TipoMembresia NVARCHAR(50),
    @FechaVencimientoMembresia DATETIME,
    @Rol NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Miembros (Nombre, Email, Telefono, TipoMembresia, FechaVencimientoMembresia, Rol, Activo)
    VALUES (@Nombre, @Email, @Telefono, @TipoMembresia, @FechaVencimientoMembresia, @Rol, 1);
    SELECT SCOPE_IDENTITY() AS NuevoMiembroID;
END
GO

-- Actualizar Miembro
CREATE PROCEDURE SP_ActualizarMiembro
    @UsuarioID INT,
    @Nombre NVARCHAR(100),
    @Email NVARCHAR(200),
    @Telefono NVARCHAR(50),
    @TipoMembresia NVARCHAR(50),
    @FechaVencimientoMembresia DATETIME,
    @Rol NVARCHAR(50),
    @Activo BIT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Miembros
    SET Nombre = @Nombre,
        Email = @Email,
        Telefono = @Telefono,
        TipoMembresia = @TipoMembresia,
        FechaVencimientoMembresia = @FechaVencimientoMembresia,
        Rol = @Rol,
        Activo = @Activo
    WHERE UsuarioID = @UsuarioID;
    SELECT @UsuarioID AS MiembroActualizado;
END
GO

-- Eliminar Miembro (actualiza el campo Activo a 0)
CREATE PROCEDURE SP_EliminarMiembro
    @UsuarioID INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Miembros SET Activo = 0 WHERE UsuarioID = @UsuarioID;
    SELECT @UsuarioID AS MiembroEliminado;
END
GO

-- Renovar Membresía
CREATE PROCEDURE SP_RenovarMembresia
    @UsuarioID INT,
    @NuevaFechaVencimiento DATETIME
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Miembros
    SET FechaVencimientoMembresia = @NuevaFechaVencimiento
    WHERE UsuarioID = @UsuarioID;
    SELECT @UsuarioID AS MiembroRenovado;
END
GO

CREATE PROCEDURE SP_CrearEntrenador
    @Nombre NVARCHAR(100),
    @Especialidad NVARCHAR(100),
    @Disponibilidad NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Entrenadores (Nombre, Especialidad, Disponibilidad)
    VALUES (@Nombre, @Especialidad, @Disponibilidad);
    SELECT SCOPE_IDENTITY() AS NuevoEntrenadorID;
END
GO

CREATE PROCEDURE SP_ActualizarEntrenador
    @EntrenadorID INT,
    @Nombre NVARCHAR(100),
    @Especialidad NVARCHAR(100),
    @Disponibilidad NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Entrenadores
    SET Nombre = @Nombre,
        Especialidad = @Especialidad,
        Disponibilidad = @Disponibilidad
    WHERE EntrenadorID = @EntrenadorID;
    SELECT @EntrenadorID AS EntrenadorActualizado;
END
GO

CREATE PROCEDURE SP_EliminarEntrenador
    @EntrenadorID INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Entrenadores 
    WHERE EntrenadorID = @EntrenadorID;
    SELECT @EntrenadorID AS EntrenadorEliminado;
END
GO

CREATE PROCEDURE SP_CrearClase
    @NombreClase NVARCHAR(100),
    @Horario DATETIME,
    @Duracion INT,
    @CapacidadMaxima INT,
    @EntrenadorID INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Clases (NombreClase, Horario, Duracion, CapacidadMaxima, EntrenadorID)
    VALUES (@NombreClase, @Horario, @Duracion, @CapacidadMaxima, @EntrenadorID);
    SELECT SCOPE_IDENTITY() AS NuevaClaseID;
END
GO

CREATE PROCEDURE SP_ActualizarClase
    @ClaseID INT,
    @NombreClase NVARCHAR(100),
    @Horario DATETIME,
    @Duracion INT,
    @CapacidadMaxima INT,
    @EntrenadorID INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Clases
    SET NombreClase = @NombreClase,
        Horario = @Horario,
        Duracion = @Duracion,
        CapacidadMaxima = @CapacidadMaxima,
        EntrenadorID = @EntrenadorID
    WHERE ClaseID = @ClaseID;
    SELECT @ClaseID AS ClaseActualizada;
END
GO

CREATE PROCEDURE SP_EliminarClase
    @ClaseID INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Clases
    WHERE ClaseID = @ClaseID;
    SELECT @ClaseID AS ClaseEliminada;
END
GO

-- Registrar Reserva: Valida membresía, cupos y crea la reserva
CREATE PROCEDURE SP_RegistrarReserva
    @UsuarioID INT,
    @ClaseID INT,
    @FechaReserva DATETIME
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @FechaVencimiento DATETIME,
            @CapacidadMaxima INT,
            @ReservasActivas INT;
    
    SELECT @FechaVencimiento = FechaVencimientoMembresia
      FROM Miembros
     WHERE UsuarioID = @UsuarioID AND Activo = 1;
    
    IF @FechaVencimiento IS NULL
    BEGIN
        RAISERROR('Usuario no encontrado o inactivo.', 16, 1);
        RETURN;
    END;
    
    IF @FechaVencimiento < GETDATE()
    BEGIN
         RAISERROR('Membresía expirada.', 16, 1);
         RETURN;
    END;
    
    SELECT @CapacidadMaxima = CapacidadMaxima
      FROM Clases
     WHERE ClaseID = @ClaseID;
    
    IF @CapacidadMaxima IS NULL
    BEGIN
         RAISERROR('Clase no encontrada.', 16, 1);
         RETURN;
    END;
    
    SELECT @ReservasActivas = COUNT(*)
      FROM Reservas
     WHERE ClaseID = @ClaseID AND Estado = 'Activa';
    
    IF @ReservasActivas >= @CapacidadMaxima
    BEGIN
         RAISERROR('No hay cupos disponibles para esta clase.', 16, 1);
         RETURN;
    END;
    
    INSERT INTO Reservas (UsuarioID, ClaseID, FechaReserva, Estado)
    VALUES (@UsuarioID, @ClaseID, @FechaReserva, 'Activa');
    
    SELECT SCOPE_IDENTITY() AS NuevaReservaID;
END
GO

-- Cancelar Reserva: Solo se permite cancelación con más de 24 horas de diferencia
CREATE PROCEDURE SP_CancelarReserva
    @ReservaID INT
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @FechaReserva DATETIME;
    
    SELECT @FechaReserva = FechaReserva
      FROM Reservas
     WHERE ReservaID = @ReservaID AND Estado = 'Activa';
    
    IF @FechaReserva IS NULL
    BEGIN
       RAISERROR('Reserva no encontrada o ya cancelada.', 16, 1);
       RETURN;
    END;
    
    IF DATEDIFF(HOUR, GETDATE(), @FechaReserva) < 24
    BEGIN
       RAISERROR('Cancelación no permitida: debe realizarse con más de 24 horas de antelación.', 16, 1);
       RETURN;
    END;    
    
    UPDATE Reservas
       SET Estado = 'Cancelada', FechaCancelacion = GETDATE()
     WHERE ReservaID = @ReservaID;
    
    SELECT @ReservaID AS ReservaCancelada;
END
GO

-- Verificar Acceso: Comprueba membresía vigente y existencia de reserva activa
CREATE PROCEDURE SP_VerificarAcceso
    @UsuarioID INT,
    @ClaseID INT
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @FechaVencimiento DATETIME;
    SELECT @FechaVencimiento = FechaVencimientoMembresia 
      FROM Miembros 
     WHERE UsuarioID = @UsuarioID AND Activo = 1;
    
    IF @FechaVencimiento IS NULL OR @FechaVencimiento < GETDATE()
    BEGIN
         SELECT 'Denegado' AS Acceso;
         RETURN;
    END;
    
    IF EXISTS (
        SELECT 1 
          FROM Reservas 
         WHERE UsuarioID = @UsuarioID 
           AND ClaseID = @ClaseID 
           AND Estado = 'Activa'
    )
         SELECT 'Permitido' AS Acceso;
    ELSE
         SELECT 'Denegado' AS Acceso;
END
GO

-- Insertar Registro de Acceso
CREATE PROCEDURE SP_InsertarAcceso
    @UsuarioID INT,
    @ClaseID INT,
    @EstadoAcceso NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Acceso (UsuarioID, FechaAcceso, ClaseID, EstadoAcceso)
    VALUES (@UsuarioID, GETDATE(), @ClaseID, @EstadoAcceso);
    SELECT SCOPE_IDENTITY() AS NuevoAccesoID;
END
GO

-- Reporte de Asistencia: Agrupa accesos permitidos por clase y usuario en un rango de fechas
CREATE PROCEDURE SP_GenerarReporteAsistencia
    @FechaInicio DATETIME,
    @FechaFin DATETIME
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
       a.ClaseID,
       c.NombreClase,
       a.UsuarioID,
       m.Nombre AS NombreMiembro,
       COUNT(*) AS TotalAccesos
    FROM Acceso a
    INNER JOIN Clases c ON a.ClaseID = c.ClaseID
    INNER JOIN Miembros m ON a.UsuarioID = m.UsuarioID
    WHERE a.FechaAcceso BETWEEN @FechaInicio AND @FechaFin
      AND a.EstadoAcceso = 'Permitido'
    GROUP BY a.ClaseID, c.NombreClase, a.UsuarioID, m.Nombre
    ORDER BY c.NombreClase, m.Nombre;
END
GO

-- Notificaciones: Selecciona reservas activas dentro de las próximas 24 horas para enviar recordatorios
CREATE PROCEDURE SP_NotificarReservasPendientes
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT
      r.ReservaID,
      r.UsuarioID,
      m.Nombre,
      m.Email,
      r.ClaseID,
      c.NombreClase,
      r.FechaReserva
    FROM Reservas r
    INNER JOIN Miembros m ON r.UsuarioID = m.UsuarioID
    INNER JOIN Clases c ON r.ClaseID = c.ClaseID
    WHERE r.Estado = 'Activa'
      AND r.FechaReserva BETWEEN GETDATE() AND DATEADD(HOUR, 24, GETDATE());
END
GO

-- Consultar Reservas por Usuario
CREATE PROCEDURE SP_ConsultarReservasPorUsuario
    @UsuarioID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM Reservas WHERE UsuarioID = @UsuarioID;
END
GO

ALTER TABLE Miembros
ADD Password NVARCHAR(100) NOT NULL DEFAULT('');
GO

ALTER PROCEDURE SP_CrearMiembro 
    @Nombre NVARCHAR(100),
    @Email NVARCHAR(200),
    @Telefono NVARCHAR(50),
    @TipoMembresia NVARCHAR(50),
    @FechaVencimientoMembresia DATETIME,
    @Rol NVARCHAR(50),
    @Password NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO Miembros 
       (Nombre, Email, Telefono, TipoMembresia, FechaVencimientoMembresia, Rol, Activo, Password)
    VALUES 
       (@Nombre, @Email, @Telefono, @TipoMembresia, @FechaVencimientoMembresia, @Rol, 1, @Password);
    
    SELECT SCOPE_IDENTITY() AS NuevoMiembroID;
END
GO

ALTER PROCEDURE SP_ActualizarMiembro
    @UsuarioID INT,
    @Nombre NVARCHAR(100),
    @Email NVARCHAR(200),
    @Telefono NVARCHAR(50),
    @TipoMembresia NVARCHAR(50),
    @FechaVencimientoMembresia DATETIME,
    @Rol NVARCHAR(50),
    @Activo BIT,
    @Password NVARCHAR(100)  -- Se añade el parámetro de la contraseña
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE Miembros
    SET Nombre = @Nombre,
        Email = @Email,
        Telefono = @Telefono,
        TipoMembresia = @TipoMembresia,
        FechaVencimientoMembresia = @FechaVencimientoMembresia,
        Rol = @Rol,
        Activo = @Activo,
        Password = @Password   -- Se actualiza el campo de la contraseña
    WHERE UsuarioID = @UsuarioID;
    
    SELECT @UsuarioID AS MiembroActualizado;
END
GO

INSERT INTO Miembros 
   (Nombre, Email, Telefono, TipoMembresia, FechaVencimientoMembresia, Rol, Activo, Password)
VALUES 
   ('Administrador', 'admin@email.com', '3001234567', 
    'Premium', DATEADD(year, 1, GETDATE()), 'Administrador', 1, '123');