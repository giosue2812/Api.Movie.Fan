CREATE PROCEDURE [dbo].[NoticeByMovie]
	@IdMovie int
AS
BEGIN
	SELECT * FROM [dbo].[V_NoticeByUser] WHERE [IdMovie] = @IdMovie
END