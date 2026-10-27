-- =============================================================================================
-- HealthPortal — Script de base de datos (SQL Server 2022)
-- ---------------------------------------------------------------------------------------------
-- Crea la base de datos HealthPortal con sus esquemas, tablas, catálogos iniciales, vistas y
-- procedimientos almacenados. Se publica con fines educativos y de referencia; no contiene
-- datos reales de pacientes, usuarios ni instituciones.
--
-- Uso: abrir en SQL Server Management Studio y ejecutar completo (F5) sobre la instancia
-- deseada. Después, configurar la conexión desde la propia aplicación (config_server.xml).
--
-- Los objetos marcados como "Reconstruido a partir del código de la aplicación" no estaban en
-- el respaldo original del script y se redactaron según cómo los utiliza HealthPortal.
-- =============================================================================================

-- 0. CREACIÓN DE BASE DE DATOS --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE DATABASE HealthPortal;
GO

USE HealthPortal;
GO

--USE master;
--GO

--DROP DATABASE HealthPortal;
--GO

-- 0. CREACIÓN DE BASE DE DATOS --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

;

-- 1. SECCIONES ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE SCHEMA [Secciones];
GO

CREATE TABLE [Secciones].[tbGrados]
(
	[idGrado]					INT				PRIMARY KEY		IDENTITY(1,1),
	[grado]						VARCHAR(60)		NOT NULL		UNIQUE
);
GO

CREATE TABLE [Secciones].[tbSeccionAcademica]
(
	[idSeccionAcademica]		INT				PRIMARY KEY		IDENTITY(1,1),
	[seccionAcademica]			VARCHAR(10)		NOT NULL		UNIQUE
);
GO

CREATE TABLE [Secciones].[tbEspecialidades]
(
	[idEspecialidad]			INT				PRIMARY KEY		IDENTITY(1,1),
	[especialidad]				VARCHAR(60)		NOT NULL		UNIQUE
);
GO

CREATE TABLE [Secciones].[tbGradoSeccion]
(
	[idGradoSeccion]			INT				PRIMARY KEY		IDENTITY(1,1), 
	[grupoTecnico]				VARCHAR(12)		NOT NULL,
	[idGrado]					INT				NOT NULL		CONSTRAINT fk_tbGradoSeccion_tbGrados_idGrado								FOREIGN KEY REFERENCES [Secciones].[tbGrados](idGrado),
	[idSeccionAcademica]		INT				NOT NULL		CONSTRAINT fk_tbGradoSeccion_tbSeccionAcademica_idSeccionAcademica			FOREIGN KEY REFERENCES [Secciones].[tbSeccionAcademica](idSeccionAcademica),
	[idEspecialidad]			INT				NOT NULL		CONSTRAINT fk_tbGradoSeccion_tbEspecialidades_idEspecialidad				FOREIGN KEY REFERENCES [Secciones].[tbEspecialidades](IdEspecialidad)
);
GO


-- 1. SECCIONES ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

;

-- 2. PACIENTES ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE SCHEMA [Pacientes];
GO

CREATE TABLE [Pacientes].[tbTipoPersona]
(
	[idTipoPersona]				INT				PRIMARY KEY		IDENTITY(1,1),
	[tipoPersona]				VARCHAR(50)
);
GO

-- Asegurarse de haber creado todas las tablas del esquema [Secciones] antes de crear esta siguiente tabla
CREATE TABLE [Pacientes].[tbPacientes]
(
	[idPaciente]				INT				PRIMARY KEY		IDENTITY(1,1),
	[nombrePaciente]			VARCHAR(60)		NOT NULL,
	[apellidoPaciente]			VARCHAR(60)		NOT NULL,
	[codigo]					VARCHAR(10)		NOT NULL,
	[idGradoSeccion]			INT				NOT NULL		CONSTRAINT fk_tbPacientes_tbGradoSeccion_idGradoSeccion						FOREIGN KEY REFERENCES [Secciones].[tbGradoSeccion](idGradoSeccion),
	[idTipoPersona]				INT				NOT NULL		CONSTRAINT fk_tbPacientes_tbTipoPersona_idTipoPersona						FOREIGN KEY REFERENCES [Pacientes].[tbTipoPersona](idTipoPersona)
);
GO

-- 2. PACIENTES ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

;

-- 3. INVENTARIO -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE SCHEMA [Inventario];
GO

CREATE TABLE [Inventario].[tbCategoriaInventario]
(
	idCategoriaInventario		INT				PRIMARY KEY		IDENTITY(1,1),
	categoriaInventario			VARCHAR(50)		NOT NULL
);

