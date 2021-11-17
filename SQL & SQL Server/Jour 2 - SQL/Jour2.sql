USE Labo;
GO
INSERT INTO Article(Refart, Designation, Prix, CodeTva, Categorie, QuantiteStock)
VALUES
('AB22', 'Tapis persan', 1250.10, 2, 'IMPORT', 5),
('CD50', 'Chaine HiFi', 735.40, 2, 'IMPORT', 7),
('ZZZZ', 'Article bidon', DEFAULT, DEFAULT, 'DIVERS', 25),
('AA00', 'Cadeau', 0.00, 2, 'DIVERS', 8),
('AB03', 'Essuis mains', 19.30, 2, 'SOLDES', 116),
('GH', 'Table basse', DEFAULT, 2, 'DIVERS', 2),
('ERTU', 'Ecran plat 27 pouces', 305.10, 2, 'IMPORT', 10),
('NBP8', 'Matelas', 263.25, 2, 'IMPORT', 18);

-- Manipulation des données (DML)

-- -- UPDATE

-- Mettre à jour tous les enregistrements
UPDATE Article SET Refart = 'GHMP' WHERE Refart = 'GH';

-- Vérification 
SELECT * FROM Article;

-- -- Traduction de l'algèbre relationnelle

-- RESTRICTION
SELECT * FROM Client WHERE Numero < 10;
SELECT * FROM Client WHERE Nom LIKE 'Ets%'; -- = ou LIKE (ici LIKE veut dire égal plus exception) EX : Ets% va ressortir Ets, puis peu importe derrière le reste / %e% va chercher tout avant et après

-- Calcul élementaire
SELECT Designation, (QuantiteStock*Prix) AS Valorisation FROM Article; -- Va créer une colonne Designation, Valorisation provenant de QuantiteStock puis Prix
SELECT Designation, (QuantiteStock*Prix) AS Valorisation FROM Article WHERE (QuantiteStock*Prix) IS NOT NULL; -- Enlève ici les valeurs NULL dans le calcul élementaire

-- Calcul d'agrégat 
SELECT AVG(Prix) AS Moyenne_Prix FROM Article; -- Moyenne par rapport à Article
SELECT AVG(Prix) AS Moyenne_Prix, Categorie FROM Article GROUP BY Categorie; -- Ici, on ressort une moyenne par catégories
SELECT AVG(Prix) AS Moyenne_Prix, Categorie FROM Article GROUP BY Categorie HAVING AVG(Prix) > 0 ; 
--> WHERE toujours avant GROUP BY, HAVING toujours après GROUP BY
--> WHERE ne prendra pas Cadeau, HAVING le prendra lui (Cadeau est à 0)

-- -- Produit cartésien
-- Ajout de commandes :
USE Labo;
GO
INSERT INTO Commande VALUES
(1, 1, GETDATE(), 'CO'), 
(2, 1, GETDATE(), 'LI');

SELECT Commande.Numero, Client.Numero FROM Commande, Client; -- Première façon d'appeler le Numéro de Commande et le Numéro du Client
SELECT Co.Numero, Cl.Numero FROM Commande Co, Client Cl; -- Deuxième façon d'appeler le Numéro de Commande et le Numéro du Client
SELECT Commande.Numero AS NumCom, Client.Numero AS NumCli FROM Commande, Client; -- Définir des noms pour les tableaux grâce aux AS

-- Restriction sur le produit cartésien = la jointure
-- -- Jointure interne
SELECT Co.Numero, Cl.Numero FROM Commande Co, Client Cl WHERE Cl.Numero = Co.Numero_Client; -- Première écriture

-- https://tinyurl.com/25f8djna pour plus d'informations sur les jointures (schéma)

SELECT Co.Numero AS NumCom, Cl.Numero AS NumCli FROM Commande Co INNER JOIN Client Cl ON Cl.Numero = Co.Numero_Client;

-- -- Jointure externe
SELECT Co.Numero AS NumCom, Cl.Numero AS NumCli FROM Commande Co LEFT JOIN Client Cl ON Cl.Numero = Co.Numero_Client; -- Prendra à gauche du Join, même ce qui est NULL
SELECT Co.Numero AS NumCom, Cl.Numero AS NumCli FROM Commande Co RIGHT JOIN Client Cl ON Cl.Numero = Co.Numero_Client; -- Prendra à droite du Join, même ce qui est NULL

SELECT Co.Numero AS NumCom, Cl.Numero AS NumCli FROM Commande Co LEFT JOIN Client Cl ON Cl.Numero = Co.Numero_Client WHERE Cl.Numero IS NULL; -- Prendra à gauche du Join, uniquement ce qui ne correspond pas
SELECT Co.Numero AS NumCom, Cl.Numero AS NumCli FROM Commande Co RIGHT JOIN Client Cl ON Cl.Numero = Co.Numero_Client WHERE Co.Numero_Client IS NULL; -- Prendra à droite du Join, uniquement ce qui ne correspond pas

SELECT Co.Numero AS NumCom, Cl.Numero AS NumCli FROM Commande Co FULL OUTER JOIN Client Cl ON Cl.Numero = Co.Numero_Client; -- Prendra à droite et à gauche
SELECT Co.Numero AS NumCom, Cl.Numero AS NumCli FROM Commande Co FULL OUTER JOIN Client Cl ON Cl.Numero = Co.Numero_Client WHERE Co.Numero_Client IS NULL OR Cl.Numero IS NULL; -- Uniquement ce qui ne correspond pas, droite et gauche



