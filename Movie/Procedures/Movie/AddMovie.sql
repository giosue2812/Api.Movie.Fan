CREATE PROCEDURE [dbo].[AddMovie]
	@Title NVARCHAR(50),
	@YearRelease int,
	@Synopsis NVARCHAR(250),
	@Director int,
	@Writer int
AS
BEGIN
	INSERT INTO [dbo].[Movie] ([Title],[YearRelease],[Synopsis],[Director],[Writer]) OUTPUT [inserted].[IdMovie]
	VALUES(@Title,@YearRelease,@Synopsis,@Director,@Writer)
END