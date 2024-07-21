-- Creare la nuova tabella ANAGRAFICHE con la nuova struttura
CREATE TABLE [dbo].[ANAGRAFICHE] (
    [IdAnagrafica] INT IDENTITY (1, 1) NOT NULL,
    [Cognome]      VARCHAR (50) NULL,
    [Nome]         VARCHAR (50) NULL,
    [Indirizzo]    VARCHAR (80) NULL,
    [Città]        VARCHAR (58) NULL,
    [CAP]          VARCHAR (10) NULL,
    [Cod_Fisc]     VARCHAR (16) NULL,
    PRIMARY KEY CLUSTERED ([IdAnagrafica] ASC)
);

-- Trasferire i dati dalla vecchia tabella alla nuova tabella
INSERT INTO [dbo].[ANAGRAFICHE] ([Cognome], [Nome], [Indirizzo], [Città], [CAP], [Cod_Fisc])
SELECT [Cognome], [Nome], LEFT([Indirizzo], 80), LEFT([Città], 60), [CAP], [Cod_Fisc]
FROM [dbo].[ANAGRAFICA];


