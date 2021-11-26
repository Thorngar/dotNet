-- UNION (DML)
create table fournisseur(
	-- les propriétés (= les colonnes) + contraintes d'attributs
	numero		smallint identity(1,1) primary key,
	nom			varchar(50),
	codepostal	int
);
INSERT INTO [dbo].[fournisseur]
           ([nom]
           ,[codepostal])
     VALUES
           ('Orditech',7500),('Ingram Belgique',1000);
GO
use Labo;
go
select nom, numero, adresse, codepostal, ville
from client
union
select nom, numero, null as adresse, codepostal, null as ville
from fournisseur;


-- Objets SQL avancés

-- -- Tables temporaires
use Labo;
go
create table #temp_client(
	numero int,
	nom		varchar(100)
);

insert into #temp_client
select numero, nom from client;

select * from #temp_client;

-- -- Procédures
use Labo;
go
create procedure sp_articles_prix_sup
	@prix float(53)
as
begin
	select a.refart as reference, a.designation, a.prix
	from article a where a.prix > @prix;
	update article set prix = @prix where prix is null;
end
go
-- > exécution de la procédure
exec sp_articles_prix_sup 100;

-- -- Vues
use Labo;
go
create view v_union_client_fournisseur
as
	select nom, numero, adresse, codepostal, ville
	from client
	union
	select nom, numero, null as adresse, codepostal, null as ville
	from fournisseur;
go
select * from v_union_client_fournisseur;
-- > quelques vues systèmes
select * from sys.tables;
select * from sys.key_constraints;

-- -- Triggers
use Labo;
go
create trigger t_replication_client
on client -- sur quelle table cela s'applique
after insert -- quand cela s'applique
as
begin
	insert into #temp_client
	select top 1 numero, nom from client order by numero desc;
end
go
-- > tester le trigger
select * from #temp_client;
insert into client (nom) values ('Durand');
select * from #temp_client;
select * from sys.triggers;

disable trigger t_replication_client on client; -- désactiver
select * from #temp_client;
insert into client (nom) values ('Test');
select * from #temp_client;
enable trigger t_replication_client on client; -- activer
drop trigger t_replication_client; -- supprimer

-- -- Gestion des transactions
begin transaction transaction1
	begin try
		insert into article (refart, designation, prix, codetva, qtestk ) values
		('4444','article1',130,2,100),
		('5425','article2',50,2,52),
		('6874','article3',87,2,2);
		insert into article (refart, designation, prix, codetva, qtestk ) values -- simulation d'une erreur
		('2121','article4',20,2,20),
		('2121','article4',20,2,20);
		commit transaction transaction1;
	end try
	begin catch
		rollback transaction transaction1;
		print 'une erreur est survenue';
		select
		ERROR_STATE() as etat,
		ERROR_MESSAGE() as 'message',
		ERROR_LINE() as ligne,
		ERROR_NUMBER() as numero,
		ERROR_SEVERITY() as gravite;
	end catch
go

-- -- Les curseurs
use Labo;
go
-- déclaration de variables
declare @designation nvarchar(50);
-- 1. déclaration du curseur
declare cursor_designation_article cursor for
	-- pour une requête
	select a.designation from article a;
-- 2. ouverture du curseur
open cursor_designation_article;
-- 3. exploitation des données
fetch cursor_designation_article into @designation;
while @@FETCH_STATUS = 0
begin
	-- 4. affichage du contenu de la variable
	print @designation;
	fetch cursor_designation_article into @designation;
end
-- 5. fermeture du curseur
close cursor_designation_article;
-- 6. libération de l'espace mémoire
deallocate cursor_designation_article;

-- Exercice : pour chaque article, noter dans la console la désignation et le prix sous
------------- cette forme :
-------------------------------
-- Article <N> : <DESIGNATION>
-- Prix : <PRIX> €
-------------------------------
