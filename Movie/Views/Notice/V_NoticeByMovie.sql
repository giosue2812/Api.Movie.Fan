CREATE VIEW [dbo].[V_NoticeByMovie]
	AS SELECT N.IdUsers, M.Title,N.Content,N.DateNotice,N.IsActive FROM dbo.Notice N
		JOIN dbo.Movie M
		ON N.IdMovie = M.IdMovie
