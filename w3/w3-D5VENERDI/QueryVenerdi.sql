--Riccardo Cutruneo---------------------------------------------------CREA TABELLE E DEFINISCI CHIAVI-----------------------------------------------------------------------------------------------------------------------
CREATE TABLE ANAGRAFICA (
    idanagrafica INT PRIMARY KEY,
    Cognome VARCHAR(50),
    Nome VARCHAR(50),
    Indirizzo VARCHAR(100),
    Città VARCHAR(50),
    CAP VARCHAR(10),
    Cod_Fisc VARCHAR(16)
);

-- Creazione tabella TIPO VIOLAZIONE
CREATE TABLE TIPO_VIOLAZIONE (
    idviolazione INT PRIMARY KEY,
    descrizione VARCHAR(255)
);

-- Creazione tabella VERBALE
CREATE TABLE VERBALE (
    idverbale INT PRIMARY KEY,
    idanagrafica INT,
    idviolazione INT,
    DataViolazione DATE,
    IndirizzoViolazione VARCHAR(100),
    Nominativo_Agente VARCHAR(50),
    DataTrascrizioneVerbale DATE,
    Importo DECIMAL(10, 2),
    DecurtamentoPunti INT,
    FOREIGN KEY (idanagrafica) REFERENCES ANAGRAFICA(idanagrafica),
    FOREIGN KEY (idviolazione) REFERENCES TIPO_VIOLAZIONE(idviolazione)
);



-- Popolazione tabella ANAGRAFICA
INSERT INTO ANAGRAFICA (idanagrafica, Cognome, Nome, Indirizzo, Città, CAP, Cod_Fisc) VALUES
(1, 'Rossi', 'Mario', 'Via Roma 1', 'Palermo', '90100', 'RSSMRA80A01H501Z'),
(2, 'Bianchi', 'Luigi', 'Corso Italia 22', 'Milano', '20100', 'BNCGLG75B15F205Z'),
(3, 'Verdi', 'Giulia', 'Piazza Garibaldi 10', 'Napoli', '80100', 'VRDGLI85C60F839Z'),
(4, 'Neri', 'Carla', 'Via Mazzini 5', 'Firenze', '50100', 'NERCAR90D20F205Y'),
(5, 'Russo', 'Marco', 'Via Napoli 12', 'Roma', '00100', 'RSSMRC78B01H501A'),
(6, 'Gialli', 'Anna', 'Piazza Duomo 6', 'Torino', '10100', 'GLNNNA70A41H501K'),
(7, 'Bruno', 'Giorgio', 'Via Verdi 7', 'Bologna', '40100', 'BRNGRG82C01H501L'),
(8, 'Ferrari', 'Elena', 'Via Cavour 8', 'Venezia', '30100', 'FRRLNE85A61H501M'),
(9, 'Marini', 'Luca', 'Via Dante 9', 'Genova', '16100', 'MRNLCA90B01H501N'),
(10, 'Esposito', 'Marta', 'Via Manzoni 10', 'Palermo', '90100', 'ESPTRT92C01H501O');

-- Popolazione tabella TIPO VIOLAZIONE
INSERT INTO TIPO_VIOLAZIONE (idviolazione, descrizione) VALUES
(1, 'Eccesso di velocità'),
(2, 'Parcheggio in divieto di sosta'),
(3, 'Guida senza cintura'),
(4, 'Uso del cellulare alla guida'),
(5, 'Passaggio con semaforo rosso');