CREATE TABLE [Inventario].[tbCategoriaMedicamento]
(
	idCategoriaMedicamento		INT				PRIMARY KEY		IDENTITY(1,1),
	categoriaMedicamento		VARCHAR(50)		NOT NULL
);
GO

CREATE TABLE [Inventario].[tbInventario]
(
	idInventario				INT				PRIMARY KEY		IDENTITY(1001,1),
	nombreInventario			VARCHAR(60)		NOT NULL,
	descripcionInventario		VARCHAR(150),
	idCategoriaInventario		INT				NOT NULL		CONSTRAINT fk_tbInventario_tbCategoriaInventario							FOREIGN KEY REFERENCES [Inventario].[tbCategoriaInventario](idCategoriaInventario),
	idCategoriaMedicamento		INT								CONSTRAINT fk_tbInventario_tbCategoriaMedicamento							FOREIGN KEY REFERENCES [Inventario].[tbCategoriaMedicamento](idCategoriaMedicamento),
	fechaVencimiento			DATE,
	imagenInventario			IMAGE
);
GO

CREATE TABLE [Inventario].[tbEntradaSalidaInventario]
(
	idEntradaSalida				INT				PRIMARY KEY		IDENTITY(1,1),
	fechaEntradaSalida			DATE			NOT NULL,
	horaEntradaSalida			VARCHAR(10)		NOT NULL,
	idInventario				INT				NOT NULL		CONSTRAINT fk_tbEntradaSalidaInventario_tbInventario_idInventario			FOREIGN KEY REFERENCES [Inventario].[tbInventario](idInventario),
	cantidadEnvasesInventario	INT				NOT NULL,
	cantidadInventario			INT
);
GO

-- 3. INVENTARIO -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

;

-- 4. INSTITUCIÓN ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE SCHEMA [Institución];
GO

CREATE TABLE [Institución].[tbCategoríaInstitución]
(
	idCategoríaInstitución		INT				PRIMARY KEY		IDENTITY(1,1),
	categoríaInstitución		VARCHAR(100)	NOT NULL		UNIQUE
);
GO

CREATE TABLE [Institución].[tbInstitución]
(
	idInstitución				INT				PRIMARY KEY		IDENTITY(1,1),
	nombreInstitución			VARCHAR(50)		NOT NULL		UNIQUE,
	direcciónInstitución		VARCHAR(250)	NOT NULL		UNIQUE,
	logoInstitución				IMAGE,
	correoInstitución			VARCHAR(100)	NOT NULL		UNIQUE,
	dominioInstitución			VARCHAR(20)		NOT NULL,
	teléfonoInstitución			VARCHAR(25)		NOT NULL,
	idCategoríaInstitución		INT				NOT NULL		CONSTRAINT fk_tbInstitución_tbCategoríaInstitución_idCategoríaInstitución	FOREIGN KEY REFERENCES [Institución].[tbCategoríaInstitución]
);
GO

CREATE TABLE [Institución].[tbRoles]
(
	idRol						INT				PRIMARY KEY		IDENTITY(1,1),
	nombreRol					VARCHAR(50)		NOT NULL		UNIQUE
);
GO

CREATE TABLE [Institución].[tbUsuarios]
(
	usuario						VARCHAR(50)		PRIMARY KEY,
	contraseña					VARCHAR(256)	NOT NULL,
	token						VARCHAR(69)		NOT NULL,
	estadoUsuario				BIT				NOT NULL,
	intentosUsuario				INT				NOT NULL,
	contraseñaTemporal			BIT				NOT NULL,
	recordarCredenciales		BIT				NOT NULL,
	idRol						INT				NOT NULL		CONSTRAINT fk_tbUsuarios_tbRoles_idRol										FOREIGN KEY REFERENCES [Institución].[tbRoles](idRol),
	idInstitución				INT				NOT NULL		CONSTRAINT fk_tbUsuarios_tbInstitución_idInstitución						FOREIGN KEY REFERENCES [Institución].[tbInstitución](idInstitución)
);
GO

CREATE TABLE [Institución].[tbPersonas]
(
	idPersona					INT				PRIMARY KEY		IDENTITY(1,1),
	nombrePersona				VARCHAR(60)		NOT NULL,
	apellidoPersona				VARCHAR(60)		NOT NULL,
	correoPersona				VARCHAR(100)	UNIQUE,
	telefonoPersona				VARCHAR(25)		UNIQUE,
	usuario						VARCHAR(50)		UNIQUE			CONSTRAINT fk_tbPersonas_tbUsuarios_usuario									FOREIGN KEY REFERENCES [Institución].[tbUsuarios](usuario)
);
GO

CREATE TABLE [Institución].[tbPreguntas]
(
	idPregunta					INT				PRIMARY KEY		IDENTITY(1,1),
	pregunta					VARCHAR(150)	NOT NULL		UNIQUE
);
GO

