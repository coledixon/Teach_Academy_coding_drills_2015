ALTER PROCEDURE [dbo].[uspGetSharpstownLostTribe]
AS
SELECT *
FROM Library.Branch AS LB
INNER JOIN Book.Copies AS BC
ON LB.BranchID = BC.BranchID
INNER JOIN Book.Book AS BB
ON BC.BookID = BB.BookID
WHERE BB.BookID='0001' AND LB.BranchID='53104'