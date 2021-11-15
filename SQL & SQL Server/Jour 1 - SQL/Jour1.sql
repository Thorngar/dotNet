-- Création d'une base de données
CREATE DATABASE Labo;

-- Se positionner sur la DB. (Database)
USE Labo;

-- Création d'une table
CREATE TABLE Article
	(
		-- Les propriétés/attributs (= les colonnes) 
		Refart			CHAR(10)		PRIMARY KEY,
		Designation		VARCHAR(50),
		Prix			FLOAT(53),
		CodeTva			TINYINT,
		Categorie		CHAR(10),
		QuantiteStock	SMALLINT
	);

-- Création d'une table "client"
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

-- Création d'une table "commande"
CREATE TABLE Commande
	(
		-- Les contraintes de tables
		Numero			SMALLINT,
		Numero_Client	SMALLINT, -- Attention, faire correspondre le type de données = Avec celui de la table Client ici.
		"Date"			DATE, -- Double quotes pour "échapper" le caractère
		Etat			CHAR(2),

		-- Autre façon d'écrire les contraintes (à la fin)
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
ALTER TABLE Article ADD CONSTRAINT CK_Article_Prix CHECK(Prix > 0); -- Ajout d'une contrainte, ici, prix supérieur à 0
ALTER TABLE Article DROP CONSTRAINT CK_Article_Prix; -- Suppression d'une contrainte

-- Modification du comportement des contraintes -> Activation/désactivation des contraintes
ALTER TABLE Client NOCHECK CONSTRAINT CK_Client_CodePostal; -- Plus besoin de check quand on insère des données
ALTER TABLE Client CHECK CONSTRAINT CK_Client_CodePostal; -- On active(ou réactive) le check

-- Exécuter une procédure stockée
EXEC SP_RENAME 'Client', 'Customer'; -- Renommer un objet (attention aux données, type contraintes, car ça peut tout péter)
-- OU en plus propre
DECLARE @Old_Table VARCHAR(20); -- Déclaration de variables en SQL
DECLARE @New_Table VARCHAR(20);
SET @Old_Table = 'Client'; -- Affectation de variables en SQL
SET @New_Table = 'Customer';
EXEC SP_RENAME @Old_Table, @New_Table;

EXEC SP_COLUMNS Client; -- Montre les métadonnées de l'objet
EXEC SP_TABLES Commande; -- Montre les tables, à qui elle appartient 

-- Les index 
CREATE INDEX IDX_Client_Ville ON Client(Ville); -- A chaque ajout de client, une nouvelle ville va être stockée et indexée au niveau de la table, très utile pour la recherche
												-- Celà crée un dictionnaire de données. A ne pas en abuser sinon ça va être un bordel monstre

DROP INDEX IDX_Client_Ville ON Client; -- Suppression de l'index												
	
-- Manipulation des données (DML)

-- -- INSERT
USE Labo;
GO
INSERT INTO Client(Numero, Nom)
VALUES (1, 'Ets Dupont'),(2, 'Technocité');

-- -- SELECT
SELECT * FROM Client; -- * = TOUS LES CLIENTS