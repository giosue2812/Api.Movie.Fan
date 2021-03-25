CREATE TABLE [dbo].[Casting]
(
	[IdCasting] INT NOT NULL IDENTITY (1,1),
	[Role] NVARCHAR(50) NULL,
	[IdPerson] INT NOT NULL,
	[IdMovie] INT NOT NULL,
	CONSTRAINT PK_Casting PRIMARY KEY (IdCasting),
	CONSTRAINT FK_Casting_Person FOREIGN KEY (IdPerson) REFERENCES Person(IdPerson),
	CONSTRAINT FK_Casting_Movie FOREIGN KEY (IdMovie) REFERENCES Movie (IdMovie)
)
