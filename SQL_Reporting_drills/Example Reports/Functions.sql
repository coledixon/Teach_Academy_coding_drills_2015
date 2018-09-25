SELECT
  Sales.SalesOrderHeader.TotalDue
FROM
  Sales.SalesOrderHeader

  --EXPRESSIONS
=Sum(Fields!TotalDue.Value, "SampleDataSet")

=Count(Fields!TotalDue.Value, "SampleDataSet")

=Avg(Fields!TotalDue.Value, "SampleDataSet")