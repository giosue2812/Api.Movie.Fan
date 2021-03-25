CREATE TABLE [dbo].[Movie]
(
	[IdMovie] INT NOT NULL IDENTITY (1,1),
	[Title] NVARCHAR(50) NOT NULL,
	[YearRelease] INT NOT NULL,
	[Synopsis] NVARCHAR(1000) NOT NULL,
	[Director] INT NOT NULL,
	[Writer] INT NOT NULL,
	CONSTRAINT PK_Movie PRIMARY KEY (IdMovie),
	CONSTRAINT FK_Movie_Person_Director FOREIGN KEY (Director) REFERENCES Person (IdPerson),
	CONSTRAINT FK_Movie_Person_Writer FOREIGN KEY (Writer) REFERENCES Person (IdPerson)
)
