USE master;
GO

IF EXISTS(SELECT * FROM sys.databases WHERE name='etterem')
	DROP DATABASE etterem

CREATE DATABASE etterem;
GO 

USE etterem;
GO--Sajat E/K Diagram atalakitasa (Etterem)
--Popovici Gergo-Benone
--523



CREATE TABLE Vendeg (
    VendegID INT PRIMARY KEY IDENTITY(1,1),
    Nev VARCHAR(40),
    Kor INT,
    Telefonszam VARCHAR(20),
);

CREATE TABLE Foglalas (
    FoglalasID INT PRIMARY KEY IDENTITY(1,1),
	VendegID INT,
	AsztalID INT,
    Datum DATE,
    KezdesiIdo TIME,
    VegzesiIdo TIME,
	VendegSzam INT,
 --   SzamlaID INT UNIQUE, -- Minden foglaláshoz egy számla tartozik
	Vegosszeg FLOAT
);

/*CREATE TABLE Szamlak (
    SzamlakID INT PRIMARY KEY IDENTITY(1,1),
    Datum DATE,
    Osszeg FLOAT,
    FoglalasID INT UNIQUE, -- Minden számlához egy foglalás tartozik
);*/

CREATE TABLE Asztalok (
	AsztalID INT PRIMARY KEY IDENTITY(1,1),
	Kapacitas INT,
	Szam INT
);

CREATE TABLE AsztalFoglalasok(
	AsztalFoglalID INT PRIMARY KEY IDENTITY(1,1),
	AsztalID INT,
	FoglalasID INT,
	FOREIGN KEY (AsztalID) REFERENCES Asztalok(AsztalID),
	FOREIGN KEY (FoglalasID) REFERENCES Foglalas(FoglalasID)
);

CREATE TABLE Etel(
	EtelID INT PRIMARY KEY IDENTITY(1,1),
	Nev VARCHAR(20),
	Ar FLOAT,
	TvaAr FLOAT,
	Mennyiseg FLOAT
);

CREATE TABLE EtelAsztal(
	EtelAsztalID INT PRIMARY KEY IDENTITY(1,1),
	AsztalID INT,
	EtelID INT,
	FOREIGN KEY (EtelID) REFERENCES Etel(EtelID),
	FOREIGN KEY (AsztalID) REFERENCES Asztalok(AsztalID)
);

CREATE TABLE Konyha(
	KonyhaID INT PRIMARY KEY IDENTITY(1,1),
	ElkeszitesiIdo TIME,
	Alapanyagok Varchar(50)
);


CREATE TABLE EtelKonyha(
	EtelKonyhaID INT PRIMARY KEY IDENTITY(1,1),
	EtelID INT,
	KonyhaID INT,
	FOREIGN KEY (EtelID) REFERENCES  Etel(EtelID),
	FOREIGN KEY (KonyhaID) REFERENCES Konyha(KonyhaID)
);

CREATE TABLE Szakacs(
	SzakacsID INT PRIMARY KEY IDENTITY(1,1),
	Nev VARCHAR(20),
	Telefonszam VARCHAR(20),
	Kor INT,
	KezdesiIdo Time,
	VegezesiIdo Time,
	KonyhaID INT,
);

CREATE TABLE FoglalEtelek(
	FoglalEtelekID INT PRIMARY KEY IDENTITY(1,1),
	FoglalasID INT,
	EtelID INT,
	Mennyiseg FLOAT

);

CREATE TABLE Felhasznalok(
	FelhID INT PRIMARY KEY IDENTITY(1,1),
	FelhNev NVARCHAR(32),
	Jelszo NVARCHAR(500),
	Salt NVARCHAR(32),
	VendegID INT,
	FelhCsopID INT
);

