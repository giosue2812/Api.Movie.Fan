CREATE PROCEDURE [dbo].[SwitchAdmin]
	@IdUser int
AS
BEGIN
	UPDATE dbo.Users SET IsAdmin = (SELECT ~ IsAdmin FROM dbo.Users WHERE Id = @IdUser) WHERE Id = @IdUser
END