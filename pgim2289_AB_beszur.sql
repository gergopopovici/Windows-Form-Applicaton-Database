use etterem
GO
CREATE OR ALTER PROCEDURE beszuras
(
    @pNev NVARCHAR(30),
    @pKor INT,
    @pTelefonszam VARCHAR(12),
    @pAsztalSzam INT,
    @pDatum DATE,
    @pKezdesiIdo VARCHAR(12),
    @pVegzesiIdo VARCHAR(12),
    @pVendegSzam INT
)
AS 
BEGIN
    SET NOCOUNT ON;
    
    IF @pDatum < GETDATE()
    BEGIN
        RAISERROR('A datum nem megfelelo formatumu vagy egy multbeli idopontot adott meg.', 11, 1);
        RETURN -1;
    END
    
    IF NOT EXISTS (SELECT 1 FROM Asztalok AS A WHERE A.Szam = @pAsztalSzam)
    BEGIN
        RAISERROR('Ilyen szamu asztal nem letezik az adatbazisban', 11, 1);
        RETURN -2;
    END
    
	IF EXISTS (
        SELECT 1 
        FROM Foglalas AS F 
        JOIN Asztalok AS A ON A.AsztalID = F.AsztalID 
        WHERE A.Szam = @pAsztalSzam 
            AND F.Datum = @pDatum 
            AND (
                (@pKezdesiIdo BETWEEN F.KezdesiIdo AND F.VegzesiIdo)
                OR (@pVegzesiIdo BETWEEN F.KezdesiIdo AND F.VegzesiIdo)
                OR (F.KezdesiIdo BETWEEN @pKezdesiIdo AND @pVegzesiIdo)
            )
    )
    BEGIN
        RAISERROR('Ebben az idopontban mar van foglalas.', 11, 1);
        RETURN -4;
    END
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE 
    BEGIN TRANSACTION;

    DECLARE @FoglalasVegosszeg FLOAT = 0.0;
    DECLARE @VendegID INT;
    DECLARE @AsztalID INT;
    DECLARE @FoglalID INT;
    DECLARE @EtelID INT;

    IF NOT EXISTS (SELECT 1 FROM Vendeg AS V WHERE V.Nev = @pNev AND V.Kor = @pKor AND Telefonszam = @pTelefonszam)
    BEGIN
        RAISERROR('A vendeg nem letezik a tablaban.', 11, 1);
        INSERT INTO Vendeg(Nev, Kor, Telefonszam)
        VALUES (@pNev, @pKor, @pTelefonszam);

        IF @@ERROR <> 0
        BEGIN
            RAISERROR('A beszuras sikertelen.', 16, 1);
            ROLLBACK;
            RETURN 1;
        END
    END
    
    IF NOT EXISTS (
        SELECT 1 
        FROM Foglalas AS F 
        JOIN Asztalok AS A ON A.AsztalID = F.AsztalID 
        WHERE F.Datum = @pDatum AND F.KezdesiIdo = @pKezdesiIdo AND F.VegzesiIdo = @pVegzesiIdo AND A.Szam = @pAsztalSzam
    )
    BEGIN 
        SET @VendegID = (SELECT V.VendegID FROM Vendeg AS V WHERE V.Kor = @pKor AND V.Nev = @pNev AND V.Telefonszam = @pTelefonszam);
        SET @AsztalID = (SELECT A.AsztalID FROM Asztalok AS A WHERE A.Szam = @pAsztalSzam);

        DECLARE @AsztalKapacitas INT;
        SET @AsztalKapacitas = (SELECT A.Kapacitas FROM Asztalok AS A WHERE A.Szam = @pAsztalSzam);
        
        IF @AsztalKapacitas - @pVendegSzam <= 0 
        BEGIN
            RAISERROR('Az asztalhoz nem fer ennyi vendeg.', 11, 1);
            ROLLBACK;
            RETURN -3;
        END
        
        INSERT INTO Foglalas(VendegID, AsztalID, Datum, KezdesiIdo, VegzesiIdo, VendegSzam, Vegosszeg)
        VALUES(@VendegID, @AsztalID, @pDatum, @pKezdesiIdo, @pVegzesiIdo, @pVendegSzam, 0);
        
        IF @@ERROR <> 0
        BEGIN
            RAISERROR('A beszuras sikertelen.', 16, 1);
            ROLLBACK;
            RETURN 1;
        END
    END
    
    COMMIT;
    RETURN 0;
END
GO
select * from Vendeg
select * from Felhasznalok
select * from Foglalas
