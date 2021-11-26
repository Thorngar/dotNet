-- Partie 1 --
DROP DATABASE Hospital;

CREATE DATABASE Hospital;
GO

USE Hospital;
GO

CREATE LOGIN doc1 WITH 
PASSWORD = 'P@ssw0rd',
DEFAULT_DATABASE = [Hospital] ;
GO


CREATE LOGIN doc2 WITH 
PASSWORD = 'P@ssw0rd',
DEFAULT_DATABASE = [Hospital] ;
GO

CREATE USER Doctor1 FOR LOGIN doc1;
GO
CREATE USER Doctor2 FOR LOGIN doc2;
GO

--SELECT * FROM SYS.SERVER_PRINCIPALS;

CREATE TABLE Patient
	(
		ID INTEGER NOT NULL IDENTITY(1,1),
		Nom NVARCHAR(20) NOT NULL,
		Docname NVARCHAR(15),
		Problem VARBINARY(5000)
	);
GO

GRANT SELECT, INSERT ON Patient TO Doctor1, Doctor2;
GO

-- Partie 2 --

USE Hospital;
GO

CREATE MASTER KEY ENCRYPTION BY PASSWORD = 'P@ssw0rd'; 
GO

-- ALTER MASTER KEY REGENERATE WITH ENCRYPTION BY PASSWORD = 'P@ssw0rd'; 

CREATE CERTIFICATE DoctorCertificate 
	AUTHORIZATION Doctor1  
	WITH SUBJECT = 'Doc1Cert'; 
GO

CREATE CERTIFICATE DoctorCertificate2 
	AUTHORIZATION Doctor2  
	WITH SUBJECT = 'Doc2Cert'; 
GO

CREATE SYMMETRIC KEY DoctorKey1 
	AUTHORIZATION Doctor1 
	WITH ALGORITHM = AES_256 
	ENCRYPTION BY CERTIFICATE Doc1Cert;
GO

CREATE SYMMETRIC KEY DoctorKey2 
	AUTHORIZATION Doctor2 
	WITH ALGORITHM = AES_256 
	ENCRYPTION BY CERTIFICATE Doc2Cert;
GO

SELECT * FROM SYS.symmetric_keys;

-- SELECT * FROM SYS.CERTIFICATES;
-- SELECT * FROM SYS.OPENKEYS;

-- Partie 3 --

USE Hospital;

EXECUTE AS LOGIN = 'doc1';

OPEN SYMMETRIC KEY DoctorKey1 DECRYPTION BY CERTIFICATE Doc1Cert WITH PASSWORD = 'P@ssw0rd';
GO

SELECT * FROM SYS.openkeys;

INSERT INTO Hospital.dbo.Patient
VALUES(
	'Jeremie',
	'Doc1',
	ENCRYPTBYKEY(KEY_GUID('Doc1Key'), 'Migraine'));
GO

INSERT INTO Hospital.dbo.Patient
VALUES(
	'Charles',
	'Doc1',
	ENCRYPTBYKEY(KEY_GUID('Doc1Key'), 'Maux de ventre'));
GO

INSERT INTO Hospital.dbo.Patient
VALUES(
	'Albert',
	'Doc1',
	ENCRYPTBYKEY(KEY_GUID('Doc1Key'), 'Vomissemnts'));
GO

CLOSE ALL SYMMETRIC KEYS;

REVERT; -- Fermeture de la session en tant que doc1

EXECUTE AS LOGIN = 'doc2';
GO

OPEN SYMMETRIC KEY DoctorKey2 DECRYPTION BY CERTIFICATE Doc2Cert WITH PASSWORD = 'P@ssw0rd';
GO

SELECT * FROM SYS.openkeys;

INSERT INTO Hospital.dbo.Patient
VALUES(
	'Roger',
	'Doc2',
	ENCRYPTBYKEY(KEY_GUID('Doc2Key'), 'Douleur au dos'));
GO

INSERT INTO Hospital.dbo.Patient
VALUES(
	'Robert',
	'Doc2',
	ENCRYPTBYKEY(KEY_GUID('Doc2Key'), 'Nez qui coule'));
