CREATE PROCEDURE [dbo].[UpdateMovie]
	@IdMovie int,
	@Title NVARCHAR(50),
	@YearRelease int,
	@Synopsis NVARCHAR(1000),
	@Director int,
	@Writer int
AS
BEGIN
	IF((SELECT [IdMovie] FROM [dbo].[Movie] WHERE [IdMovie] = @IdMovie) IS NULL) RETURN NULL
	UPDATE [dbo].[Movie] 
	SET 
		[Title] = @Title,
		[YearRelease] = @YearRelease,
		[Synopsis] = @Synopsis,
		[Director] = @Director,
		[Writer] = @Writer
	WHERE [IdMovie] = @IdMovie
END