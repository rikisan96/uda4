-- Passo 1: Creare la nuova tabella TIPI_VIOLAZIONI con la nuova struttura
CREATE TABLE [dbo].[TIPI_VIOLAZIONI] (
    [IdViolazione] INT IDENTITY (1, 1) NOT NULL,
    [Descrizione]  VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([IdViolazione] ASC)
);

-- Passo 2: Trasferire i dati dalla vecchia tabella alla nuova tabella
INSERT INTO [dbo].[TIPI_VIOLAZIONI] ([Descrizione])
SELECT [descrizione]
FROM [dbo].[TIPO_VIOLAZIONE];