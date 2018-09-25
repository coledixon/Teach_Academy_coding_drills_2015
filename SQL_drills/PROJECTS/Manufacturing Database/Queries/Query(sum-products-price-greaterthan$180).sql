USE COMPANY;

--Sum of the products with a price
--higher than $180
SELECT SUM(Price) as SumOfItemsOver180
FROM Products
WHERE Price >= 180