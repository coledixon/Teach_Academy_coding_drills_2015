USE COMPANY;

--Select all data from Products
--and Manufacturers
SELECT *
FROM Products as P
INNER JOIN Manufacturers as M
ON P.Manufacturer = M.Code