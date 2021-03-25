CREATE VIEW [dbo].[V_User_List]
	AS SELECT [Id],[Email],[Pseudo],[BirthDate],[IsAdmin],[IsActive] FROM [dbo].[Users]
