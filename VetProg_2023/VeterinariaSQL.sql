CREATE DATABASE [Veterinaria_2023]

USE [Veterinaria_2023]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Tipos](
	[id_tipo] [INT] PRIMARY KEY,
	[tipo] [VARCHAR](30) NOT NULL,
)


CREATE TABLE [dbo].[Duenios](
	[codigo_duenio] [INT] PRIMARY KEY,
	[nombre] [VARCHAR](30) NOT NULL,
);
	

CREATE TABLE [dbo].[Mascotas](
	[id_mascota] [INT] PRIMARY KEY IDENTITY,
	[nombre] [VARCHAR](30) NOT NULL,
	[edad] [INT] NOT NULL,
	[sexo] [VARCHAR](30) NOT NULL,
	[id_tipo] [INT] NOT NULL,
	[codigo_duenio] [INT] NOT NULL,
	FOREIGN KEY (id_tipo) REFERENCES Tipos(id_tipo),
    FOREIGN KEY (codigo_duenio) REFERENCES Duenios(codigo_duenio),
)

CREATE TABLE [dbo].[CarpetaMedica](
	[carpeta_nro] [INT] IDENTITY(1,1) NOT NULL,
	[id_mascota] [INT] NOT NULL,
 CONSTRAINT [PK_CARPETA] PRIMARY KEY CLUSTERED 
(
	[carpeta_nro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Atencion](
	[nro_carpeta] [INT] NOT NULL,
    [nro_atencion] [INT] NOT NULL,
	[id_mascota] [INT] NOT NULL,
    [descripcion] [varchar](30) NOT NULL,
	[fecha] [date] NOT NULL,
	PRIMARY KEY CLUSTERED 
	(
		[nro_carpeta] ASC,
		[nro_atencion] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	GO

INSERT INTO [dbo].[Tipos] (id_tipo, tipo) VALUES(1, 'Perro');
INSERT INTO [dbo].[Tipos] (id_tipo, tipo) VALUES(2, 'Gato');
INSERT INTO [dbo].[Tipos] (id_tipo, tipo) VALUES(3, 'Araña');
INSERT INTO [dbo].[Tipos] (id_tipo, tipo) VALUES(4, 'Iguana');

INSERT INTO [dbo].[Duenios] (codigo_duenio, nombre) VALUES(253612, 'Joaquin Postillon');
INSERT INTO [dbo].[Duenios] (codigo_duenio, nombre) VALUES(334123, 'Federico Neuman');
INSERT INTO [dbo].[Duenios] (codigo_duenio, nombre) VALUES(124562, 'Agustin Di Bella');
INSERT INTO [dbo].[Duenios] (codigo_duenio, nombre) VALUES(756234, 'Fabrizio Rodriguez');
INSERT INTO [dbo].[Duenios] (codigo_duenio, nombre) VALUES(987243, 'Paula Oddo');

INSERT INTO [dbo].[Mascotas] VALUES('Dracko', 3, 'M', 1, 253612);
INSERT INTO [dbo].[Mascotas] VALUES('Batata', 4, 'F', 1, 334123);
INSERT INTO [dbo].[Mascotas] VALUES('Tiberius', 10, 'M', 3, 124562);
INSERT INTO [dbo].[Mascotas] VALUES('Ana', 1, 'F', 4, 756234);
INSERT INTO [dbo].[Mascotas] VALUES('Manteca', 5, 'F', 2, 987243);

INSERT INTO [dbo].[CarpetaMedica](id_mascota) VALUES (1);
INSERT INTO [dbo].[CarpetaMedica](id_mascota) VALUES (2);
INSERT INTO [dbo].[CarpetaMedica](id_mascota) VALUES (3);
INSERT INTO [dbo].[CarpetaMedica](id_mascota) VALUES (4);
INSERT INTO [dbo].[CarpetaMedica](id_mascota) VALUES (5);

INSERT INTO [dbo].[Atencion](id_mascota, descripcion, fecha) VALUES (1, 'Fractura expuesta', '2023-05-12');
INSERT INTO [dbo].[Atencion](id_mascota, descripcion, fecha) VALUES (1, 'Revision Mensual', '2023-06-08');
--INSERT INTO [dbo].[Atencion](id_mascota, descripcion, fecha) VALUES (2, 'Otitis agravada oido izquierdo', '2023-02-02');
--INSERT INTO [dbo].[Atencion](id_mascota, descripcion, fecha) VALUES (2, 'Fractura expuesta', '2023-05-12');
--INSERT INTO [dbo].[Atencion](id_mascota, descripcion, fecha) VALUES (3, 'Fractura expuesta', '2023-05-12');
--INSERT INTO [dbo].[Atencion](id_mascota, descripcion, fecha) VALUES (3, 'Fractura expuesta', '2023-05-12');
--INSERT INTO [dbo].[Atencion](id_mascota, descripcion, fecha) VALUES (4, 'Fractura expuesta', '2023-05-12');
--INSERT INTO [dbo].[Atencion](id_mascota, descripcion, fecha) VALUES (5, 'Fractura expuesta', '2023-05-12');

CREATE PROCEDURE SP_SELECCIONAR_MASCOTA
AS
BEGIN
    SELECT M.id_mascota AS 'ID MASCOTA', M.Nombre AS 'NombreMascota',M.edad AS 'Edad', M.sexo AS 'Sexo', M.id_tipo as 'Tipo', D.codigo_duenio AS 'CodigoDueño', D.nombre AS 'NombreDuenio'
    FROM Mascotas M
    INNER JOIN Duenios D ON M.codigo_duenio = D.codigo_duenio
END;

CREATE PROCEDURE SP_CARPETA
@id_mascota INT
AS
BEGIN
	SELECT carpeta_nro FROM CarpetaMedica
		WHERE @id_mascota = id_mascota
END
GO

EXEC SP_CARPETA

DROP PROCEDURE SP_CARPETA


