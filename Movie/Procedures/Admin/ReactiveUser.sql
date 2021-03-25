CREATE PROCEDURE [dbo].[ReactiveUser]
	@IdUser int,
	@IdUserAdmin int
AS
BEGIN
	IF((SELECT [Id] FROM [dbo].[Users] WHERE [Id] = @IdUserAdmin AND [IsAdmin] = 1) IS NOT NULL)
	BEGIN
		IF((SELECT [Id] FROM [dbo].[Users] WHERE [Id] = @IdUser)IS NULL)RETURN NULL
			UPDATE [dbo].[Users]
			SET
				[IsActive] = 1
			WHERE [Id] = @IdUser
	END
	ELSE
		BEGIN
			RETURN NULL
		END
END
