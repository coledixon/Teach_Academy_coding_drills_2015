USE COMPANY;

--SELECT THE NAME OF PRODUCTS
--WITH A PRICE BETWEEN $60 & $120
SELECT Name, Price
FROM Products
WHERE Price BETWEEN 60 AND 120
ORDER BY Price DESC