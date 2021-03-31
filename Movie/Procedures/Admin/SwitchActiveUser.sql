CREATE PROCEDURE [dbo].[SwitchActiveUser]
	@IdUser int
AS
BEGIN
	UPDATE dbo.Users SET IsActive = (SELECT ~ IsActive FROM dbo.Users WHERE Id = @IdUser) WHERE Id = @IdUser
END
