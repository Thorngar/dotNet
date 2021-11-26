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

-- Manipulation des donn�es (DML)

-- -- UPDATE

-- Mettre � jour tous les enregistrements
UPDATE Article SET Refart = 'GHMP' WHERE Refart = 'GH';

-- V�rification 
SELECT * FROM Article;

-- -- Traduction de l'alg�bre relationnelle

-- RESTRICTION
SELECT * FROM Client WHERE Numero < 10;
SELECT * FROM Client WHERE Nom LIKE 'Ets%'; -- = ou LIKE (ici LIKE veut dire �gal plus exception) EX : Ets% va ressortir Ets, puis peu importe derri�re le reste / %e% va chercher tout avant et apr�s

-- Calcul �lementaire
SELECT Designation, (QuantiteStock*Prix) AS Valorisation FROM Article; -- Va cr�er une colonne Designation, Valorisation provenant de QuantiteStock puis Prix
SELECT Designation, (QuantiteStock*Prix) AS Valorisation FROM Article WHERE (QuantiteStock*Prix) IS NOT NULL; -- Enl�ve ici les valeurs NULL dans le calcul �lementaire

-- Calcul d'agr�gat 
SELECT AVG(Prix) AS Moyenne_Prix FROM Article; -- Moyenne par rapport � Article
SELECT AVG(Prix) AS Moyenne_Prix, Categorie FROM Article GROUP BY Categorie; -- Ici, on ressort une moyenne par cat�gories
SELECT AVG(Prix) AS Moyenne_Prix, Categorie FROM Article GROUP BY Categorie HAVING AVG(Prix) > 0 ; 
--> WHERE toujours avant GROUP BY, HAVING toujours apr�s GROUP BY
--> WHERE ne prendra pas Cadeau, HAVING le prendra lui (Cadeau est � 0)

-- -- Produit cart�sien
-- Ajout de commandes :
USE Labo;
GO
INSERT INTO Commande VALUES
(1, 1, GETDATE(), 'CO'), 
(2, 1, GETDATE(), 'LI');

SELECT Commande.Numero, Client.Numero FROM Commande, Client; -- Premi�re fa�on d'appeler le Num�ro de Commande et le Num�ro du Client
SELECT Co.Numero, Cl.Numero FROM Commande Co, Client Cl; -- Deuxi�me fa�on d'appeler le Num�ro de Commande et le Num�ro du Client
SELECT Commande.Numero AS NumCom, Client.Numero AS NumCli FROM Commande, Client; -- D�finir des noms pour les tableaux gr�ce aux AS

-- Restriction sur le produit cart�sien = la jointure
-- -- Jointure interne
SELECT Co.Numero, Cl.Numero FROM Commande Co, Client Cl WHERE Cl.Numero = Co.Numero_Client; -- Premi�re �criture

-- https://tinyurl.com/25f8djna pour plus d'informations sur les jointures (sch�ma)

SELECT Co.Numero AS NumCom, Cl.Numero AS NumCli FROM Commande Co INNER JOIN Client Cl ON Cl.Numero = Co.Numero_Client;

-- -- Jointure externe
SELECT Co.Numero AS NumCom, Cl.Numero AS NumCli FROM Commande Co LEFT JOIN Client Cl ON Cl.Numero = Co.Numero_Client; -- Prendra � gauche du Join, m�me ce qui est NULL
SELECT Co.Numero AS NumCom, Cl.Numero AS NumCli FROM Commande Co RIGHT JOIN Client Cl ON Cl.Numero = Co.Numero_Client; -- Prendra � droite du Join, m�me ce qui est NULL

SELECT Co.Numero AS NumCom, Cl.Numero AS NumCli FROM Commande Co LEFT JOIN Client Cl ON Cl.Numero = Co.Numero_Client WHERE Cl.Numero IS NULL; -- Prendra � gauche du Join, uniquement ce qui ne correspond pas
SELECT Co.Numero AS NumCom, Cl.Numero AS NumCli FROM Commande Co RIGHT JOIN Client Cl ON Cl.Numero = Co.Numero_Client WHERE Co.Numero_Client IS NULL; -- Prendra � droite du Join, uniquement ce qui ne correspond pas

SELECT Co.Numero AS NumCom, Cl.Numero AS NumCli FROM Commande Co FULL OUTER JOIN Client Cl ON Cl.Numero = Co.Numero_Client; -- Prendra � droite et � gauche
SELECT Co.Numero AS NumCom, Cl.Numero AS NumCli FROM Commande Co FULL OUTER JOIN Client Cl ON Cl.Numero = Co.Numero_Client WHERE Co.Numero_Client IS NULL OR Cl.Numero IS NULL; -- Uniquement ce qui ne correspond pas, droite et gauche