CREATE TABLE [Institución].[tbRespuestas]
(
	idRespuesta					INT				PRIMARY KEY		IDENTITY(1,1),
	usuario						VARCHAR(50)		NOT NULL		CONSTRAINT fk_tbRespuestas_tbUsuarios_usuario								FOREIGN KEY REFERENCES [Institución].[tbUsuarios](usuario),
	idPregunta					INT				NOT NULL		CONSTRAINT fk_tbRespuestas_tbPreguntas_idPregunta							FOREIGN KEY REFERENCES [Institución].[tbPreguntas](idPregunta),
	respuesta					VARCHAR(256)	NOT NULL,		CONSTRAINT uq_usuario_idPregunta UNIQUE (usuario, idPregunta)
);
GO

-- 4. INSTITUCIÓN ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

;

-- 5. VISITAS --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE SCHEMA [Visitas];
GO

CREATE TABLE [Visitas].[tbVisitas]
(
	idVisita					INT				PRIMARY KEY		IDENTITY(1,1),
	idPaciente					INT				NOT NULL		CONSTRAINT fk_tbVisitas_tbPacientes_idPaciente								FOREIGN KEY REFERENCES [Pacientes].[tbPacientes](idPaciente),
	fechaVisita					DATE			NOT NULL,
	horaVisita					VARCHAR(5)		NOT NULL,
	idInventario				INT								CONSTRAINT fk_tbVisitas_tbInventario_idInventario							FOREIGN KEY REFERENCES [Inventario].[tbInventario](idInventario),
	observaciones				VARCHAR(200),
	idPersona					INT				NOT NULL		CONSTRAINT fk_tbVisitas_tbPersonas_idPersona								FOREIGN KEY REFERENCES [Institución].[tbPersonas](idPersona)
);
GO

-- 5. VISITAS --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

;

-- 6. INSERCIONES PREDETERMINADAS ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- A la tabla tbTipoPersona, procedente del esquema [Pacientes]
INSERT INTO [Pacientes].[tbTipoPersona] VALUES
	('Estudiante'), ('Personal de la Institucion');
GO

INSERT INTO [Inventario].[tbCategoriaInventario] VALUES
	('Farmacia'), ('Suministros médicos');
GO

-- A la tabla tbRoles, procedente del esquema [Institución]
INSERT INTO [Institución].[tbRoles] VALUES
	('Administrador'), ('Personal');
GO

INSERT INTO [Institución].[tbCategoríaInstitución] VALUES
	('Colegio'), ('Colegio técnico');
GO

INSERT INTO [Inventario].[tbCategoriaMedicamento] VALUES
	('Analgésico'), ('Antialérgico');
GO

-- 6. INSERCIONES PREDETERMINADAS ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

;

-- 7. VISTAS ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE SCHEMA [Vistas];
GO

-- viewPreguntasDeSeguridad, procedente del esquema [Institución]
CREATE VIEW [Vistas].[viewPreguntasDeSeguridad]
	AS
	SELECT
		[a].idPregunta					AS [ID],
		[a].pregunta					AS [Pregunta]
	FROM [Institución].[tbPreguntas] [a];
GO

-- viewGradoSeccion, procedente del esquema [Secciones]
CREATE VIEW [Vistas].[viewGradoSeccion]
	AS
	SELECT
		[a].idGradoSeccion				AS [ID],
		[a].grupoTecnico				AS [Grupo Técnico],
		[b].grado						AS [Grado],
		[c].seccionAcademica			AS [Sección Académica],
		[d].especialidad				AS [Especialidad]
	FROM [Secciones].[tbGradoSeccion] [a]
	INNER JOIN	[Secciones].[tbGrados] [b] ON [b].[idGrado] = [a].[idGrado]
	INNER JOIN	[Secciones].[tbSeccionAcademica] [c] ON [c].[idSeccionAcademica] = [a].[idSeccionAcademica]
	INNER JOIN	[Secciones].[tbEspecialidades] [d] ON [d].[idEspecialidad] = [a].[idEspecialidad];
GO

