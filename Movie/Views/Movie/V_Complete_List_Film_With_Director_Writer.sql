CREATE VIEW [dbo].[V_CompleteListFilmWithDirectorWriter]
	AS SELECT M.[IdMovie],M.[Title],
	CONCAT(PD.[FirstName],' ',PD.[LastName]) AS Director,
	CONCAT(PW.[FirstName],' ',pW.[LastName]) AS Writer FROM [dbo].[Movie] M
	JOIN [dbo].[Person] PD
	ON M.Director = PD.IdPerson
	JOIN [dbo].[Person] PW
	ON M.Writer = PW.IdPerson