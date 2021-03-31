CREATE VIEW [dbo].[V_Movie_With_Dirctor_Writer_Name]
	AS SELECT M.IdMovie,M.Title,M.Synopsis,M.YearRelease,
	CONCAT(PD.FirstName,' ',PD.LastName) AS Director,
	CONCAT(PW.FirstName,' ',PW.LastName) AS Writer FROM [dbo].[Movie] M
	JOIN [dbo].[Person] PD
		ON PD.IdPerson = M.Director
	JOIN [dbo].[Person] PW
		ON PW.IdPerson = M.Writer
