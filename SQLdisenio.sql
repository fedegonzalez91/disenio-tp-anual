USE disenio_tp
GO

CREATE SCHEMA TP_DISENIO;
GO	


DROP TABLE TP_DISENIO.Inscripciones
GO
DROP TABLE TP_DISENIO.Criticas
GO
DROP TABLE TP_DISENIO.Infracciones
GO
DROP TABLE TP_DISENIO.Jugadores
GO
DROP TABLE TP_DISENIO.Partidos
GO


CREATE TABLE TP_DISENIO.Jugadores
(
	[id_user] [varchar](10),
	[pass] [varchar](10),
	[nombre][varchar](20),
	[apellido][varchar](20),
	[fecha_nac][datetime],
	[activo][bit],
CONSTRAINT PK_Jugadores PRIMARY KEY (id_user)
);
GO

CREATE TABLE TP_DISENIO.Partidos
(
	[id_partido] [varchar](10),
	[fecha_hora] [datetime],
	[activo][bit],
CONSTRAINT PK_Partido PRIMARY KEY (id_partido)
);
GO

CREATE TABLE TP_DISENIO.Criticas
(
	[id_critica] [int] IDENTITY(1,1),
	[puntuacion] [int],
	[id_partido][varchar] (10),
	[id_user][varchar](10),
	[critica][varchar](255)
CONSTRAINT PK_Critica PRIMARY KEY (id_critica)
CONSTRAINT FK_Critica_id_partido FOREIGN KEY (id_partido) REFERENCES TP_DISENIO.Partidos(id_partido),
CONSTRAINT FK_Critica_id_user FOREIGN KEY (id_user) REFERENCES TP_DISENIO.Jugadores (id_user)
);
GO

CREATE TABLE TP_DISENIO.Infracciones
(
	[id_infraccion] [int]IDENTITY(1,1),
	[fecha_infraccion] [datetime],
	[motivo][varchar](255),
	[id_user][varchar](10),
	[id_partido][varchar](10),
CONSTRAINT PK_Infraccion PRIMARY KEY (id_infraccion),
CONSTRAINT FK_Infraccion_id_user FOREIGN KEY (id_user) REFERENCES TP_DISENIO.Jugadores (id_user),
CONSTRAINT FK_Infraccion_id_partido FOREIGN KEY (id_partido) REFERENCES TP_DISENIO.Partidos(id_partido)
);
GO


CREATE TABLE TP_DISENIO.Inscripciones
(
	[id_inscripcion][int] IDENTITY (1,1),
	[id_user][varchar](10),
	[id_partido][varchar](10),
	[cod_inscripcion][int],
	[activo][bit]
CONSTRAINT PK_Inscripcion PRIMARY KEY (id_inscripcion),
CONSTRAINT FK_Inscripcion_id_user FOREIGN KEY (id_user) REFERENCES TP_DISENIO.Jugadores (id_user),
CONSTRAINT FK_Inscripcion_id_partido FOREIGN KEY (id_partido) REFERENCES TP_DISENIO.Partidos(id_partido)
);
GO

CREATE TABLE TP_DISENIO.TiposDeInscripciones
(
	[cod_inscripcion][int],
	[nombre][varchar](15),
CONSTRAINT PK_tipoDeinfraccion PRIMARY KEY (cod_inscripcion)
);
GO


						/*Fin de Creación de Tablas*/
						
						
						/*Inicio de Relleno de Tablas*/
INSERT INTO TP_DISENIO.TiposDeInscripciones(cod_inscripcion,nombre)VALUES (1,'Estandar')
INSERT INTO TP_DISENIO.TiposDeInscripciones(cod_inscripcion,nombre)VALUES (2,'Solidario')
INSERT INTO TP_DISENIO.TiposDeInscripciones(cod_inscripcion,nombre)VALUES (3,'Condicional')
						/*Fin de Relleno de Tablas*/


			/*Inicio de Stored Procedure*/



CREATE PROCEDURE TP_DISENIO.verificarUsuario
(@id_user varchar (10))
AS
	IF EXISTS (SELECT * FROM TP_DISENIO.Jugadores WHERE id_user=@id_user)
		BEGIN
			RETURN 1
		END
	ELSE
		BEGIN
			RETURN 0
		END	
GO

