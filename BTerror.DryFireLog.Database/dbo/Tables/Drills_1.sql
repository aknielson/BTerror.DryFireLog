CREATE TABLE [dbo].[Drills] (
    [DrillId]     INT            IDENTITY (1, 1) NOT NULL,
    [BoodId]      INT            NOT NULL,
    [Number]      INT            NOT NULL,
    [Name]        INT            NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Book_BookId] INT            NULL,
    CONSTRAINT [PK_dbo.Drills] PRIMARY KEY CLUSTERED ([DrillId] ASC),
    CONSTRAINT [FK_dbo.Drills_dbo.Books_Book_BookId] FOREIGN KEY ([Book_BookId]) REFERENCES [dbo].[Books] ([BookId])
);


GO
CREATE NONCLUSTERED INDEX [IX_Book_BookId]
    ON [dbo].[Drills]([Book_BookId] ASC);

