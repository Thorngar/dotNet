CREATE DATABASE DbToDrop;
USE DbToDrop;

CREATE TABLE TabToDrop
	(
		ID INTEGER IDENTITY(1, 1)
	);

CREATE TRIGGER TEST 
ON DATABASE 
FOR DROP_TABLE, ALTER_TABLE  
AS 
	PRINT 'Supprimer le trigger en premier'
	ROLLBACK;

ENABLE TRIGGER TEST ON DATABASE;

SELECT * FROM SYS.TRIGGERS;

USE DbToDrop;

DISABLE TRIGGER TEST ON DATABASE;
DROP TABLE TabToDrop;

-- Labo 2 --

CREATE DATABASE DB_Labo2;
USE DB_Labo2;

CREATE TABLE AddTableLog
	(
		LogID INT IDENTITY (1, 1),
		Cmand NVARCHAR(400),
		Cmdat DATE,
		[Login] NVARCHAR(50),
		Servr NVARCHAR(50)
	);

USE DB_Labo2;


USE MASTER;
CREATE TRIGGER TEST2
ON DATABASE 
FOR CREATE_TABLE  
AS 
	DECLARE @data XML
	DECLARE @command NVARCHAR(400)
	DECLARE @date DATE
	DECLARE @login NVARCHAR(50)
	DECLARE @servr NVARCHAR(50)

	SET @data = EVENTDATA()
	SET @date = CONVERT(NVARCHAR(24), @data.query('data(//PostTime)'))
	SET @command = CONVERT(NVARCHAR(400), @data.query('data(//ComandText)'))
	SET @login = CONVERT(NVARCHAR(50), @data.query('data(//UserName)'))
	SET @servr = CONVERT(NVARCHAR(50), @data.Query('data(//ServerName)'))
	
	INSERT INTO AddTableLog
	VALUES (
		@data,
		@date,
		@command,
		@login,
		@servr
		);

CREATE TABLE
