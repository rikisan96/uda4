-- cra una chiave esteerna della colonna Prezzo della tabella prodotti alla colonna PrezzoUnitario della tabella Unione
ALTER TABLE dbo.Unione ADD CONSTRAINT FK_Unione_Prodotti FOREIGN KEY (PrezzoUnitario) REFERENCES dbo.Prodotti(Prezzo);

