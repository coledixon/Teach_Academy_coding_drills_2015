CREATE TABLE Book.Rating
(BookId int PRIMARY KEY,
Rating int null,
Author char(25) FOREIGN KEY REFERENCES Book.Authors(AuthorName),
BranchID varchar(20 )FOREIGN KEY REFERENCES Library.Branch(BranchID))