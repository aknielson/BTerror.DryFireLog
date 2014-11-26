CREATE TABLE [dbo].[DryFireSessions] (
    [DryFireSessionId] INT      IDENTITY (1, 1) NOT NULL,
    [SessionDate]      DATETIME NOT NULL,
    CONSTRAINT [PK_dbo.DryFireSessions] PRIMARY KEY CLUSTERED ([DryFireSessionId] ASC)
);

