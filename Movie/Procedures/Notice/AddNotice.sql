CREATE PROCEDURE [dbo].[AddNotice]
	@Content NVARCHAR(1000),
	@IdMovie int,
	@IdUsers int
AS
BEGIN
	INSERT INTO [dbo].[Notice] ([Content],[IdMovie],[IdUsers]) OUTPUT [inserted].[IdNotice] 
	VALUES(@Content,@IdMovie,@IdUsers)
END
