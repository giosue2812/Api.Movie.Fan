CREATE VIEW [dbo].[V_Film_Detail]
	AS SELECT M.[IdMovie],M.[Title],M.[Synopsis],M.[YearRelease],PDW.Director,PDW.Writer
		FROM [dbo].[Movie] M
	
	JOIN [dbo].[V_CompleteListFilmWithDirectorWriter] PDW
		ON PDW.IdMovie = M.IdMovie

