
USE master;

--Création d'une base de données
DECLARE @database varchar(30);
SET @database = 'MySociety';
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = @database)
BEGIN
	CREATE DATABASE MySociety;
END
GO

--Switch sur la DB
USE MySociety;
GO

--Création de la table 'services'
DECLARE @table varchar(30);
SET @table = 'services';
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = @table)
BEGIN
	CREATE TABLE [services](
		ID			tinyint IDENTITY(1,1)
			CONSTRAINT PK_SERVICES PRIMARY KEY
			CONSTRAINT CK_SERVICES_ID CHECK (ID > 0),
		Number		smallint
			CONSTRAINT CK_SERVICES_NUMBER CHECK (Number > 0)
			CONSTRAINT NN_SERVICES_NUMBER NOT NULL,
		Name		varchar(50)
			CONSTRAINT NN_SERVICES_NAME NOT NULL,
		[Description]	varchar(MAX),
		Place		varchar(50)
			CONSTRAINT NN_SERVICES_PLACE NOT NULL
	);
END
GO

--Création de la table 'employees'
DECLARE @table varchar(30);
SET @table = 'employees';
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = @table)
BEGIN
	CREATE TABLE employees(
		ID			smallint IDENTITY(1,1)
			CONSTRAINT PK_EMPLOYEES PRIMARY KEY
			CONSTRAINT CK_EMPLOYEES_ID CHECK (ID > 0),
		Name		varchar(80)
			CONSTRAINT NN_EMPLOYEES_NAME NOT NULL,
		Firstname	varchar(80)
			CONSTRAINT NN_EMPLOYEES_FIRSTNAME NOT NULL,
		EMail		varchar(100),
		IDService	tinyint
			CONSTRAINT FK_EMPLOYEES_SERVICES FOREIGN KEY REFERENCES [services](ID)
			CONSTRAINT CK_EMPLOYEES_IDSERVICE CHECK (IDService > 0)
	);
END
GO
CREATE INDEX IK_EMPLOYEES_IDSERVICE ON employees(IDService);
GO

--Création de la table 'states'
DECLARE @table varchar(30);
SET @table = 'states';
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = @table)
BEGIN
	CREATE TABLE states(
		ID			smallint IDENTITY(1,1)
			CONSTRAINT PK_STATES PRIMARY KEY
			CONSTRAINT CK_STATES_ID CHECK (ID > 0),
		Name		varchar(30)
			CONSTRAINT NN_STATES_NAME NOT NULL,
		[Description]	text
	);
END
GO

--Création de la table 'tickets'
DECLARE @table varchar(30);
SET @table = 'tickets';
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = @table)
BEGIN
	CREATE TABLE tickets(
		ID			smallint IDENTITY(1,1)
			CONSTRAINT PK_TICKETS PRIMARY KEY
			CONSTRAINT CK_TICKETS_ID CHECK (ID > 0),
		[Date]		datetime DEFAULT GETDATE(),
		IDEmployee	smallint
			CONSTRAINT FK_TICKETS_EMPLOYEES FOREIGN KEY REFERENCES employees(ID)
			CONSTRAINT CK_TICKETS_IDEMPLOYEE CHECK (IDEmployee > 0),
		ProblemObject	text
			CONSTRAINT NN_TICKETS_PROBLEMOBJECT NOT NULL,
		IDState		smallint DEFAULT 1
			CONSTRAINT FK_TICKETS_STATES FOREIGN KEY REFERENCES states(ID)
			CONSTRAINT CK_TICKETS_IDSTATE CHECK (IDState > 0)
	);
END
GO
CREATE INDEX IK_TICKETS_IDEMPLOYEE ON tickets(IDEmployee);
GO
CREATE INDEX IK_TICKETS_IDSTATE ON tickets(IDState);
GO

--Création de la table 'interventions'
DECLARE @table varchar(30);
SET @table = 'interventions';
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = @table)
BEGIN
	CREATE TABLE interventions(
		ID			smallint IDENTITY(1,1)
			CONSTRAINT PK_INTERVENTIONS PRIMARY KEY
			CONSTRAINT CK_INTERVENTIONS_ID CHECK (ID > 0),
		DatePlanning	datetime DEFAULT DATEADD(dd, 1, GETDATE()),
		DateClosing		datetime,
		ProblemExplanation	text
			CONSTRAINT NN_INTERVENTIONS_PROBLEMEXPLANATION NOT NULL,
		IDEmployee		smallint
			CONSTRAINT FK_INTERVENTIONS_EMPLOYEES FOREIGN KEY REFERENCES employees(ID)
			CONSTRAINT CK_INTERVENTIONS_IDEMPLOYEE CHECK (IDEmployee > 0),
		IDTicket		smallint
			CONSTRAINT FK_INTERVENTIONS_TICKETS FOREIGN KEY REFERENCES tickets(ID)
			CONSTRAINT CK_INTERVENTIONS_IDTICKET CHECK (IDTicket > 0)
	);
END
GO
CREATE INDEX IK_INTERVENTIONS_IDEMPLOYEE ON interventions(IDEmployee);
GO
CREATE INDEX IK_INTERVENTIONS_IDTICKET ON interventions(IDTicket);
GO
