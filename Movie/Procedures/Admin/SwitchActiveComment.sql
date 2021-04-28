CREATE PROCEDURE [dbo].[SwitchActiveComment]
	@IdNotice int
AS
BEGIN
	UPDATE dbo.Notice SET IsActive = (SELECT ~ IsActive FROM dbo.Notice WHERE IdNotice = @IdNotice) WHERE IdNotice = @IdNotice
END