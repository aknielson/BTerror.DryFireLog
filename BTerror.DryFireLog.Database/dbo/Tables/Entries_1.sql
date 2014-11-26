CREATE TABLE [dbo].[Entries] (
    [EntryId]                         INT             IDENTITY (1, 1) NOT NULL,
    [EntryDate]                       DATETIME        NOT NULL,
    [InitialPar]                      DECIMAL (18, 2) NOT NULL,
    [EndingPar]                       DECIMAL (18, 2) NOT NULL,
    [RepititionsCompleted]            INT             NOT NULL,
    [DrillId]                         INT             NOT NULL,
    [DryFireSession_DryFireSessionId] INT             NULL,
    CONSTRAINT [PK_dbo.Entries] PRIMARY KEY CLUSTERED ([EntryId] ASC),
    CONSTRAINT [FK_dbo.Entries_dbo.Drills_DrillId] FOREIGN KEY ([DrillId]) REFERENCES [dbo].[Drills] ([DrillId]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Entries_dbo.DryFireSessions_DryFireSession_DryFireSessionId] FOREIGN KEY ([DryFireSession_DryFireSessionId]) REFERENCES [dbo].[DryFireSessions] ([DryFireSessionId])
);


GO
CREATE NONCLUSTERED INDEX [IX_DrillId]
    ON [dbo].[Entries]([DrillId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_DryFireSession_DryFireSessionId]
    ON [dbo].[Entries]([DryFireSession_DryFireSessionId] ASC);