CREATE TABLE FelhasznaloCsoportok(
	CsopID INT PRIMARY KEY IDENTITY(1,1),
	CsopNev NVARCHAR(16)
);
CREATE TABLE FelhCsopJogok(
	FelhCsopID INT,
	FormID INT,
	permView BIT,
	permAdd BIT,
	permEdit BIT,
	permDelete BIT
);
CREATE TABLE Formok(
	FormID INT PRIMARY KEY IDENTITY(1,1),
	FormNev NVARCHAR(16),
	FormLeiras NVARCHAR(40)
);
--feltoltes
INSERT INTO Vendeg (Nev, Kor, Telefonszam)
VALUES 
    ('Kovács Péter', 35, '123456789'),
    ('Nagy Anna', 28, '987654321'),
    ('Kiss Gergő', 40, '456123789'),
    ('Tóth Eszter', 45, '555444333'),
    ('Horváth Balázs', 32, '666777888');
INSERT INTO Foglalas (VendegID,AsztalID,Datum, KezdesiIdo, VegzesiIdo,VendegSzam,Vegosszeg)
VALUES 
    (1,1,'2024-09-26','18:00:00','20:00:00',2,0),
    (2,2,'2024-09-27', '19:30:00','21:30:00',3,0),
    (3,3,'2024-09-28','20:00:00','22:00:00',4,0),
    (4,4,'2024-09-29','17:00:00','19:00:00',1,0),
    (5,5,'2024-10-30','19:00:00','21:00:00',4,0);

/*INSERT INTO Szamlak (Datum, Osszeg, FoglalasID)
VALUES 
    ('2024-03-26', 25000, 1),
    ('2024-03-27', 30000, 2),
    ('2024-03-28', 20000, 3),
    ('2024-03-29', 18000, 4),
    ('2024-03-30', 27000, 5);*/

INSERT INTO Asztalok (Kapacitas, Szam)
VALUES 
    (4, 1),
    (6, 2),
    (2, 3),
    (8, 4),
    (4, 5);

/*INSERT INTO AsztalFoglalasok (AsztalID, FoglalasID)
VALUES 
    (1, 1),
    (2, 2),
    (3, 3),
    (4, 4),
    (5, 5);*/

INSERT INTO Etel (Nev, Ar,TvaAr,Mennyiseg)
VALUES 
    ('Sült csirke', 25,27.5,25),
    ('Rántott hal', 20,21.8,45),
    ('Csokoládétorta',60,65.4,15),
    ('Gombaleves', 13,16.35,5),
    ('Paprikas', 17,18.53,12);

--INSERT INTO EtelAsztal (AsztalID, EtelID)
--VALUES 
   -- (1,1),
--	(1,2),
--	(1,5),
  /*  (2,1),
	(2,2),
	(2,3),
	(2,4),
    (3, 1),
    (3, 2),
    (3, 3),
	(3,4),
	(3,5),
	(4,1),
	(4,2),
	(4,3),
	(5,1);*/


INSERT INTO Konyha (ElkeszitesiIdo, Alapanyagok)
VALUES 
    ('00:30:00', 'Csirkehús, fűszerek'),
    ('00:40:00', 'Hal, liszt, tojás, olaj'),
    ('00:20:00', 'Csokoládé, liszt, tojás, cukor'),
    ('00:25:00', 'Gomba, zöldségek, fűszerek'),
    ('00:35:00', 'Zöldségek, olaj, fűszerek');



INSERT INTO EtelKonyha (EtelID, KonyhaID)
VALUES 
    (1, 1),
    (2, 2),
    (3, 3),
    (4, 4),
    (5, 5);

INSERT INTO Szakacs (Nev, Telefonszam, Kor, KezdesiIdo, VegezesiIdo, KonyhaID)
VALUES 
    ('Kovács János', '111222333', 45, '08:00:00', '16:00:00', 1),
    ('Nagy Márta', '444555666', 38, '09:00:00', '17:00:00', 2),
    ('Kiss Géza', '777888999', 50, '10:00:00', '18:00:00', 3),
    ('Tóth László', '999888777', 42, '11:00:00', '19:00:00', 4),
    ('Szabó Eszter', '666999444', 35, '12:00:00', '20:00:00', 5);

