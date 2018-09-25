USE COMPANY;

--Average price of all products
--from manufacturer with the ID of 2
SELECT CAST(Name AS VARCHAR) AS ProductName, AVG(Price) AS AveragePrice
FROM Products
WHERE Manufacturer = 2
GROUP BY CAST (Name AS VARCHAR)