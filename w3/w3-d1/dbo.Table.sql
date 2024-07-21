CREATE TABLE [dbo].[Cliente]
(
 IdCliente INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(50) NOT NULL,
    Cognome NVARCHAR(50) NOT NULL,
    DataNascita DATE NOT NULL,
    Sesso CHAR(1) NOT NULL,  -- 'M' per Maschio, 'F' per Femmina
    CF CHAR(16) NOT NULL,
    PIVA CHAR(11),
    Attivo BIT NOT NULL,
    Saldo DECIMAL(18, 2) NOT NULL
)
