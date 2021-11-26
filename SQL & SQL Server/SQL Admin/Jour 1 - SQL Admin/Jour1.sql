-- Chapitre 1 --

-- Executez étape par étape
-- Etape 0 : Relancer votre Manager si vous avez déjà une database avec le même nom --

DROP DATABASE SQLServerDBTest; -- Passer à l'étape 1 si vous avez pas de DB avec ce nom

-- Etape 1 --

CREATE DATABASE SQLServerDBTest

ON PRIMARY (NAME = 'SQLServerDBTest_Data', FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.FORMATION\MSSQL\DATA\SQLServerDBTest_Data.mdf', SIZE = 10MB, MAXSIZE = 20MB, FILEGROWTH = 0), 

FILEGROUP [Archive1]
(NAME = 'Archive1', FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.FORMATION\MSSQL\DATA\Archive1.ndf', SIZE = 100 MB, MAXSIZE = 200 MB, FILEGROWTH = 0),

FILEGROUP [Archive2] 
(NAME = 'Archive2', FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.FORMATION\MSSQL\DATA\Archive2.ndf', SIZE = 100 MB, MAXSIZE = 200 MB, FILEGROWTH = 0)

LOG ON (NAME = 'SQLServerDBTest_Log1', FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.FORMATION\MSSQL\DATA\SQLServerDBTest_Log.ldf', SIZE = 25 MB, MAXSIZE = 50 MB, FILEGROWTH = 0);
GO

USE SQLServerDBTest;
GO

CREATE SCHEMA Users;
GO

CREATE SCHEMA Systems;
GO

CREATE TABLE Users.UserInfo
	(
		ID INT NOT NULL IDENTITY (1,1),
		Nom NVARCHAR(25) NOT NULL
	)	ON [PRIMARY];

CREATE TABLE Systems.SystemConfig
	(
		ID INT NOT NULL IDENTITY (1,1),
		Config NVARCHAR(25) NOT NULL
	)	ON [PRIMARY];

CREATE TABLE OldOrders
	(
		ID INT NOT NULL IDENTITY (1,1),
		Nom NVARCHAR(25) NULL,
		Date DATETIME2 NULL
	)	ON Archive1;
GO

INSERT INTO OldOrders(Nom, Date)
VALUES ('Test', GETDATE());
GO

ALTER DATABASE SQLServerDBTest MODIFY FILEGROUP [Archive1] READ_ONLY;
GO

USE SQLServerDBTest;
GO

-- Autres --

SELECT * FROM dbo.OldOrders;

-- Chapitre 2 --

SELECT DATABASEPROPERTYEX ('SQLServerDBTest', 'UserAccess');
ALTER DATABASE SQLServerDBTest SET SINGLE_USER;

-- Labo 2 --

SELECT * FROM Sys.Database_files

EXEC SP_DATABASES;
EXEC SP_HELPDB 'SQLServerDBTest'; 
EXEC SP_SPACEUSED '[dbo].[OldOrders]';

-- Créer un script capable de récupérer les colonnes d'une table donnée

SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'UserInfo';
GO

-- OU

EXEC SP_COLUMNS 'UserInfo';
GO

-- Chapitre 3 --

CREATE LOGIN Roger WITH PASSWORD = 'Robert' MUST_CHANGE, 
DEFAULT_DATABASE = SQLServerDBTest, 
CHECK_EXPIRATION = ON, 
CHECK_POLICY = ON;

USE MASTER GRANT ALTER ANY DATABASE TO Roger;

SELECT CASE SERVERPROPERTY('IsIntegratedSecurityOnly')
WHEN 0 THEN 'Windows and SQL Authentification'
WHEN 1 THEN 'Windows Authentification'
END AS [Authentification Mode]

--

CREATE LOGIN Test1 WITH PASSWORD = 'Essai', DEFAULT_DATABASE = [SQLServerDBTest];
GO

CREATE USER Paul FOR LOGIN Test1; 
GO

EXEC SP_ADDROLEMEMBER @rolename = 'DB_DataReader', @membername = 'Paul';
GO

GO