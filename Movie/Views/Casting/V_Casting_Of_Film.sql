CREATE VIEW [dbo].[V_Casting_Of_Film]
	AS SELECT M.[IdMovie],M.[Title],CONCAT(P.FirstName,' ',P.LastName) AS Actor FROM [dbo].[Movie] M 
	JOIN [dbo].[Casting] C
	ON M.IdMovie = C.IdMovie
	JOIN [dbo].[Person] P
	ON P.[IdPerson] = C.[IdCasting]
