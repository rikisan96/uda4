CREATE TABLE Clienti (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
    Tipo NVARCHAR(50) NOT NULL, -- 'Privato' o 'Azienda'
    CodiceFiscale NVARCHAR(16) NULL, -- Solo per privati
    PartitaIva NVARCHAR(11) NULL -- Solo per aziende
);


CREATE TABLE Spedizioni (
    Id INT PRIMARY KEY IDENTITY(1,1),
    ClienteId INT NOT NULL, -- Foreign key che riferisce a Clienti
    NumeroIdentificativo NVARCHAR(50) NOT NULL,
    DataSpedizione DATETIME NOT NULL,
    Peso DECIMAL(10, 2) NOT NULL,
    CittaDestinataria NVARCHAR(100) NOT NULL,
    IndirizzoDestinatario NVARCHAR(200) NOT NULL,
    NominativoDestinatario NVARCHAR(100) NOT NULL,
    CostoSpedizione DECIMAL(10, 2) NOT NULL,
    DataConsegnaPrevista DATETIME NOT NULL,
    FOREIGN KEY (ClienteId) REFERENCES Clienti(Id)
);


CREATE TABLE AggiornamentiSpedizioni (
    Id INT PRIMARY KEY IDENTITY(1,1),
    SpedizioneId INT NOT NULL, -- Foreign key che riferisce a Spedizioni
    Stato NVARCHAR(50) NOT NULL, -- 'In transito', 'In consegna', 'Consegnato', 'Non consegnato'
    Luogo NVARCHAR(100) NOT NULL,
    Descrizione NVARCHAR(500) NULL,
    DataAggiornamento DATETIME NOT NULL,
    FOREIGN KEY (SpedizioneId) REFERENCES Spedizioni(Id)
);
