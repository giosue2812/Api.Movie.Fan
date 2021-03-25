CREATE PROCEDURE [dbo].[AddCasting]
	@Role NVARCHAR(50),
	@IdPerson int,
	@IdMovie int
AS
BEGIN
	INSERT INTO [dbo].[Casting] ([Role],[IdMovie],[IdPerson]) OUTPUT [inserted].[IdMovie] 
	VALUES(@Role,@IdMovie,@IdPerson)
END