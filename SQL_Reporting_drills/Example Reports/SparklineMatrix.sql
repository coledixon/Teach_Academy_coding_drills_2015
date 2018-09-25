SELECT
  SUM(Sales.SalesOrderHeader.TotalDue) AS Sum_TotalDue
  ,YEAR(Sales.SalesOrderHeader.OrderDate) AS OrderYear
  ,MONTH(Sales.SalesOrderHeader.OrderDate) AS OrderMonth
  ,Sales.vSalesPerson.TerritoryName
  ,Sales.vSalesPerson.LastName
FROM
  Sales.SalesOrderHeader
  INNER JOIN Sales.vSalesPerson
    ON Sales.SalesOrderHeader.SalesPersonID = Sales.vSalesPerson.BusinessEntityID
GROUP BY
  YEAR(Sales.SalesOrderHeader.OrderDate)
  ,MONTH(Sales.SalesOrderHeader.OrderDate)
  ,Sales.vSalesPerson.TerritoryName
  ,Sales.vSalesPerson.LastName