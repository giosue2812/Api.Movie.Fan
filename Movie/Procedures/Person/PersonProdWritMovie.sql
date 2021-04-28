CREATE PROCEDURE [dbo].[PersonProdWritMovie]
	@IdPerson int
AS
BEGIN
	SELECT M.Title,M.Synopsis FROM dbo.Movie M
	JOIN Person p
	ON p.IdPerson = m.Director OR p.IdPerson = M.Writer
	WHERE P.IdPerson = @IdPerson 
END