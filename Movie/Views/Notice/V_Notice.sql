CREATE VIEW [dbo].[V_Notice]
	AS SELECT N.[Content],N.[DateNotice],U.[Pseudo],M.[Title] FROM [dbo].[Notice] N
	JOIN [dbo].[Users] U
	ON U.Id = N.IdUsers
	JOIN [dbo].[Movie] M
	ON M.IdMovie = N.IdMovie
