SELECT
  Sales.vIndividualCustomer.StateProvinceName
  ,Sales.vIndividualCustomer.BusinessEntityID
FROM
  Sales.vIndividualCustomer
WHERE
  Sales.vIndividualCustomer.CountryRegionName = N'United States'