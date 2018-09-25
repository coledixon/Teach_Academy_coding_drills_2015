SELECT LB.BranchName, COUNT(DateOut) as BooksOut
AS DateOutTotal
FROM Book.Loans AS BL
INNER JOIN Library.Branch AS LB
ON BL.BranchID=LB.BranchID
GROUP BY LB.BranchName