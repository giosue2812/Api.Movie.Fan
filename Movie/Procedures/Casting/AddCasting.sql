CREATE PROCEDURE [dbo].[AddCasting]
	@Role NVARCHAR(50),
	@IdPerson int,
	@IdMovie int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[Casting] ([Role],[IdMovie],[IdPerson]) OUTPUT [inserted].[IdCasting] 
	VALUES(@Role,@IdMovie,@IdPerson)
END