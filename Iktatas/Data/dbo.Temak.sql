CREATE TABLE [dbo].[Temak] (
    [Id_Tema] INT        IDENTITY (1, 1) NOT NULL,
    [Tema]    NCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Tema] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Temak_Tema]
    ON [dbo].[Temak]([Tema] ASC);

