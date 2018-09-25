SELECT
  Sales.SalesTerritory.Name
  ,Sales.SalesTerritory.SalesYTD
  ,Sales.SalesTerritory.SalesLastYear
FROM
  Sales.SalesTerritory
  
 --INDICATOR PARAMETERS 
  =Fields!SalesLastYear.Value
  
  =Fields!SalesLastYear.Value+1