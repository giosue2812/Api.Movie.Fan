CREATE PROCEDURE [dbo].[UpdatePerson]
	@IdPerson int,
	@LastName NVARCHAR(50),
	@FirstName NVARCHAR(50)
AS
BEGIN
	IF((SELECT [IdPerson] FROM [dbo].[Person] WHERE [IdPerson] = @IdPerson) IS NULL) RETURN NULL
	UPDATE [dbo].[Person] 
	SET
		[FirstName] = @FirstName,
		[LastName] = @LastName
	WHERE [IdPerson] = @IdPerson
END