CREATE PROCEDURE [dbo].[ResetPassword]
	@IdUser int,
	@Email NVARCHAR(50),
	@Password NVARCHAR(50)
AS
BEGIN

	IF((SELECT [Id] FROM [dbo].[Users] WHERE [Id] = @IdUser AND [Email] = @Email)IS NULL) RETURN NULL

	DECLARE @Salt NVARCHAR(100);
	SET @Salt = CONCAT(NEWID(),NEWID(),NEWID());

	DECLARE @Secret NVARCHAR(50);
	SET @Secret = [dbo].[GenerateKey]();

	DECLARE @PasswordHash VARBINARY(64);
	SET @PasswordHash = HASHBYTES('SHA2_512',CONCAT(@Salt,@Password,@Secret,@Salt));

	UPDATE [dbo].[Users] SET [Password] = @PasswordHash WHERE [Id] = @IdUser;
END