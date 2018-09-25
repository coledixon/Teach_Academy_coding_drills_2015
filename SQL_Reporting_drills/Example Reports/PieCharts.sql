SELECT
  COUNT(Sales.vIndividualCustomer.BusinessEntityID) AS Count_BusinessEntityID
  ,Sales.vIndividualCustomer.CountryRegionName
FROM
  Sales.vIndividualCustomer
GROUP BY
  Sales.vIndividualCustomer.CountryRegionName