GO

CLOSE ALL SYMMETRIC KEYS;

REVERT;

SELECT * FROM Hospital.dbo.Patient;

EXECUTE AS LOGIN = 'doc1';
OPEN SYMMETRIC KEY Doc1Key DECRYPTION BY CERTIFICATE Doc1Cert;

SELECT ID, Nom, Docname, CONVERT(VARCHAR, DECRYPTBYKEY(Problem)) AS Problem FROM Hospital.dbo.Patient;
GO

CLOSE ALL SYMMETRIC KEYS;
REVERT;
GO

-- Pour les cl�s asym�triques

-- ENCRYPTBYASYMKEY(ASYMKEY_ID()); au lieu de ENCRYPTBYKEY(KEY_GUID());

-- Labo - Exercice 2 --

CREATE DATABASE Db_encryptionTest
ON PRIMARY(NAME = 'Db_encryptionTest_data', FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.FORMATION\MSSQL\DATA\Db_encryptionTest_data.mdf')
LOG ON(NAME = 'Db_encryptionTest_log', FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.FORMATION\MSSQL\DATA\Db_encryptionTest_log.ldf');

USE Db_encryptionTest;

CREATE LOGIN Login1 WITH PASSWORD = 'P@ssw0rd', DEFAULT_DATABASE = Db_encryptionTest;

CREATE USER User1 FOR LOGIN Login1;

CREATE TABLE TAB1 
	(
		ID INT NOT NULL IDENTITY(1,1),
		Name VARBINARY(200)
	)	ON [PRIMARY];

DROP TABLE TAB1;

GRANT SELECT, INSERT ON TAB1 TO User1;

CREATE MASTER KEY ENCRYPTION BY PASSWORD = 'P@ssw0rd';

CREATE CERTIFICATE Certificat1 
	AUTHORIZATION User1
	WITH SUBJECT = 'User1Cert';


CREATE SYMMETRIC KEY Key1 
	AUTHORIZATION User1 
	WITH ALGORITHM = AES_256 
	ENCRYPTION BY CERTIFICATE Certificat1;

OPEN SYMMETRIC KEY Key1 DECRYPTION BY CERTIFICATE Certificat1;

SELECT * FROM SYS.OPENKEYS;

INSERT INTO TAB1
	VALUES (ENCRYPTBYKEY(KEY_GUID('Key1'), '111'));

SELECT * FROM TAB1;

SELECT ID, CONVERT (VARCHAR, DECRYPTBYKEY(Name)) FROM TAB1;

-- Backup --

CREATE DATABASE DbBackupTest

ON PRIMARY (NAME = 'DbBackupTest', FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.FORMATION\MSSQL\DATA\DbBackupTest_Data.mdf', SIZE = 10MB, MAXSIZE = 20MB, FILEGROWTH = 0), 

FILEGROUP [Archive]
(NAME = 'Archive', FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.FORMATION\MSSQL\DATA\Archive.ndf', SIZE = 100 MB, MAXSIZE = 200 MB, FILEGROWTH = 0);

USE DbBackupTest;

CREATE TABLE Tab1
	(
		ID INT IDENTITY(1,1),
		Name VARCHAR(50),
		Description VARCHAR(255)
	) ON [PRIMARY];

CREATE TABLE Tab2
	(
		ID INT IDENTITY(1,1),
		Name VARCHAR(50),
		Description VARCHAR(255)
	) ON [Archive];

INSERT INTO Tab1 (Name, Description)
	VALUES ('EssaiTab1', 'Ceci est un essai!');

INSERT INTO Tab2 (Name, Description)
	VALUES ('EssaiTab2', 'Ceci est encore un essai!');

ALTER DATABASE [DbBackupTest] SET RECOVERY FULL;

USE MASTER;

EXEC SP_ADDUMPDEVICE 'disk', 'DbBackupTestBack', 'C:\Users\s_11083_devnet\Desktop\Admin SQL SERVER 19\DbBackupTestBack.bak';

BACKUP DATABASE DbBackupTest TO DbBackupTestBack;

