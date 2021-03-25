CREATE PROCEDURE [dbo].[UpdateNotice]
	@IdNotice int,
	@Content NVARCHAR(50),
	@IdMovie int,
	@IdUsers int
AS
BEGIN
	IF((SELECT [IdNotice] FROM [dbo].[Notice] WHERE [IdNotice] = @IdNotice)IS NULL) RETURN NULL
	UPDATE [dbo].[Notice]
	SET
		[Content] = @Content,
		[IdMovie] = @IdMovie,
		[IdUsers] = @IdUsers,
		[DateNotice] = GETDATE()
	WHERE [IdNotice] = @IdNotice
END