USE etterem
GO
CREATE OR ALTER PROCEDURE Registration(@pNev NVARCHAR(40),@pKor INT,@pTelefonSzam VARCHAR(14),@pFelhasznaloNev VARCHAR(32),@pJelszo NVARCHAR(500),@pSalt NVARCHAR(64))
AS
BEGIN
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
	BEGIN TRANSACTION
	IF @pFelhasznaloNev <> 'guest' AND @pFelhasznaloNev <> 'admin'
	BEGIN 
		IF NOT EXISTS (SELECT 1 FROM Vendeg AS V WHERE V.Nev = @pNev AND V.Kor = @pKor AND V.Telefonszam = @pTelefonSzam)
		BEGIN
			INSERT INTO Vendeg(Nev,Kor,Telefonszam)
			VALUES(@pNev,@pKor,@pTelefonSzam)
			IF @@ERROR <> 0
			BEGIN
				RAISERROR('A beszuras sikertelen',11,16)
				ROLLBACK
				RETURN -1
			END
		END
		IF EXISTS (SELECT 1 FROM Felhasznalok AS F WHERE F.FelhNev = @pFelhasznaloNev)
		BEGIN
			RAISERROR('A felhasznalo nev mar foglalt',11,16)
			ROLLBACK
			RETURN -3
		END
		DECLARE @vendegID INT
		SET @vendegID = (SELECT V.VendegID FROM Vendeg as V WHERE V.Kor = @pKor AND V.Nev = @pNev AND V.Telefonszam = @pTelefonSzam)
		INSERT INTO Felhasznalok(FelhNev,Jelszo,Salt,VendegID,FelhCsopID)
		VALUES(@pFelhasznaloNev,@pJelszo,@pSalt,@vendegID,2)
		IF @@ERROR <> 0 
		BEGIN
			RAISERROR('A beszuras sikertelen',11,16)
			ROLLBACK
			RETURN -1
		END
	END
	IF @pFelhasznaloNev ='guest'
	BEGIN
		INSERT INTO Felhasznalok(FelhNev,Jelszo,Salt,VendegID,FelhCsopID)
		VALUES(@pFelhasznaloNev,'a','a',NULL,2)
		IF @@ERROR <> 0 
		BEGIN
			RAISERROR('A beszuras sikertelen',11,16)
			ROLLBACK
			RETURN -1
		END
	END
	IF @pFelhasznaloNev ='admin'
	BEGIN
		INSERT INTO Felhasznalok(FelhNev,Jelszo,Salt,VendegID,FelhCsopID)
		VALUES(@pFelhasznaloNev,@pJelszo,@pSalt,NULL,2)
		IF @@ERROR <> 0 
		BEGIN
			RAISERROR('A beszuras sikertelen',11,16)
			ROLLBACK
			RETURN -1
		END
	END
	COMMIT
	RETURN 0
END
GO

select * from Felhasznalok
select * from Vendeg
select * from Foglalas