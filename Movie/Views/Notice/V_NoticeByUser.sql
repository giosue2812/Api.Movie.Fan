CREATE VIEW [dbo].[V_NoticeByUser]
	AS SELECT N.IdMovie, U.Email,N.Content,N.DateNotice FROM dbo.Notice N
		JOIN dbo.Users U
		ON U.Id = N.IdUsers