-- viewAdminPacientes, procedente del esquema [Pacientes], [Medicamentos] y [Secciones]
CREATE VIEW [Vistas].[viewAdminPacientes]
	AS
	SELECT
		[c].idVisita,
		[a].nombrePaciente,
		[a].apellidoPaciente,
		[b].TipoPersona,
		[a].codigo,
		[d].[Grupo Técnico],
		[d].grado,
		[d].[Sección Académica],
		[d].especialidad,
		[c].fechaVisita,
		[c].horaVisita,
		[e].nombreInventario,
		[c].observaciones,
		CONCAT([f].nombrePersona,' ', [f].apellidoPersona) AS [nombreCompleto]
	FROM [Pacientes].[tbPacientes] [a]
	INNER JOIN	[Pacientes].[tbTipoPersona] [b] ON [b].[idTipoPersona] = [a].[idTipoPersona]
	INNER JOIN	[Visitas].[tbVisitas] [c] ON [c].[idPaciente] = [a].[idPaciente]
	LEFT JOIN	[Vistas].[viewGradoSeccion] [d] ON [d].[ID] = [a].[idGradoSeccion]
	INNER JOIN	[Inventario].[tbInventario] [e] ON [e].[idInventario] = [c].[idInventario]
	INNER JOIN	[Institución].[tbPersonas] [f] On [f].[idPersona] = [c].[idPersona];
GO

-- viewNombreMedicamento, procedente del esquema [Medicamentos]
CREATE VIEW [Vistas].[viewNombreMedicamento]
	AS
	SELECT
		[a].nombreInventario
	FROM [Inventario].[tbInventario] [a];
GO

-- viewMedicamento, procedente del esquema [Medicamentos]
CREATE VIEW [Vistas].[viewInventario]
	AS
	SELECT
		[a].idInventario				AS [ID del producto],
		[a].nombreInventario			AS [Nombre del Producto],
		[a].descripcionInventario		AS [Descripción del Producto],
		[b].categoriaMedicamento		AS [Categoría del Producto],
		[a].fechaVencimiento			AS [Fecha de Vencimiento],
		[c].fechaEntradaSalida			AS [Fecha de Ingreso],
		[c].horaEntradaSalida			AS [Hora de Ingreso],
		[c].cantidadInventario			AS [Cantidad por Envase],
		[c].cantidadEnvasesInventario	AS [Cantidad de Envases],
		[c].idEntradaSalida				AS [ID de la Entrada]
	FROM [Inventario].[tbInventario] [a]
	INNER JOIN [Inventario].[tbCategoriaMedicamento] [b] ON [b].[idCategoriaMedicamento] = [a].[idCategoriaMedicamento]
	INNER JOIN [Inventario].[tbEntradaSalidaInventario] [c] ON [c].[idInventario] = [a].[idInventario];
GO

-- viewPersonas, procedente del esquema [Institución]
CREATE VIEW [Vistas].[viewPersonas]
	AS
	SELECT
		[a].idPersona					AS [ID],
		[a].nombrePersona				AS [Nombres],
		[a].apellidoPersona				AS [Apellidos],
		[a].correoPersona				AS [Correo Electrónico],
		[a].telefonoPersona				AS [Número Telefónico],
		[b].usuario						AS [Usuario],
		[c].nombreRol					AS [Rol de Acceso]
	FROM [Institución].[tbPersonas] [a]
	INNER JOIN	[Institución].[tbUsuarios] [b] ON [a].[usuario] = [b].[usuario]
	INNER JOIN	[Institución].[tbRoles] [c] ON [b].[idRol] = [c].[idRol];
GO

-- viewInformacionLogin, procedente del esquema [Institución]
CREATE VIEW [Vistas].[viewInformacionLogin]
	AS
	SELECT
		[a].usuario,
		[a].contraseña,
		[a].token,
		[a].estadoUsuario,
		[a].idRol,
		[b].nombreRol,
		CONCAT([c].nombrePersona,' ', [c].apellidoPersona) AS [nombreCompleto],
		[a].contraseñaTemporal,
		[c].correoPersona
	FROM [Institución].[tbUsuarios] [a]
	INNER JOIN	[Institución].[tbRoles] [b] ON [a].[idRol] = [b].[idRol]
	INNER JOIN	[Institución].[tbPersonas] [c] ON [a].[usuario] = [c].[usuario]
GO

-- viewEspecialidades, procedente del esquema [Secciones]
CREATE VIEW [Vistas].[viewEspecialidades]
	AS
	SELECT
		[a].IdEspecialidad				AS [ID],
		[a].Especialidad				AS [Especialidad]
	FROM [Secciones].[tbEspecialidades] [a];
GO

-- viewSeccionesAcademicas, procedente del esquema [Secciones]
CREATE VIEW [Vistas].[viewSeccionesAcademicas]
	AS
	SELECT
		[a].idSeccionAcademica			AS [ID],
		[a].seccionAcademica			AS [Sección Académica]
	FROM [Secciones].[tbSeccionAcademica] [a];
GO

CREATE VIEW [Vistas].[viewGrados]
	AS
	SELECT
		[a].idGrado						AS [ID],
		[a].grado						AS [Nivel Académico]
	FROM [Secciones].[tbGrados] [a];
GO

