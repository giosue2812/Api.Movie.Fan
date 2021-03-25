/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
EXEC [dbo].[AddUser] 'giosue_liuzzo@hotmail.be','elisa2812','1985-06-14';
UPDATE [dbo].[Users] SET [IsAdmin] = 1 WHERE [Id] = 1;

EXEC [dbo].[AddUser] 'toto@toto.be','elisa1306','1986-06-20';

EXEC [dbo].[AddPerson] 'Favreau','Jon';
EXEC [dbo].[AddPerson] 'Marcum','Arthur';
EXEC [dbo].[AddPerson] 'Downey Jr','Robert';
EXEC [dbo].[AddPerson] 'Russo','Joe';
EXEC [dbo].[AddPerson] 'Markus','Christopher';
EXEC [dbo].[AddPerson] 'Evans','Chris';
EXEC [dbo].[AddPerson] 'Larson','Brie';

EXEC [dbo].[AddMovie] 'Iron Man',2008,'Tony Stark, inventeur de génie, vendeur d''armes et playboy milliardaire, 
est kidnappé en Aghanistan. Forcé par ses ravisseurs de fabriquer une arme redoutable, 
il construit en secret une armure high-tech révolutionnaire qu''il utilise pour s''échapper.',1,2;
EXEC [dbo].[AddMovie] 'Avengers Endgame',2019,'Thanos ayant anéanti la moitié de l’univers, 
les Avengers restants resserrent les rangs dans ce vingt-deuxième film des Studios Marvel, 
grande conclusion d’un des chapitres de l’Univers Cinématographique Marvel.',4,5;

EXEC [dbo].[AddCasting] 'Iron Man',3,1;
EXEC [dbo].[AddCasting] 'Iron Man',3,2;
EXEC [dbo].[AddCasting] 'Captain America',6,2;

EXEC [dbo].[AddNotice] 'Super Film',1,1;