-- Requ�tes imbriqu�es

USE Labo;
GO
SELECT Client.Numero, Client.Nom FROM Client WHERE Client.Numero IN(SELECT Commande.Numero FROM Commande);


-- Requ�tes corr�l�es

SELECT Client.Numero, Client.Nom FROM Client WHERE Client.Numero IN(SELECT Commande.Numero_Client FROM Commande WHERE Client.CodePostal = 7500);

