CREATE FUNCTION [dbo].[Pseudo](@email AS NVARCHAR(50),@birthDate AS DATE)
RETURNS NVARCHAR(50)
AS
BEGIN
	DECLARE @Pseudo NVARCHAR(50);
	DECLARE @DateConvertion NVARCHAR(30);
	SET @DateConvertion = REPLACE(@birthDate,'-','');
	SET @Pseudo = CONCAT(SUBSTRING(@email,0,5),@DateConvertion)	
	RETURN @Pseudo;
END