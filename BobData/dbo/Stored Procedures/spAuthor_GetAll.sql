
CREATE PROCEDURE [dbo].[spAuthor_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT 
		Id
		,FirstName
		,LastName
		,Birthday
	FROM dbo.Author
	ORDER BY FirstName, LastName;
END