CREATE VIEW [Vistas].[viewRespuestasDeSeguridad]
	AS
	SELECT
		[a].idRespuesta AS [ID],
		[a].usuario AS [Usuario],
		[b].pregunta AS [Pregunta],
		[a].respuesta AS [Respuesta],
		[a].idPregunta AS [ID Pregunta]
	FROM [Institución].[tbRespuestas] [a]
	INNER JOIN [Institución].[tbPreguntas] [b] ON [a].[idPregunta] = [b].[idPregunta];
GO

-- viewFiltrarCodigo, procedente del esquema [Pacientes]
CREATE VIEW [Vistas].[viewFiltrarCodigo]
	AS
	SELECT
		[a].nombrePaciente,
		[a].apellidoPaciente,
		[a].codigo,
		[b].grupoTecnico,
		[c].grado,
		[d].especialidad,
		[e].seccionAcademica, 
		[f].tipoPersona
	FROM [Pacientes].[tbPacientes] [a]
	INNER JOIN [Secciones].[tbGradoSeccion] [b] ON [a].[idGradoSeccion] = [b].[idGradoSeccion]
	INNER JOIN [Secciones].[tbGrados] [c] ON [b].[idGrado] = [c].[idGrado]
	INNER JOIN [Secciones].[tbEspecialidades] [d] ON [b].[idEspecialidad] = [d].[idEspecialidad]
	INNER JOIN [Secciones].[tbSeccionAcademica] [e] ON [b].[idSeccionAcademica] = [e].[idSeccionAcademica]
	INNER JOIN [Pacientes].[tbTipoPersona] [f] ON [a].[idTipoPersona] = [f].[idTipoPersona];
GO

CREATE VIEW [Vistas].[viewGeneralReportInventory]
	AS
	SELECT
		[a].nombreInventario,
		[b].categoriaMedicamento,
		[a].fechaVencimiento,
		[c].fechaEntradaSalida,
		[c].horaEntradaSalida,
		[c].cantidadInventario
	FROM [Inventario].[tbInventario] [a]
	INNER JOIN [Inventario].[tbCategoriaMedicamento] [b] ON [b].[idCategoriaMedicamento] = [a].[idCategoriaMedicamento]
	INNER JOIN [Inventario].[tbEntradaSalidaInventario] [c] ON [c].[idInventario] = [a].[idInventario];
GO

CREATE VIEW [Vistas].[viewGeneralReportVisits]
	AS
	SELECT
		CONCAT ([a].nombrePaciente,' ' ,[a].apellidoPaciente) As [nombreCompletoPaciente],
		[b].tipoPersona,
		[a].codigo,
		[d].[Grupo Técnico],
		[d].grado,
		[d].[Sección Académica],
		[d].especialidad,
		[c].fechaVisita,
		[c].horaVisita,
		[e].nombreInventario,
		CONCAT([f].nombrePersona,' ', [f].apellidoPersona) AS [nombreCompleto]
	FROM [Pacientes].[tbPacientes] [a]
	INNER JOIN	[Pacientes].[tbTipoPersona] [b] ON [b].[idTipoPersona] = [a].[idTipoPersona]
	INNER JOIN	[Visitas].[tbVisitas] [c] ON [c].[idPaciente] = [a].[idPaciente]
	LEFT JOIN	[Vistas].[viewGradoSeccion] [d] ON [d].[ID] = [a].[idGradoSeccion]
	INNER JOIN	[Inventario].[tbInventario] [e] ON [e].[idInventario] = [c].[idInventario]
	INNER JOIN [Institución].[tbPersonas] [f] On [f].[idPersona] = [c].[idPersona];
GO

-- viewInfoPacientes, procedente del esquema [Pacientes] y [Secciones]
-- Reconstruido a partir del código de la aplicación (FrmPatientAdministration / DAOPatientAdministration)
CREATE VIEW [Vistas].[viewInfoPacientes]
	AS
	SELECT
		[a].idPaciente,
		[a].nombrePaciente,
		[a].apellidoPaciente,
		[b].tipoPersona,
		[a].codigo,
		[c].[Grupo Técnico],
		[c].grado,
		[c].[Sección Académica],
		[c].especialidad
	FROM [Pacientes].[tbPacientes] [a]
	INNER JOIN	[Pacientes].[tbTipoPersona] [b] ON [b].[idTipoPersona] = [a].[idTipoPersona]
	LEFT JOIN	[Vistas].[viewGradoSeccion] [c] ON [c].[ID] = [a].[idGradoSeccion];
GO

