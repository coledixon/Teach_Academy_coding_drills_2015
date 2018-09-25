USE COMPANY;

--Name and Product >= $180
--sorted by name ASC and price DESC
SELECT Name, Price
FROM Products
WHERE Price >= 180
ORDER BY Price DESC, CAST(Name as varchar) ASC