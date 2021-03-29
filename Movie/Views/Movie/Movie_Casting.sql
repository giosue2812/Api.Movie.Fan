CREATE VIEW [dbo].[Movie_Casting]
	AS SELECT M.IdMovie, M.Title,
	CONCAT(P.FirstName, ' ',P.LastName) AS Actor,
	C.[Role] FROM [dbo].[Movie] M
	JOIN [dbo].[Casting] C
		ON M.IdMovie = C.IdMovie
	JOIN [dbo].[Person] P
		ON P.IdPerson = C.IdPerson