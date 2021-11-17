CREATE DATABASE Exercice;
USE Exercice;

-- Exercice 1.1 --

CREATE TABLE T_office
(office_id INTEGER, office_adress VARCHAR(30), CONSTRAINT PK_office PRIMARY KEY(office_id))

CREATE TABLE T_course
(crs_code CHAR(8) NOT NULL PRIMARY KEY, crs_name VARCHAR(30), CONSTRAINT UK_crs UNIQUE(crs_name))
-- (crs_code CHAR(8) NOT NULL PRIMARY KEY, crs name VARCHAR(30) CONSTRAINT UK_crs UNIQUE(crs_name))
-- crs_name au lieu de crs name

CREATE TABLE T_professor
(prf_id INTEGER NOT NULL PRIMARY KEY, prf_name VARCHAR(30), prf_course CHAR(8) CONSTRAINT PK_course REFERENCES T_course (crs_code) 
ON DELETE SET NULL, office_id INTEGER REFERENCES T_office, CONSTRAINT prf_name UNIQUE (prf_name));

-- Exercie 1.2 --

CREATE TABLE T_Maintenance_Mtn
	(
		Jour		CHAR(3)		CHECK (Jour IN ('Lun','Mar','Mer','Jeu','Ven','Sam','Dim'),
		Machine		CHAR(10)	NOT NULL, 
		Numero		INTEGER, 
		Vitesse		INTEGER, 
		Temperature	INTEGER,
		Heure		TIME, 
		Evenement	VARCHAR(100)
		CONSTRAINT	PK_Maintenance		PRIMARY KEY (Numero),
		CONSTRAINT	UK_Machine_Heure	UNIQUE (Machine, Heure)
	);

-- Exercice 1.3 --

CREATE TABLE T_Fabriquant_Fbq
	(
		Numero			SMALLINT						
						CONSTRAINT PK_Fabriquant_Fbq	PRIMARY KEY 
	);

CREATE TABLE T_Taux_TVA
	(
		Numero			SMALLINT						
						CONSTRAINT PK_Taux_TVA			PRIMARY KEY
	);

CREATE TABLE T_Rayon_Ryn
	(
		Numero			SMALLINT						
						CONSTRAINT PK_Rayon_Ryn			PRIMARY KEY 
	);

CREATE TABLE T_Produit_Pdt
	(
		Numero						SMALLINT,
		Numero_T_Fabriquant_Fbq		SMALLINT,
		Numero_T_Taux_TVA			SMALLINT,
		Numero_T_Rayon_Ryn			SMALLINT,

		CONSTRAINT		FK_T_Produit_Pdt	FOREIGN KEY(Numero_T_Fabriquant_Fbq)	REFERENCES		T_Fabriquant_Fbq(Numero),
		CONSTRAINT		FK_T_Taux_TVA		FOREIGN KEY(Numero_T_Taux_TVA)			REFERENCES		T_Taux_TVA(Numero),
		CONSTRAINT		FK_T_Rayon_Ryn		FOREIGN KEY(Numero_T_Rayon_Ryn)			REFERENCES		T_Rayon_Ryn(Numero)
	);

-- Exercice 1.4 --

-- Carburant ID  17 et 14, ne peuvent être NULL
-- Carburant ID 7 utilise 'GPL' qui n'existe pas dans la table
-- Puissance ID 31, devrait être 7 et non '7'

-- Exercice 1.5 --

CREATE DATABASE Technocite;
USE Technocite;

CREATE TABLE section (
  section_id int NOT NULL,
  section_name varchar(50),
  delegate_id int
  CONSTRAINT PK_section PRIMARY KEY (section_id)
);
 
CREATE TABLE professor (
  professor_id int NOT NULL,
  professor_name varchar(30) NOT NULL,
  professor_surname varchar(30) NOT NULL,
  section_id int NOT NULL,
  professor_office int NOT NULL,
  professor_email varchar(30) NOT NULL,
  professor_hire_date datetime NOT NULL,
  professor_wage int NOT NULL,
  CONSTRAINT PK_professor PRIMARY KEY (professor_id),
  CONSTRAINT FK_professor_section foreign key (section_id) references section (section_id)
);
 
CREATE TABLE course (
  course_id varchar(8) NOT NULL ,
  course_name varchar(200) NOT NULL ,
  course_ects decimal(3,1) NOT NULL,
  professor_id int NOT NULL,
  CONSTRAINT PK_course PRIMARY KEY (course_id),
  CONSTRAINT FK_course_professor foreign key (professor_id) references professor (professor_id)
);
 
CREATE TABLE student (
  student_id int NOT NULL,
  first_name varchar(50),
  last_name varchar(50),
  birth_date datetime,
  login varchar(50),
  section_id int,
  year_result int,
  course_id varchar(6) NOT NULL,
  CONSTRAINT PK_student PRIMARY KEY (student_id),
  CONSTRAINT FK_student_section foreign key (section_id) references section (section_id)
);
 
CREATE TABLE grade (
  grade char(2) NOT NULL ,
  lower_bound int NOT NULL,
  upper_bound int NOT NULL,
  CONSTRAINT PK_grade PRIMARY KEY (grade)
);

BEGIN TRANSACTION;
USE technocite;
DELETE FROM section
DELETE FROM professor
DELETE FROM course
DELETE FROM student
DELETE FROM grade
 
INSERT INTO section VALUES (1010, 'BSc Management', 12);
INSERT INTO section VALUES (1020, 'MSc Management', 9);
INSERT INTO section VALUES (1110, 'BSc Economics', 15);
INSERT INTO section VALUES (1120, 'MSc Economics', 6);
INSERT INTO section VALUES (1310, 'BA Sociology', 23);
INSERT INTO section VALUES (1320, 'MA Sociology', 6);
 
INSERT INTO professor VALUES (1, 'zidda', 'pietro', 1020, 402, 'pzidda', '2004-12-11', 1900);
INSERT INTO professor VALUES (2, 'decrop', 'alain', 1120, 403, 'adecrop', '2003-05-09', 1950);
INSERT INTO professor VALUES (3, 'giot', 'pierre', 1310, 404, 'pgiot', '2002-12-21', 2100);
INSERT INTO professor VALUES (4, 'lecourt', 'christelle', 1310, 406, 'clecourt', '2003-05-07', 1750);
INSERT INTO professor VALUES (5, 'scheppens', 'georges', 1020, 410, 'gscheppens', '1986-10-09', 2450);
INSERT INTO professor VALUES (6, 'louveaux', 'francois', 1110, 407, 'flouveaux', '1990-05-07', 2200);
 
INSERT INTO course VALUES ('EING2234', 'Derivatives', 3.0, 3);
INSERT INTO course VALUES ('ECGE2184', 'Marketing management', 3.5, 2);
INSERT INTO course VALUES ('EING2283', 'Marketing engineering', 4.0, 1);
INSERT INTO course VALUES ('ECGE2183', 'Financial Management', 4.0, 3);
INSERT INTO course VALUES ('EING2383', 'Supply chain management et e-business', 2.5, 5);
 
INSERT INTO student VALUES (1, 'Georges', 'Lucas', '1944-05-17 00:00:00', 'glucas', 1320, 10, 'EG2210');
INSERT INTO student VALUES (2, 'Clint', 'Eastwood', '1930-05-31 00:00:00', 'ceastwoo', 1010, 4, 'EG2210');
INSERT INTO student VALUES (3, 'Sean', 'Connery', '1930-08-25 00:00:00', 'sconnery', 1020, 12, 'EG2110');
INSERT INTO student VALUES (4, 'Robert', 'De Niro', '1943-08-17 00:00:00', 'rde niro', 1110, 3, 'EG2210');
INSERT INTO student VALUES (5, 'Kevin', 'Bacon', '1958-07-08 00:00:00', 'kbacon', 1120, 16, '0');
INSERT INTO student VALUES (6, 'Kim', 'Basinger', '1953-12-08 00:00:00', 'kbasinge', 1310, 19, '0');
INSERT INTO student VALUES (7, 'Johnny', 'Depp', '1963-06-09 00:00:00', 'jdepp', 1110, 11, 'EG2210');
INSERT INTO student VALUES (8, 'Julia', 'Roberts', '1967-10-28 00:00:00', 'jroberts', 1120, 17, '0');
INSERT INTO student VALUES (9, 'Natalie', 'Portman', '1981-06-09 00:00:00', 'nportman', 1010, 4, 'EG2210');
INSERT INTO student VALUES (10, 'Georges', 'Clooney', '1961-05-06 00:00:00', 'gclooney', 1020, 4, 'EG2110');
INSERT INTO student VALUES (11, 'Andy', 'Garcia', '1956-04-12 00:00:00', 'agarcia', 1110, 19, '0');
INSERT INTO student VALUES (12, 'Bruce', 'Willis', '1955-03-19 00:00:00', 'bwillis', 1010, 6, 'EG2210');
INSERT INTO student VALUES (13, 'Tom', 'Cruise', '1962-07-03 00:00:00', 'tcruise', 1020, 4, 'EG2110');
INSERT INTO student VALUES (14, 'Reese', 'Witherspoon', '1976-03-22 00:00:00', 'rwithers', 1020, 7, 'EG1020');
INSERT INTO student VALUES (15, 'Sophie', 'Marceau', '1966-11-17 00:00:00', 'smarceau', 1110, 6, '0');
INSERT INTO student VALUES (16, 'Sarah', 'Michelle Gellar', '1977-04-14 00:00:00', 'smichell', 1020, 7, 'EG2110');
INSERT INTO student VALUES (17, 'Alyssa', 'Milano', '1972-12-19 00:00:00', 'amilano', 1110, 7, '0');
INSERT INTO student VALUES (18, 'Jennifer', 'Garner', '1972-04-17 00:00:00', 'jgarner', 1120, 18, '0');
INSERT INTO student VALUES (19, 'Michael J.', 'Fox', '1969-06-20 00:00:00', 'mfox', 1310, 3, '0');
INSERT INTO student VALUES (20, 'Tom', 'Hanks', '1956-07-09 00:00:00', 'thanks', 1020, 8, 'EG2110');
INSERT INTO student VALUES (21, 'David', 'Morse', '1953-10-11 00:00:00', 'dmorse', 1110, 2, '0');
INSERT INTO student VALUES (22, 'Sandra', 'Bullock', '1964-07-26 00:00:00', 'sbullock', 1010, 2, 'EG1020');
INSERT INTO student VALUES (23, 'Keanu', 'Reeves', '1964-09-02 00:00:00', 'kreeves', 1020, 10, 'EG2210');
INSERT INTO student VALUES (24, 'Shannen', 'Doherty', '1971-04-12 00:00:00', 'sdoherty', 1320, 2, 'EG2120');
INSERT INTO student VALUES (25, 'Halle', 'Berry', '1966-08-14 00:00:00', 'hberry', 1320, 18, 'EG2210');
 
INSERT INTO grade VALUES ('IG', 0, 7);
INSERT INTO grade VALUES ('I', 8, 9);
INSERT INTO grade VALUES ('F', 10, 11);
INSERT INTO grade VALUES ('S', 12, 13);
INSERT INTO grade VALUES ('B', 14, 15);
INSERT INTO grade VALUES ('TB', 16, 17);
INSERT INTO grade VALUES ('E', 18, 20);

COMMIT;
 
-- Exercice 2.1.1 --
USE Technocite;

-- SELECT last_name, first_name AS F name FROM student; -- Placer "F name" si on veut garder l'espace
SELECT last_name, first_name AS Fname FROM student; -- Correction

SELECT last_name lname, first_name AS fname FROM student; -- Valide

-- SELECT last_name|| _ ||first_name AS name FROM student;
SELECT last_name + '_' + first_name AS name FROM student; -- | non possible ici

-- SELECT last_name+first_name AS name, Year_result x 10 result, FROM student;
SELECT last_name+first_name AS name, Year_result * 10 result FROM student; -- Correction

-- Exercice 2.1.2 --

SELECT last_name, birth_date, login, year_result FROM student;

-- Exercice 2.1.3 --

SELECT last_name + '' + first_name AS 'Nom complet', student_id, birth_date FROM student;

-- Exercice 2.1.4 --

SELECT CONVERT(VARCHAR, student_id) + '|' + last_name + '|' + first_name + '|' + 
	   CONVERT(VARCHAR,birth_date) + '|' + login + '|' + 
	   CONVERT(VARCHAR, section_id) + '|' + 
	   CONVERT(VARCHAR,year_result) AS 'Info Etudiant' FROM student;

-- Exercice 2.2.1 --

SELECT login, year_result FROM student WHERE year_result >= 16;

-- Exercice 2.2.2 --

SELECT last_name, section_id FROM student WHERE first_name LIKE 'Georges';

-- Exercice 2.2.3 --

SELECT last_name, year_result FROM student WHERE year_result BETWEEN 12 AND 16;

-- Exercice 2.2.4 --

SELECT last_name, section_id, year_result FROM student WHERE section_id NOT LIKE 1010 AND section_id NOT LIKE 1020 AND section_id NOT LIKE 1110;

-- Exercice 2.2.5 --

SELECT last_name, section_id FROM student WHERE last_name LIKE '%r';

-- Exercice 2.2.6 --

SELECT last_name, year_result FROM student WHERE last_name LIKE '__n%' AND year_result > 10;

-- Exercice 2.2.7 --

SELECT last_name, year_result FROM student WHERE year_result <= 3 ORDER BY year_result DESC;

-- Exercice 2.2.8 -- 

SELECT last_name + ' ' + first_name AS 'Nom complet', year_result FROM student WHERE section_id LIKE 1010 ORDER BY last_name ASC;

-- Exercice 2.2.9 --

SELECT last_name, section_id, year_result FROM student WHERE year_result NOT BETWEEN 12 AND 18 AND section_id LIKE 1010 OR section_id LIKE 1020 ORDER BY section_id ASC;

-- Exercice 2.2.10 --

SELECT last_name, section_id, year_result*5 AS 'Résultat sur 100' FROM student WHERE section_id LIKE '13%' AND year_result*5 <= 60 ORDER BY year_result DESC;

-- Exercice 2.3.1 --

-- NULL n'a pas vraiment de valeur donc il ne peut pas être utilisé ici car c'est des entiers

-- Exercice 2.3.2 --

-- Car la fonction COUNT() peut retourner des objets et est par DEFAULT ALL

-- Exercice 2.3.3 --

-- Faux, elle n'inclue pas les valeurs NULL

-- Exercice 2.3.4 --

-- Vrai

-- Exercice 2.3.5 --

-- Vrai 

-- Exercice 2.3.6 --

SELECT COUNT * FROM student; -- Non
SELECT COUNT(student_id), login FROM student; -- Non
SELECT MIN(year_result), MAX(birth_date) FROM student WHERE year_result > 12; -- Oui

-- Exercice 2.3.7 --

SELECT last_name+ ' ' + first_name AS 'Les élèves', year_result FROM student;

-- Exercice 2.3.8 --

SELECT last_name + ' ' + first_name AS 'Elèves', year_result AS 'Note maximale' FROM student WHERE year_result = (SELECT MAX(year_result) FROM student);
SELECT MAX(year_result) AS 'Note maximale' FROM student;
SELECT last_name + ' ' + first_name AS 'Elèves', year_result AS 'Note maximale' FROM student ORDER BY COUNT(*) DESC;