-- viewPorcentajeEstudiantesPorSeccion, procedente del esquema [Pacientes]
-- Reconstruido a partir del código de la aplicación (gráfico de FrmPatientsTreated)
CREATE VIEW [Vistas].[viewPorcentajeEstudiantesPorSeccion]
	AS
	SELECT
		[a].idGradoSeccion,
		CAST(COUNT(*) * 100.0 / SUM(COUNT(*)) OVER () AS DECIMAL(5, 2)) AS [PorcentajeDelTotal]
	FROM [Pacientes].[tbPacientes] [a]
	INNER JOIN	[Pacientes].[tbTipoPersona] [b] ON [b].[idTipoPersona] = [a].[idTipoPersona]
	WHERE [b].[tipoPersona] = 'Estudiante'
	GROUP BY [a].idGradoSeccion;
GO

-- 7. VISTAS ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

;

-- 8. PROCEDIMIENTOS ALMACENADOS -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE SCHEMA [ProcedimientosAlmacenados];
GO

CREATE PROCEDURE [ProcedimientosAlmacenados].[spPreguntasDeSeguridadDeUsuario]
		@username VARCHAR(50)
	AS
	BEGIN
		SELECT [a].[idPregunta], [a].[pregunta]
		FROM [Institución].[tbPreguntas] [a]
	INNER JOIN [Institución].[tbRespuestas] [b] ON [a].[idPregunta] = [b].[idPregunta]
	WHERE [b].[usuario] = @username;
	END;
GO

CREATE PROCEDURE [ProcedimientosAlmacenados].[spValidarRespuestaDeSeguridad]
		@username VARCHAR(50),
		@questionID INT,
		@answer VARCHAR(256)
	AS
	BEGIN
    
		SELECT *
		FROM [Institución].[tbRespuestas] [a]
    INNER JOIN [Institución].[tbUsuarios] [b] ON [a].usuario = [b].[usuario]
    INNER JOIN [Institución].[tbPreguntas] [c] ON [a].idPregunta = [c].[idPregunta]
    WHERE [a].[usuario] = @username
      AND [a].[idPregunta] = @questionID
      AND [a].[respuesta] = @answer;
    END;
GO

-- spIngresarMedicamento, procedente del esquema [Medicamentos]
CREATE PROCEDURE [ProcedimientosAlmacenados].[spIngresarMedicamento]
		@param1 VARCHAR(60),
		@param2 VARCHAR(150),
		@param3 INT,
		@param4 INT,
		@param5 DATE,
		@param6 IMAGE,
		@param7 DATE,
		@param8 VARCHAR(5),
		@param9 INT,
		@param10 INT,
		@param11 INT
	AS
	BEGIN
		BEGIN TRANSACTION
			INSERT INTO [Inventario].[tbInventario]
			VALUES
			(@param1, @param2, @param3, @param4, @param5, @param6)
			IF @@ROWCOUNT > 0
			BEGIN
				SET @param9 = SCOPE_IDENTITY();
				INSERT INTO [Inventario].[tbEntradaSalidaInventario]
				VALUES
				(@param7, @param8, @param9, @param10, @param11)
				COMMIT TRANSACTION;
			END
			ELSE
			BEGIN
				ROLLBACK TRANSACTION;
			END
	END;
GO

-- spActualizarMedicamento, procedente del esquema [Medicamentos]
-- Reconstruido a partir del código de la aplicación (DAOInventoryAdministration.UpdateInventory)
CREATE PROCEDURE [ProcedimientosAlmacenados].[spActualizarMedicamento]
		@medicineName VARCHAR(60),
		@description VARCHAR(150),
		@expirationDate DATE,
		@image IMAGE,
		@medicineID INT,
		@entryDate DATE,
		@entryTime VARCHAR(10),
		@packages INT,
		@stock INT
	AS
	BEGIN
		BEGIN TRANSACTION
			UPDATE [Inventario].[tbInventario]
			SET [nombreInventario] = @medicineName,
				[descripcionInventario] = @description,
				[fechaVencimiento] = @expirationDate,
				[imagenInventario] = @image
			WHERE [idInventario] = @medicineID
			IF @@ROWCOUNT > 0
			BEGIN
				UPDATE [Inventario].[tbEntradaSalidaInventario]
				SET [fechaEntradaSalida] = @entryDate,
					[horaEntradaSalida] = @entryTime,
					[cantidadEnvasesInventario] = @packages,
					[cantidadInventario] = @stock
				WHERE [idInventario] = @medicineID
				COMMIT TRANSACTION;
			END
			ELSE
			BEGIN
				ROLLBACK TRANSACTION;
			END
	END;
GO

