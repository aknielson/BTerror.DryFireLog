CREATE TABLE [dbo].[Books] (
    [BookId]  INT            IDENTITY (1, 1) NOT NULL,
    [Title]   NVARCHAR (MAX) NULL,
    [Author]  NVARCHAR (MAX) NULL,
    [Version] NVARCHAR (MAX) NULL,
    [Things]  NVARCHAR (50)  NULL,
    CONSTRAINT [PK_dbo.Books] PRIMARY KEY CLUSTERED ([BookId] ASC)
);

