CREATE PROCEDURE [dbo].[NoticeByUser]
	@IdUser int
AS
	SELECT * FROM [dbo].[V_NoticeByMovie] WHERE [IdUsers] = @IdUser
RETURN 0
