
CREATE TABLE [dbo].[Author] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]    NVARCHAR (50) NOT NULL,
    [LastName]     NVARCHAR (50) NOT NULL,
    [Birthday]     DATE          NOT NULL,
    [CreatedDate]  DATETIME2 (7) NOT NULL,
    [ModifiedDate] DATETIME2 (7) NULL
);


