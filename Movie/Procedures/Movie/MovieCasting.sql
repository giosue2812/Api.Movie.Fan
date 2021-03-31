CREATE PROCEDURE [dbo].[MovieCasting]
	@IdMovie int
AS
BEGIN
	SELECT CONCAT(P.FirstName,' ',P.LastName) AS Actor, C.[Role] FROM Person P
	JOIN Casting C
	ON C.IdPerson = P.IdPerson
	WHERE C.IdMovie = @IdMovie
END