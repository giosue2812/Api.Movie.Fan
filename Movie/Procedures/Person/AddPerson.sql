CREATE PROCEDURE [dbo].[AddPerson]
	@LastName NVARCHAR(50),
	@FirstName NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[Person] ([FirstName],[LastName]) OUTPUT [inserted].[IdPerson]  VALUES(@FirstName,@LastName)
END