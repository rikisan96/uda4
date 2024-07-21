-- Passo 1: Creare la nuova tabella VERBALI con la nuova struttura
CREATE TABLE [dbo].[VERBALI] (
    [IdVerbale]               INT             IDENTITY (1, 1) NOT NULL,
    [IdAnagrafica]            INT             NOT NULL,
    [IdViolazione]            INT             NOT NULL,
    [DataViolazione]          DATETIME2 (7)   NOT NULL,
    [IndirizzoViolazione]     VARCHAR (80)    NOT NULL,
    [Nominativo_Agente]       VARCHAR (50)    NOT NULL,
    [DataTrascrizioneVerbale] DATE            NOT NULL,
    [Importo]                 DECIMAL (10, 2) NOT NULL,
    [DecurtamentoPunti]       INT             NULL,
    PRIMARY KEY CLUSTERED ([IdVerbale] ASC),
    FOREIGN KEY ([IdAnagrafica]) REFERENCES [dbo].[ANAGRAFICHE] ([IdAnagrafica]),
    FOREIGN KEY ([IdViolazione]) REFERENCES [dbo].[TIPI_VIOLAZIONI] ([IdViolazione])
);

-- Passo 2: Trasferire i dati dalla vecchia tabella alla nuova tabella
INSERT INTO [dbo].[VERBALI] ([IdAnagrafica], [IdViolazione], [DataViolazione], [IndirizzoViolazione], [Nominativo_Agente], [DataTrascrizioneVerbale], [Importo], [DecurtamentoPunti])
SELECT [idanagrafica], [idviolazione], CAST([DataViolazione] AS DATETIME2(7)), LEFT([IndirizzoViolazione], 80), [Nominativo_Agente], [DataTrascrizioneVerbale], [Importo], [DecurtamentoPunti]
FROM [dbo].[VERBALE];