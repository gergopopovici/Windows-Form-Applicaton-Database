use etterem
GO
CREATE OR ALTER TRIGGER TR_Delete_Vendeg
ON Vendeg INSTEAD OF DELETE
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Foglalas
	WHERE VendegID IN (SELECT VendegID FROM deleted);
    DELETE FROM AsztalFoglalasok
    WHERE FoglalasID IN (SELECT FoglalasID FROM deleted);
	DELETE FROM Vendeg
	WHERE VendegID IN (SELECT VendegID FROM deleted);
END
GO
CREATE OR ALTER TRIGGER TR_Delete_Foglalas
ON Foglalas INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;
	DELETE FROM AsztalFoglalasok
    WHERE FoglalasID IN (SELECT FoglalasID FROM deleted);
	DELETE FROM FoglalEtelek
	WHERE FoglalasID IN (SELECT FoglalasID FROM deleted);
    DELETE FROM Foglalas
    WHERE FoglalasID IN (SELECT FoglalasID FROM deleted);
END
GO
GO
CREATE OR ALTER TRIGGER TR_Delete_AsztalFoglalas
ON AsztalFoglalasok
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM AsztalFoglalasok
    WHERE AsztalFoglalID IN (SELECT AsztalFoglalID FROM deleted);
END
GO
GO
CREATE OR ALTER TRIGGER TR_Delete_FoglalEtelek
ON FoglalEtelek
INSTEAD OF DELETE
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM FoglalEtelek
	WHERE FoglalEtelekID IN(SELECT FoglalEtelekID FROM deleted);
END
GO