/*Da de alta un Partido*/
CREATE PROCEDURE TP_DISENIO.altaPartido
(@tiempoYHora datetime,@nombre varchar(20))
AS
INSERT INTO TP_DISENIO.Partidos
(id_partido,fecha_hora,activo) VALUES (@tiempoYHora,@nombre,1)
GO

/*Me devuelve todos los registros de un Jugador dado el id_user*/
CREATE PROCEDURE TP_DISENIO.buscarJugador
(@id_user varchar(10))
AS
SELECT *
FROM TP_DISENIO.Jugadores
WHERE id_user=@id_user AND activo=1
GO

/*Verifica si el usuario existe, devuelve 1 en caso de éxito y 0 en caso de fallo*/
CREATE PROCEDURE TP_DISENIO.verificarUsuario
(@id_user varchar(10))
AS 
	IF EXISTS (SELECT * FROM TP_DISENIO.Jugadores WHERE id_user=@id_user)
		BEGIN
			RETURN 1		
		END
	ELSE
		BEGIN
			RETURN 0
		END
GO
/*Verifica la contraseña de un usuario, retorna 1 en caso de éxito, 0 en caso de fallo*/
CREATE PROCEDURE TP_DISENIO.verificarUserYPass
(@id_user varchar(10),@pass varchar(10))
AS
IF EXISTS (SELECT * FROM TP_DISENIO.Jugadores WHERE id_user=@id_user AND pass=@pass)
	BEGIN
		RETURN 1
	END 
ELSE
	BEGIN
		RETURN 0
	END
GO

CREATE PROCEDURE TP_DISENIO.buscarPartido
(@id_partido varchar(10))
AS
	SELECT * 
	FROM TP_DISENIO.Partidos
	WHERE id_partido=@id_partido AND activo=1
GO

/*Devuelve la cantidad de Partidos Activos*/
CREATE PROCEDURE TP_DISENIO.cantidadPartidos
AS
	SELECT COUNT(*) as cantidad
	FROM TP_DISENIO.Partidos
	WHERE activo=1
GO
/*Nota: Un partido está activo cuando no ha sido jugado todavía*/


/*Trae todas los Jugadores dado un Partido determinado*/
CREATE PROCEDURE TP_DISENIO.jugadoresPorPartido
(@id_partido varchar (10))
AS
	SELECT *
	FROM TP_DISENIO.Inscripciones as I
	JOIN TP_DISENIO.Jugadores as J ON I.id_user=J.id_user
	WHERE I.id_partido=@id_partido AND J.activo=1
GO

/*Verifica si hay jugadores dados de alta para cargarlos o no*/
CREATE PROCEDURE TP_DISENIO.hayJugadoresDadosDeAlta
AS
	IF EXISTS (SELECT * FROM TP_DISENIO.Jugadores)
		BEGIN
			RETURN 1
		END
	ELSE
		BEGIN 
			RETURN 0
		END
GO
/*Busca todos los Jugadores activos*/
CREATE PROCEDURE TP_DISENIO.Jugadores
AS
	SELECT nombre, apellido,id_user
	FROM TP_DISENIO.Jugadores
	WHERE activo=1
GO
/*Ver si solamente dejar el id_user*/

CREATE PROCEDURE TP_DISENIO.todosLosJugadoresMenosElLogueado
(@id_user varchar(10))
AS
	SELECT nombre,apellido,id_user
	FROM TP_DISENIO.Jugadores
	WHERE id_user!=@id_user
GO


CREATE PROCEDURE TP_DISENIO.altaJugador
(@nombre varchar(20),@apellido varchar(20),@fecha_nacimiento datetime,@pass varchar(10),@id_user varchar(10))
AS 
INSERT
INTO TP_DISENIO.Jugadores
(nombre,apellido,fecha_nac,pass,id_user,activo) VALUES(@nombre,@apellido,@fecha_nacimiento,@pass,@id_user,1)
GO


/*Ver que un jugador se pueda inscribir a un partido una sola vez*/
CREATE PROCEDURE TP_DISENIO.bajaDeUnPartido
(@id_partido varchar(10),@id_user varchar(10))
AS
	UPDATE TP_DISENIO.Inscripciones
	SET act
	WHERE id_partido=@id_partido AND id_user=@id_user
	

GO


SELECT *
FROM TP_DISENIO.Partidos