SELECT
  YEAR(Sales.SalesOrderHeader.OrderDate) AS OrderYear
  ,MONTH(Sales.SalesOrderHeader.OrderDate) AS OrderMonth
  ,SUM(Sales.SalesOrderHeader.TotalDue) AS Sum_TotalDue
FROM
  Sales.SalesOrderHeader
GROUP BY
  YEAR(Sales.SalesOrderHeader.OrderDate)
  ,MONTH(Sales.SalesOrderHeader.OrderDate)