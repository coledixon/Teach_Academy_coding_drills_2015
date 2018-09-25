USE COMPANY;

--Select AVG() price of each
--manufacturers products by ID
SELECT AVG(Price) as AveragePricePerManufacturer, CAST(m.Name as varchar) as Name
FROM Products, Manufacturers as m
WHERE Products.Manufacturer = m.Code
GROUP BY CAST(m.name as varchar);