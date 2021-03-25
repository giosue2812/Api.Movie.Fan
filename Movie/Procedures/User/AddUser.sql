CREATE PROCEDURE [dbo].[AddUser]
	@Email NVARCHAR(50),
	@Password NVARCHAR(50),
	@BirthDate DATE
AS
BEGIN
	SET NOCOUNT ON;
	--Generation du SALT
	DECLARE @Salt NVARCHAR(100);
	SET @Salt = CONCAT(NEWID(),NEWID(),NEWID());

	--Recuperation de la valeur secrete
	DECLARE @Secret NVARCHAR(50);
	SET @Secret = [dbo].[GenerateKey]();

	--Hashage du mot de passe avec le salt
	DECLARE @Password_hash VARBINARY(64);
	SET @Password_hash = HASHBYTES('SHA2_512',CONCAT(@Salt,@Password,@Secret,@Salt));

	--Recup du pseudo
	DECLARE @Pseudo NVARCHAR(50);
	SET @Pseudo = [dbo].[Pseudo](@Email,@BirthDate);

	--Ajout de l'utilisateur dans le DB
	INSERT INTO [dbo].[Users]([Email],[Pseudo],[Password],[Salt],[BirthDate]) OUTPUT [inserted].[Id]
	VALUES(@Email,@Pseudo,@Password_hash,@Salt,@BirthDate);

END