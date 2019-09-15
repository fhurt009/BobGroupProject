CREATE PROCEDURE [dbo].[spAuthorLookup]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		Id
		,FirstName
		,LastName
		,Birthday
		,CreatedDate
	FROM dbo.Author
	WHERE Id = @Id;
END
