CREATE PROCEDURE [dbo].[UpdateCasting]
	@IdCasting int,
	@IdPerson int,
	@IdMovie int
AS
BEGIN
	IF((SELECT [IdCasting] FROM [dbo].[Casting] WHERE [IdCasting] = @IdCasting) IS NULL) RETURN NULL
	UPDATE [dbo].[Casting] 
	SET
		[IdMovie] = @IdMovie,
		[IdPerson] = @IdPerson
	WHERE [IdCasting] = @IdCasting
END