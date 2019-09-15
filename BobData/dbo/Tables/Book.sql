
CREATE TABLE [dbo].[Book] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Title]        NVARCHAR (MAX) NOT NULL,
    [AuthorId]     INT            NOT NULL,
    [Details]      NVARCHAR (MAX) NOT NULL,
    [Price]        MONEY          NULL,
    [ReleaseDate]  DATE           NULL,
    [CreatedDate]  DATETIME2 (7)  NOT NULL,
    [ModifiedDate] DATETIME2 (7)  NULL
);