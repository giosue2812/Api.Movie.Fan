CREATE PROCEDURE [dbo].[LoginUser]
	@Email NVARCHAR(50),
	@Password NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	--Recuperation du Salt lier a l'user
	DECLARE @Salt NVARCHAR(100);
	SELECT @Salt = Salt FROM [dbo].[Users] WHERE Email LIKE @Email;

	--Si salt trouver on continue
	IF @Salt IS NOT NULL
		BEGIN
			--Recup la clé secrete
			DECLARE @Secret NVARCHAR(50);
			SET @Secret = dbo.GenerateKey();

			--Hash le password
			DECLARE @Password_Hash VARBINARY(64);
			SET @Password_Hash = HASHBYTES('SHA2_512',CONCAT(@Salt,@Password,@Secret,@Salt));

			--On recup l'id de l'user
			DECLARE @UserID int;
			SELECT @UserID = Id FROM dbo.Users WHERE Email LIKE @Email AND [Password] = @Password_Hash;
			
			SELECT * FROM dbo.V_User_List WHERE [Id] = @UserID
		END
END