SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspGetStephenKingatIslaNublar]
AS
SELECT LB.BranchName, BC.No_ofCopies, BA.AuthorName, BB.Title
FROM Library.Branch LB
INNER JOIN Book.Copies BC
ON LB.BranchID=BC.BranchID
INNER JOIN Book.Book BB
ON BC.BookID=BB.BookID
INNER JOIN Book.Authors BA
ON BC.BookID=BA.BookID
WHERE BA.AuthorName='Stephen King' AND LB.BranchName='Isla Nublar'