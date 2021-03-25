CREATE PROCEDURE [dbo].[AddPerson]
	@LastName NVARCHAR(50),
	@FirstName NVARCHAR(50)
AS
BEGIN
	INSERT INTO [dbo].[Person] ([FirstName],[LastName]) OUTPUT [inserted].[IdPerson]  VALUES(@FirstName,@LastName)
END