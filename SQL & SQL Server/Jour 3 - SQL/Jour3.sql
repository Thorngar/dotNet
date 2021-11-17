-- UNION (DML)

USE Labo;
GO

CREATE TABLE Fournisseur
	(
		Numero SMALLINT IDENTITY(1,1) PRIMARY KEY,
		Nom VARCHAR(50),
		CodePostal INT
	);

INSERT INTO [dbo].[Fournisseur]
	(
		[Nom],
		[CodePostal]
	)

VALUES ('Orditech', 7500),('Ingram Belgique', 1000);

SELECT Nom, Numero, Adresse, CodePostal, Ville FROM Client -- ALL = Equivalent de DISTINCT, sauf ici, utilisé pour UNION aulieu de SELECT DISTINCT
UNION ALL 
SELECT Nom, Numero, '' AS Adresse, CodePostal, NULL AS Ville FROM Fournisseur; -- ' ' ou NULL permet d'utiliser Adresse et Ville ici pour l'union

-- -- Objets SQL avancés

-- Tables temporaires

USE Labo;
GO
CREATE TABLE #Temp_Client
	(
		Numero INT,
		Nom VARCHAR(100)
	);

INSERT INTO #Temp_Client SELECT Numero, Nom FROM Client; -- Très utile pour les grosses structures, pour l'index ...

-- Procédures (semblable aux méthodes)

USE Labo;
GO

-- ALTER PROCEDURE ** SI UPDATE
CREATE PROCEDURE SP_Article_Prix_Sup @Prix FLOAT(53) AS -- SP = StoreProcedure
	BEGIN -- BEGIN, END peuvent être vus comme un { }
		SELECT A.RefArt AS Reference, A.Designation, A.Prix
		FROM Article A	WHERE A.Prix > @Prix;
	--  **UPDATE Article SET Prix = @Prix WHERE Prix IS NULL;
	END
GO 

-- Test de la procédure (stocké dans Database/Tables/Programmability/Stored Procedures)

EXEC SP_Article_Prix_Sup 1000;

-- Vues (views)

USE Labo;
GO

CREATE VIEW V_Union_Client_Fournisseur 
AS
	SELECT Nom, Numero, Adresse, CodePostal, Ville FROM Client
	UNION  
	SELECT Nom, Numero, NULL AS Adresse, CodePostal, NULL AS Ville FROM Fournisseur;
GO

SELECT * FROM V_Union_Client_Fournisseur;

--> Quelques vues système
SELECT * FROM Sys.Tables;
SELECT * FROM Sys.Key_Constraints;

-- Triggers

USE Labo;
GO

CREATE TRIGGER T_Replication_Client ON Client -- Sur quelle table celà s'applique
AFTER INSERT -- Quand celà s'applique
AS 
	BEGIN
		INSERT INTO #Temp_Client
		SELECT TOP 1 Numero, Nom FROM Client ORDER BY Numero DESC;
	END
GO

--> Test du trigger
SELECT * FROM #Temp_Client;
INSERT INTO Client(Nom) VALUES('Durando'); -- Ne fonctionne pas ici car Numero est sous CONSTRAINT avec NULL pour Numero dans la table Client
SELECT * FROM #Temp_Client;

DISABLE TRIGGER T_Replication_Client ON Client; -- ENABLE/DISABLE -> activer/désactiver le trigger
DROP TRIGGER T_Replication_Client; -- Supprimer

-- Gestion des transactions

BEGIN TRANSACTION Transaction1
	BEGIN TRY
		INSERT INTO Article(Refart, Designation, Prix, CodeTva, QuantiteStock)
		VALUES
		('4444','Article1', 130, 2, 100),
		('5294','Article2', 50, 2, 82),
		('9403','Article3', 87, 2, 30);
		SAVE TRANSACTION Transaction1; -- CHECKPOINT de la transaction, si première demande INSERT INTO validée
		INSERT INTO Article(Refart, Designation, Prix, CodeTva, QuantiteStock) -- Simulation d'une erreur
		VALUES		
		('2121','Article4', 20, 2, 22),
		('2121','Article4', 20, 2, 22);
		COMMIT TRANSACTION Transaction1;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION Transaction1;
		PRINT 'Une erreur est survenue';
		SELECT ERROR_STATE() AS Etat,
			   ERROR_MESSAGE() AS 'Message',
			   ERROR_LINE() AS Ligne,
			   ERROR_NUMBER() AS Numero,
			   ERROR_SEVERITY() AS Gravite;
	END CATCH
GO

-- Les curseurs

USE Labo;
GO

-- -- Déclaration de variables
DECLARE @Designation NVARCHAR(50);

-- 1. Déclaration du curseur
DECLARE Cursor_Designation_Article CURSOR FOR
	-- Pour une requête
	SELECT A.Designation FROM Article A;

-- 2. Ouverture du curseur
OPEN Cursor_Designation_Article;

-- 3. Exploitation des données
FETCH Cursor_Designation_Article INTO @Designation;
WHILE @@FETCH_STATUS = 0
	BEGIN -- 4. Affichage du contenu de la variable 
		PRINT @Designation
		FETCH Cursor_Designation_Article INTO @Designation;
	END

-- 5. Fermeture du curseur
CLOSE Cursor_Designation_Article;

-- 6. Libération de l'espace mémoire
DEALLOCATE Cursor_Designation_Article;

-- Exercice : pour chaque article, noter dans la console la d�signation et le prix sous cette forme :

-------------------------------
-- Article <N> : <DESIGNATION>
-- Prix : <PRIX> €
-------------------------------

