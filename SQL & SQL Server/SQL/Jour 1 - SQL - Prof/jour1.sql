-- Cr�ation d'une base de donn�es
CREATE DATABASE Labo;
GO
create database Labo2;
-- Se positionner sur la DB
USE Labo;
-- Cr�ation d'une table
create table article(
	-- les propri�t�s (= les colonnes)
	refart		char(10)	primary key,
	designation	varchar(50),
	prix		float(53),
	codetva		tinyint,
	categorie	char(10),
	qtestk		smallint
);

-- Cr�ation d'une table "client"
create table client(
	-- les propri�t�s (= les colonnes) + contraintes d'attributs
	numero		smallint identity(1,1)
		constraint pk_client primary key
		constraint ck_client_numero check(numero > 0),
	nom			varchar(50)
		constraint nn_client_nom not null,
	adresse		varchar(150),
	codepostal	int
		constraint ck_client_codepostal check(codepostal between 1000 and 9992),
	ville		varchar(50)
);

-- Cr�ation d'une table "commande"
create table commande(
	-- les propri�t�s (= les colonnes) + contraintes de table
	numero			smallint,
	numero_client	smallint, -- attention : faire correspondre les types de donn�es
	"date"			date,
	etat			char(2),
	constraint pk_commande primary key (numero),
	constraint fk_commande_client foreign key (numero_client)
		references client(numero),
	constraint ck_commande_etat check(etat in ('CO','PR','EN','LI') )
);

-- Suppression de tables
drop table commande2;

-- Modification de tables
alter table client add telephone varchar(15);
alter table client alter column adresse varchar(40);
alter table article add constraint ck_article_prix check(prix > 0);
alter table article drop constraint ck_article_prix;
-- -- modification du comportement des contraintes -> activation/desactivation
alter table client nocheck constraint ck_client_codepostal;
alter table client check constraint ck_client_codepostal;
-- ex�cuter une proc�dure stock�e
declare @old_table varchar(20); -- d�claration de variables en SQL
declare @new_table varchar(20);
set @old_table = 'client'; -- affectation de variables en SQL
set @new_table = 'customer';
exec sp_rename @old_table,@new_table; -- renommer un objet (attention aux donn�es)
exec sp_columns client;
exec sp_tables commande;

-- Les index
create index idx_client_ville on client(ville);
drop index idx_client_ville on client;

-- MANIPULATION DES DONNEES (DML)

-- -- INSERT
use Labo;
go
insert into client(numero,nom)
values (1,'Ets Dupont'),(2,'TechnocIT�');

-- -- SELECT
select * from client;
--> ne pas sp�cifier le numero : utiliser une sequence
delete from client;
truncate table client;
drop table commande;
drop table client;
-- recr�ation avec identity(1,1)
use Labo;
go
insert into client(nom)
values ('Ets Dupont'),('TechnocIT�');