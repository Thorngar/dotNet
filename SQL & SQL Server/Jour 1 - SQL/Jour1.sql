-- Cr�ation d'une base de donn�es
CREATE DATABASE Labo;

-- Se positionner sur la DB. (Database)
USE Labo;

-- Cr�ation d'une table
CREATE TABLE Article
	(
		-- Les propri�t�s/attributs (= les colonnes) 
		Refart			CHAR(10)		PRIMARY KEY,
		Designation		VARCHAR(50),
		Prix			FLOAT(53),
		CodeTva			TINYINT,
		Categorie		CHAR(10),
		QuantiteStock	SMALLINT
	);

-- Cr�ation d'une table "client"
CREATE TABLE Client
	(
		-- Les contraintes d'attributs 
		Numero			SMALLINT	
						CONSTRAINT PK_Client			PRIMARY KEY 
						CONSTRAINT CK_Client_Numero		CHECK(Numero > 0),
		Nom				VARCHAR(50)
						CONSTRAINT NN_Client_Nom NOT NULL,
		Adresse			VARCHAR(150),
		CodePostal		INT
						CONSTRAINT CK_Client_Codepostal CHECK(CodePostal BETWEEN 1000 AND 9992),
		Ville			VARCHAR(50)
	);

-- Cr�ation d'une table "commande"
CREATE TABLE Commande
	(
		-- Les contraintes de tables
		Numero			SMALLINT,
		Numero_Client	SMALLINT, -- Attention, faire correspondre le type de donn�es = Avec celui de la table Client ici.
		"Date"			DATE, -- Double quotes pour "�chapper" le caract�re
		Etat			CHAR(2),

		-- Autre fa�on d'�crire les contraintes (� la fin)
		CONSTRAINT		PK_Commande			PRIMARY KEY(Numero),
		CONSTRAINT		FK_Commande_Client	FOREIGN KEY(Numero_Client)	REFERENCES		Client(Numero),
		CONSTRAINT		CK_Commande_Etat	CHECK(Etat IN ('CO', 'PR', 'EN', 'LI'))
	);

-- Suppression de table
CREATE TABLE Commande2
	(
		Numero			SMALLINT,
		Numero_Client	SMALLINT, 
		"Date"			DATE,
		Etat			CHAR(2),
	);

DROP TABLE Commande2;

-- Modification d'une table
ALTER TABLE Client ADD Telephone VARCHAR(15); -- Ajout d'un attribut
ALTER TABLE Client ALTER COLUMN Adresse VARCHAR(40); -- Modification d'un attribut
ALTER TABLE Article ADD CONSTRAINT CK_Article_Prix CHECK(Prix > 0); -- Ajout d'une contrainte, ici, prix sup�rieur � 0
ALTER TABLE Article DROP CONSTRAINT CK_Article_Prix; -- Suppression d'une contrainte

-- Modification du comportement des contraintes -> Activation/d�sactivation des contraintes
ALTER TABLE Client NOCHECK CONSTRAINT CK_Client_CodePostal; -- Plus besoin de check quand on ins�re des donn�es
ALTER TABLE Client CHECK CONSTRAINT CK_Client_CodePostal; -- On active(ou r�active) le check

-- Ex�cuter une proc�dure stock�e
EXEC SP_RENAME 'Client', 'Customer'; -- Renommer un objet (attention aux donn�es, type contraintes, car �a peut tout p�ter)
-- OU en plus propre
DECLARE @Old_Table VARCHAR(20); -- D�claration de variables en SQL
DECLARE @New_Table VARCHAR(20);
SET @Old_Table = 'Client'; -- Affectation de variables en SQL
SET @New_Table = 'Customer';
EXEC SP_RENAME @Old_Table, @New_Table;

EXEC SP_COLUMNS Client; -- Montre les m�tadonn�es de l'objet
EXEC SP_TABLES Commande; -- Montre les tables, � qui elle appartient 

-- Les index 
CREATE INDEX IDX_Client_Ville ON Client(Ville); -- A chaque ajout de client, une nouvelle ville va �tre stock�e et index�e au niveau de la table, tr�s utile pour la recherche
												-- Cel� cr�e un dictionnaire de donn�es. A ne pas en abuser sinon �a va �tre un bordel monstre

DROP INDEX IDX_Client_Ville ON Client; -- Suppression de l'index												
	
-- Manipulation des donn�es (DML)

-- -- INSERT
USE Labo;
GO
INSERT INTO Client(Numero, Nom)
VALUES (1, 'Ets Dupont'),(2, 'Technocit�');

-- -- SELECT
SELECT * FROM Client; -- * = TOUS LES CLIENTS