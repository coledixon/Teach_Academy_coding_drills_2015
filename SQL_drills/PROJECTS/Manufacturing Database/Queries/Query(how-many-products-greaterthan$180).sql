USE COMPANY;

--Compute the number of products with a price
--higher than $180
SELECT COUNT(*) AS TotalProductsPrice180
FROM Products
WHERE Price >= 180