CREATE PROCEDURE [dbo].[DeleteNotice]
	@IdNotice int
AS
BEGIN
	DELETE FROM [dbo].[Notice] WHERE [IdNotice] = @IdNotice
END