-- Popolazione tabella VERBALE con più dati
INSERT INTO VERBALE (idverbale, idanagrafica, idviolazione, DataViolazione, IndirizzoViolazione, Nominativo_Agente, DataTrascrizioneVerbale, Importo, DecurtamentoPunti) VALUES
(1, 1, 1, '2023-01-15', 'Via Roma 1', 'Agente A', '2023-01-16', 150.00, 3),
(2, 2, 2, '2023-02-20', 'Corso Italia 22', 'Agente B', '2023-02-21', 200.00, 2),
(3, 3, 3, '2023-03-05', 'Piazza Garibaldi 10', 'Agente C', '2023-03-06', 300.00, 5),
(4, 4, 4, '2023-04-10', 'Via Mazzini 5', 'Agente D', '2023-04-11', 250.00, 4),
(5, 5, 5, '2023-05-15', 'Via Napoli 12', 'Agente E', '2023-05-16', 400.00, 6),
(6, 6, 1, '2023-06-20', 'Piazza Duomo 6', 'Agente F', '2023-06-21', 180.00, 3),
(7, 7, 2, '2023-07-25', 'Via Verdi 7', 'Agente G', '2023-07-26', 220.00, 2),
(8, 8, 3, '2023-08-30', 'Via Cavour 8', 'Agente H', '2023-08-31', 350.00, 5),
(9, 9, 4, '2023-09-10', 'Via Dante 9', 'Agente I', '2023-09-11', 270.00, 4),
(10, 10, 5, '2023-10-15', 'Via Manzoni 10', 'Agente J', '2023-10-16', 420.00, 6),
(11, 1, 2, '2023-11-20', 'Via Roma 1', 'Agente A', '2023-11-21', 100.00, 1),
(12, 2, 3, '2023-12-25', 'Corso Italia 22', 'Agente B', '2023-12-26', 330.00, 5);

----------------------------------------------------LE 12 QUERY---------------------------------------------------------------------------------------------------------------------------------------------


SELECT COUNT(*) as Verbali FROM VERBALE; 
--1. Conteggio dei verbali trascritti

SELECT idanagrafica, COUNT(*) as Verbali  FROM VERBALE GROUP BY idanagrafica;
--2. Conteggio dei verbali trascritti raggruppati per anagrafe

SELECT idviolazione, COUNT(*) as Verbali FROM VERBALE GROUP BY idviolazione;
--3. Conteggio dei verbali trascritti raggruppati violazione

SELECT idanagrafica, SUM(DecurtamentoPunti) as PuntiDecurtati FROM VERBALE GROUP BY idanagrafica;
--4. Somma dei punti decurtati per anagrafica

SELECT a.Cognome, a.Nome, v.DataViolazione, v.IndirizzoViolazione, v.Importo, v.DecurtamentoPunti FROM ANAGRAFICA a JOIN VERBALE v ON a.idanagrafica = v.idanagrafica WHERE a.Città = 'Palermo';
--5. Cognome, Nome, Data violazione, Indirizzo violazione, importo e punti decurtati per tutti gli anagrafici residenti a Palermo

SELECT a.Cognome, a.Nome, a.Indirizzo, v.DataViolazione, v.Importo, v.DecurtamentoPunti FROM ANAGRAFICA a JOIN VERBALE v ON a.idanagrafica = v.idanagrafica WHERE v.DataViolazione BETWEEN '2009-02-01' AND '2009-07-31';
--6 punti decurtati per anagrafica sulle violazioni fatte tra il febbraio 2009 e luglio 2009

SELECT idanagrafica, SUM(Importo) FROM VERBALE GROUP BY idanagrafica;
--7. Totale degli importi per ogni anagrafica

SELECT * FROM ANAGRAFICA WHERE Città = 'Palermo';
--8. Visualizzazione di tutti gli anagrafici residenti a Palermo

SELECT DataViolazione, Importo, DecurtamentoPunti FROM VERBALE WHERE DataViolazione = '2023-01-15';
--9. Query che visualizzi Data violazione, Importo e decurtamento punti relativi ad una certa data

SELECT Nominativo_Agente, COUNT(*) FROM VERBALE GROUP BY Nominativo_Agente;
--10. Conteggio delle violazioni contestate raggruppate per Nominativo dell’agente di Polizia

SELECT a.Cognome, a.Nome, a.Indirizzo, v.DataViolazione, v.Importo, v.DecurtamentoPunti FROM ANAGRAFICA a JOIN VERBALE v ON a.idanagrafica = v.idanagrafica WHERE v.DecurtamentoPunti > 5;
--11. Cognome, Nome, Indirizzo, Data violazione, Importo e punti decurtati per tutte le violazioni che superino il decurtamento di 5 punti

SELECT a.Cognome, a.Nome, a.Indirizzo, v.DataViolazione, v.Importo, v.DecurtamentoPunti FROM ANAGRAFICA a JOIN VERBALE v ON a.idanagrafica = v.idanagrafica WHERE v.Importo > 400;
--12. Cognome, Nome, Indirizzo, Data violazione, Importo e punti decurtati per tutte le violazioni che superino l’importo di 400 euro
