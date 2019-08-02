CREATE TABLE [dbo].[Estoque] (
    [Id]              INT IDENTITY (1, 1) NOT NULL,
    [IdLocacao]       INT NOT NULL,
    [IdCarro]         INT NOT NULL,
    
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Estoque_Carros] FOREIGN KEY ([IdCarro]) REFERENCES [dbo].[Carros] ([Id]),
    CONSTRAINT [FK_Estoque_Locacao] FOREIGN KEY ([IdLocacao]) REFERENCES [dbo].[Locacao] ([Id])
);

