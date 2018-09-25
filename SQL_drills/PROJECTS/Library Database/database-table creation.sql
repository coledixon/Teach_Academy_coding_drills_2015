DROP DATABASE SQLDrill

CREATE DATABASE SQLDrill
GO

USE SQLDrill
GO

CREATE SCHEMA Book
GO

CREATE SCHEMA Library
GO

CREATE TABLE Library.Branch(
BranchID int IDENTITY(01,05) PRIMARY KEY,
BranchName VARCHAR(25) not null,
Address VARCHAR(30) not null
)

CREATE TABLE Borrower (
CardNo int IDENTITY(1,4) PRIMARY KEY,
Name VARCHAR(40) not null,
Address VARCHAR(30),
Phone VARCHAR(12) not null
)


CREATE TABLE Publisher(
Name VARCHAR(50) PRIMARY KEY,
Address VARCHAR(30) not null,
Phone VARCHAR(12)
)

CREATE TABLE Book.Book(
BookID int IDENTITY(0001,1) PRIMARY KEY,
Title VARCHAR(50) not null,
PublisherName VARCHAR(50) FOREIGN KEY REFERENCES Publisher(Name) not null
)

CREATE TABLE Book.Authors(
BookID int FOREIGN KEY REFERENCES Book.Book(BookID),
AuthorName VARCHAR(40) not null
)

CREATE TABLE Book.Loans(
BookID int FOREIGN KEY REFERENCES Book.Book(BookID) not null,
BranchID int FOREIGN KEY REFERENCES Library.Branch(BranchID) not null,
CardNo int FOREIGN KEY REFERENCES Borrower(CardNo) not null,
DateOut date not null,
DueDate date not null
)

CREATE TABLE Book.Copies(
BookID int FOREIGN KEY REFERENCES Book.Book(BookID) not null,
BranchID int FOREIGN KEY REFERENCES Library.Branch(BranchID) not null,
No_ofCopies int not null
)