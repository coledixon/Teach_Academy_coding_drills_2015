USE COMPANY;

--Select all product names, prices
--and manufacturer names 
SELECT P.Price, P.Name, M.Name
FROM Products as P
INNER JOIN Manufacturers as M
ON P.Manufacturer = M.Code