-- spEliminarMedicamento, procedente del esquema [Medicamentos]
CREATE PROCEDURE [ProcedimientosAlmacenados].[spEliminarMedicamento]
		@param1 INT,
		@param2 INT
	AS
	BEGIN
		BEGIN TRANSACTION
			DELETE FROM [Inventario].[tbEntradaSalidaInventario]
			WHERE [idEntradaSalida] = @param1;
			IF @@ROWCOUNT > 0
			BEGIN
				DELETE FROM [Inventario].[tbInventario]
				WHERE [idInventario] = @param2;
				COMMIT TRANSACTION;
			END
			ELSE
			BEGIN
				ROLLBACK TRANSACTION;
			END
	END;
GO

-- spIndiceUsoInventario, procedente del esquema [Inventario] y [Visitas]
-- Reconstruido a partir del código de la aplicación (gráfico de FrmUsageIndex)
CREATE PROCEDURE [ProcedimientosAlmacenados].[spIndiceUsoInventario]
		@fechaInicio DATE,
		@fechaFin DATE
	AS
	BEGIN
		SELECT
			[a].nombreInventario,
			COUNT([b].idVisita)				AS [usos]
		FROM [Inventario].[tbInventario] [a]
		INNER JOIN [Visitas].[tbVisitas] [b] ON [b].[idInventario] = [a].[idInventario]
		WHERE [b].[fechaVisita] BETWEEN @fechaInicio AND @fechaFin
		GROUP BY [a].nombreInventario
		ORDER BY [usos] DESC;
	END;
GO

-- spRegistrarUsuario, procedente del esquema [Institución]
CREATE PROCEDURE [ProcedimientosAlmacenados].[spRegistrarUsuario]
    @username VARCHAR(50),
    @password VARCHAR(256),
    @token VARCHAR(69),
    @userStatus BIT,
    @userAttempts INT,
    @temporaryPassword BIT,
    @rememberCredentials BIT,
    @roleId INT,
    @institutionId INT,
    @name VARCHAR(60),
    @lastName VARCHAR(60),
    @email VARCHAR(100),
    @phoneNumber VARCHAR(25)
AS
BEGIN
    BEGIN TRANSACTION
    SELECT TOP 1 @institutionId = [idInstitución]
    FROM [Institución].[tbInstitución]
    ORDER BY idInstitución DESC;

    IF @institutionId IS NOT NULL
    BEGIN
        INSERT INTO [Institución].[tbUsuarios]
        VALUES (@username, @password, @token, @userStatus, @userAttempts, @temporaryPassword, @rememberCredentials, @roleId, @institutionId);
        IF @@ROWCOUNT = 1
        BEGIN
            INSERT INTO [Institución].[tbPersonas]
            VALUES (@name, @lastName, @email, @phoneNumber, @username);
            IF @@ROWCOUNT = 1
            BEGIN
                COMMIT TRANSACTION;
            END
            ELSE
            BEGIN
                ROLLBACK TRANSACTION;
            END
        END
        ELSE
        BEGIN
            ROLLBACK TRANSACTION;
        END
    END
    ELSE
    BEGIN
        ROLLBACK TRANSACTION;
    END
END;
GO

-- spCambiarContraseña, procedente del esquema [Institución]
CREATE PROCEDURE [ProcedimientosAlmacenados].[spCambiarContraseña]
		@param1 VARCHAR(256),
		@param2 VARCHAR(60),
		@param3 BIT
	AS
	BEGIN
		BEGIN TRANSACTION
			UPDATE [Institución].[tbUsuarios]
			SET [contraseña] = @param1
			WHERE [usuario] = @param2;
			IF @@ROWCOUNT > 0
			BEGIN
				UPDATE [Institución].[tbUsuarios]
				SET [contraseñaTemporal] = @param3
				WHERE [usuario] = @param2;
				COMMIT TRANSACTION;
			END
			ELSE
			BEGIN
				ROLLBACK TRANSACTION;
			END
	END;
GO

-- spEliminarUsuario, procedente del esquema [Institución]
CREATE PROCEDURE [ProcedimientosAlmacenados].[spEliminarUsuario]
		@param1 INT,
		@param2 VARCHAR(60)
	AS
	BEGIN
		BEGIN TRANSACTION
			DELETE FROM [Institución].[tbPersonas]
			WHERE [idPersona] = @param1;
			IF @@ROWCOUNT > 0
			BEGIN
				DELETE FROM [Institución].[tbUsuarios]
				WHERE [usuario] = @param2;
				COMMIT TRANSACTION;
			END
			ELSE
			BEGIN
				ROLLBACK TRANSACTION;
			END
	END;
GO

-- spIngresarEspecialidad, procedente del esquema [Secciones]
CREATE PROCEDURE [ProcedimientosAlmacenados].[spIngresarGrado]
		@grade VARCHAR(60)
	AS
	BEGIN
		INSERT INTO [Secciones].[tbGrados](grado)
		VALUES
		(@grade);
	END;
