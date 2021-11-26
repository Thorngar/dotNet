USE Labo;
GO
INSERT INTO articles(RefArt,Designation,Prix,CodeTVA,Categorie,QteStk)
VALUES
('AB22','Tapis persan',1250.10,2,'IMPORT',5),
('CD50','Chaine HiFi',735.40,2,'IMPORT',7),
('ZZZZ','Article bidon',DEFAULT,DEFAULT,'DIVERS',25),
('AA00','Cadeau',0.00,2,'DIVERS',8),
('AB03','Essuis mains',19.30,2,'SOLDES',116),
('GH','Table basse',DEFAULT,2,'DIVERS',2),
('ERTU','Ecran plat 27 pouces',305.10,2,'IMPORT',10),
('NBP8','Matelas',263.25,2,'IMPORT',18)
;