CREATE TABLE [dbo].[Documenti] (
    [Id]       INT          NOT NULL IDENTITY,
    [codice]   INT          NOT NULL,
    [titolo]   VARCHAR (50) NOT NULL,
    [anno]     DATETIME         NOT NULL,
    [settore]  VARCHAR (50) NULL,
    [stato]    BIT          NOT NULL,
    [scaffale] INT          NULL,
    [autore]   VARCHAR (50) NOT NULL,
    [tipo]     CHAR (5)     NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

