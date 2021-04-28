CREATE PROCEDURE [dbo].[PersonMovie]
	@IdPerson int
AS
BEGIN
	SELECT M.Title,M.Synopsis,C.[Role] FROM [dbo].[Movie] M
	JOIN [dbo].[Casting] C
	ON M.IdMovie = C.IdMovie
	WHERE C.IdPerson = @IdPerson
END
