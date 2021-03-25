CREATE PROCEDURE [dbo].[DeleteUser]
	@IdUser int
AS
BEGIN
	IF((SELECT [Id] FROM [dbo].[Users] WHERE [Id] = @IdUser) IS NULL) RETURN NULL
	
	DELETE FROM [dbo].[Users] WHERE [Id] = @IdUser
END