/*INSERT INTO FoglalEtelek(FoglalasID,EtelID,Mennyiseg)
VALUES
	(1,1,4),
	(1,2,3),
	(1,5,1),
	(2,1,3),
	(2,2,2),
	(2,3,1),
	(2,4,5),
	(3,1,7),
	(3,2,3),
	(3,3,4),
	(3,4,5),
	(3,5,4),
	(4,1,3),
	(4,2,3),
	(4,3,1),
	(5,3,1);*/

INSERT INTO FelhasznaloCsoportok(CsopNev)
VALUES
('Admin'),
('User'),
('Guest');

INSERT INTO Formok(FormNev,FormLeiras)
VALUES
('LoginForm','Loging users in'),
('RegistrationForm','Registering Users'),
('AdminForm','All database elements'),
('GuestForm','Only Select'),
('UserForm','Update, Select');

INSERT INTO FelhCsopJogok(FelhCsopID,FormID,permAdd,permDelete,permEdit,permView)
VALUES
(1,3,1,1,1,1),
(2,5,1,0,0,1),
(3,4,0,0,0,1);


--ALTER TABLE Foglalas
--ADD CONSTRAINT FK_Foglalas_SzamlaID FOREIGN KEY (SzamlaID) REFERENCES Szamlak(SzamlakID);
ALTER TABLE Foglalas
ADD CONSTRAINT FK_Foglalas_AsztalID FOREIGN KEY (AsztalID) REFERENCES Asztalok(AsztalID);


--ALTER TABLE Szamlak
--ADD CONSTRAINT FK_Szamlak_FoglalasID FOREIGN KEY (FoglalasID) REFERENCES Foglalas(FoglalasID);

ALTER TABLE Foglalas
ADD CONSTRAINT FK_Foglalas_VendegID FOREIGN KEY (VendegID) REFERENCES Vendeg(VendegID);

ALTER TABLE Szakacs
ADD CONSTRAINT FK_Szakacs_KonyhaID FOREIGN KEY (KonyhaID) REFERENCES Konyha(KonyhaID);

ALTER TABLE FoglalEtelek
ADD CONSTRAINT FK_FoglalEtelek_EtelID  FOREIGN KEY (EtelID) REFERENCES Etel(EtelID)

ALTER TABLE FoglalEtelek
ADD CONSTRAINT FK_FoglalEtelek_FoglalasID FOREIGN KEY(FoglalasID) REFERENCES Foglalas(FoglalasID)

ALTER TABLE Felhasznalok
ADD CONSTRAINT FK_Felhasznalok_VendegID FOREIGN KEY (VendegID) REFERENCES Vendeg(VendegID)

ALTER TABLE Felhasznalok
ADD CONSTRAINT FK_Felhasznalok_FelhCsopID FOREIGN KEY (FelhCsopID) REFERENCES FelhasznaloCsoportok(CsopID)

ALTER TABLE FelhCsopJogok
ALTER COLUMN FelhCsopID INT NOT NULL;

ALTER TABLE FelhCsopJogok
ALTER COLUMN FormID INT NOT NULL;

ALTER TABLE FelhCsopJogok
ADD CONSTRAINT PK_FelhCsopJogok_Primary PRIMARY KEY (FelhCsopID, FormID);

ALTER TABLE FelhCsopJogok
ADD CONSTRAINT FK_FelhCsopJogok_FelhCsopID FOREIGN KEY(FelhCsopID) REFERENCES FelhasznaloCsoportok(CsopID)

ALTER TABLE FelhCsopJogok
ADD CONSTRAINT FK_FelhCsopJogok_FormID FOREIGN KEY(FormID) REFERENCES Formok(FormID)

update Foglalas
SET Vegosszeg = 50 WHERE FoglalasID = 2

select * from Foglalas
select * from Vendeg