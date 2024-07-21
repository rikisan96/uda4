CREATE TABLE Cantiere (
    IdCantiere INT PRIMARY KEY IDENTITY(1,1),
    DenominazioneCantiere NVARCHAR(100) NOT NULL,
    Indirizzo NVARCHAR(255) NOT NULL,
    Citta NVARCHAR(50) NOT NULL,
    CAP CHAR(5) NOT NULL,
    PersonaRiferimento NVARCHAR(100) NOT NULL,
    DataInizioLavori DATE NOT NULL,
    DataFineLavori DATE,
    LavoriTerminatiSI_NO BIT NOT NULL
);