USE COMPANY;

--Select AVG() price of each
--manufacturers products by ID
SELECT AVG(Price) as AveragePricePerManufacturer, Manufacturer
FROM Products
GROUP BY Manufacturer;