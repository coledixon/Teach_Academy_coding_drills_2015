SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspGetBooksOutGreaterThan5]
AS
SELECT B.Name, B. Address, COUNT(DateOut)
AS BooksOut
FROM Borrower AS B
INNER JOIN Book.Loans AS BL
ON BL.CardNo=B.CardNo
GROUP BY B.Name, B.Address
HAVING COUNT(DateOut) > 5