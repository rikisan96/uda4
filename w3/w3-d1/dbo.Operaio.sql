CREATE TABLE Operaio (
    IdDipendente INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(50) NOT NULL,
    Cognome NVARCHAR(50) NOT NULL,
    CF CHAR(16) NOT NULL,
    FigliACarico INT NOT NULL,
    Sposato BIT NOT NULL,
    LivelloLavorativo NVARCHAR(50) NOT NULL,
    DescrizioneMansione NVARCHAR(255),
    Salario DECIMAL(18, 2) NOT NULL
);
