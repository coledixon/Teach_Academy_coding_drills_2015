UPDATE Book.Loans SET DueDate=DATEADD(dd,10,DateOut)
WHERE DateOut = '2015'

select * from Book.Loans