GO

-- spActualizarEspecialidad, procedente del esquema [Secciones]
CREATE PROCEDURE [ProcedimientosAlmacenados].[spActualizarGrado]
		@grade VARCHAR(60),
		@gradeID INT
	AS
	BEGIN
		UPDATE [Secciones].[tbGrados]
		SET [grado] = @grade
		WHERE [idGrado] = @gradeID;
	END;
GO

-- spEliminarEspecialidad, procedente del esquema [Secciones]
CREATE PROCEDURE [ProcedimientosAlmacenados].[spEliminarGrado]
		@gradeID INT
	AS
	BEGIN
		DELETE FROM [Secciones].[tbGrados]
		WHERE [idGrado] = @gradeID;
	END;
GO

-- spIngresarEspecialidad, procedente del esquema [Secciones]
CREATE PROCEDURE [ProcedimientosAlmacenados].[spIngresarEspecialidad]
		@param1 VARCHAR(60)
	AS
	BEGIN
		INSERT INTO [Secciones].[tbEspecialidades](especialidad)
		VALUES
		(@param1);
	END;
GO

-- spActualizarEspecialidad, procedente del esquema [Secciones]
CREATE PROCEDURE [ProcedimientosAlmacenados].[spActualizarEspecialidad]
		@param1 VARCHAR(60),
		@param2 INT
	AS
	BEGIN
		UPDATE [Secciones].[tbEspecialidades]
		SET [especialidad] = @param1
		WHERE [idEspecialidad] = @param2;
	END;
GO

-- spEliminarEspecialidad, procedente del esquema [Secciones]
CREATE PROCEDURE [ProcedimientosAlmacenados].[spEliminarEspecialidad]
		@param1 INT
	AS
	BEGIN
		DELETE FROM [Secciones].[tbEspecialidades]
		WHERE [idEspecialidad] = @param1;
	END;
GO

-- spIngresarSeccionAcademica, procedente del esquema [Secciones]
CREATE PROCEDURE [ProcedimientosAlmacenados].[spIngresarSeccionAcademica]
		@param1 varchar(10)
	AS
	BEGIN
		INSERT INTO [Secciones].[tbSeccionAcademica](seccionAcademica)
		VALUES
		(@param1);
	END;
GO

-- spActualizarSeccionAcademica, procedente del esquema [Secciones]
CREATE PROCEDURE [ProcedimientosAlmacenados].[spActualizarSeccionAcademica]
		@param1 VARCHAR(10),
		@param2 INT
	AS
	BEGIN
		UPDATE [Secciones].[tbSeccionAcademica]
		SET [seccionAcademica] = @param1
		WHERE [idSeccionAcademica] = @param2;
	END;
GO

-- spEliminarSeccionAcademica, procedente del esquema [Secciones]
CREATE PROCEDURE [ProcedimientosAlmacenados].[spEliminarSeccionAcademica]
		@param1 INT
	AS
	BEGIN
		DELETE FROM [Secciones].[tbSeccionAcademica]
		WHERE [idSeccionAcademica] = @param1;
	END;
GO

-- spIngresarSeccion, procedente del esquema [Secciones]
CREATE PROCEDURE [ProcedimientosAlmacenados].[spIngresarSeccion]
		@param1 VARCHAR(12),
		@param2 INT,
		@param3 INT,
		@param4 INT
	AS
	BEGIN
		INSERT INTO [Secciones].[tbGradoSeccion]
		(grupoTecnico, idGrado, idSeccionAcademica, idEspecialidad)
		VALUES
		(@param1, @param2, @param3, @param4);
	END;
GO

-- spActualizarSeccion, procedente del esquema [Secciones]
CREATE PROCEDURE [ProcedimientosAlmacenados].[spActualizarSeccion]
		@param1 VARCHAR(12),
		@param2 INT,
		@param3 INT,
		@param4 INT,
		@param5 INT
	AS
	BEGIN
		UPDATE [Secciones].[tbGradoSeccion]
		SET [grupoTecnico] = @param1, 
			[idGrado] = @param2,
			[idEspecialidad] = @param3,
			[idSeccionAcademica] = @param4
		WHERE [idGradoSeccion] = @param5;
	END;
GO

-- spEliminarSeccion, procedente del esquema [Secciones]
CREATE PROCEDURE [ProcedimientosAlmacenados].[spEliminarSeccion]
		@param1 INT
	AS
	BEGIN
		DELETE FROM [Secciones].[tbGradoSeccion]
		WHERE [idGradoSeccion] = @param1;
	END;
GO

-- 8. PROCEDIMIENTOS ALMACENADOS -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

;
