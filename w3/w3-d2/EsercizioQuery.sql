/*Utilizzando il Database Nortwind, scaricato ed opportunamente importato in SQL Server, creare le seguenti istruzioni SQL:

1) Selezione di tutti i prodotti (tutti i campi),

2) Selezione di tutti i prodotti con uno quantità disponibile (UnitsInStock) di almeno 40 pezzi,

3) Selezione di tutti i clienti (Employees) che abitano a Londra,

4) Selezione di tutti gli ordini, ordinati in ordine decrescente per spese di trasporto (Freight),

5) Selezione degli ordini il cui importo del trasporto è superiore a 90 e inferiore i 200,

6) Selezione di tutti i prodotti la cui categoria è "1",

7) Selezione di tutte le righe dei dettagli degli ordini che hanno applicato uno sconto,

8) Selezione di tutti gli ordini del cliente con ID "BOTTM" le cui spese di trasporto superano l'importo di 50.
*/


USE [Epicode-EserciziMySQL]

select ProductName, UnitPrice  from Products where UnitPrice > 20

SELECT * FROM Products

SELECT * FROM Products WHERE UnitsInStock >= 40

SELECT * FROM Employees WHERE City = 'London'

SELECT * FROM Orders ORDER BY Freight DESC

SELECT * FROM Orders WHERE Freight > 90 AND Freight < 200

SELECT * FROM Products WHERE CategoryID = 1

SELECT * FROM [Order Details] WHERE Discount > 0

SELECT * FROM Orders WHERE CustomerID = 'BOTTM' AND Freight > 50


