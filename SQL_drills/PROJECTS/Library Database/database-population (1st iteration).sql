USE SQLDrill
GO

INSERT INTO Book.Book (Title, PublisherName)
VALUES ('A', 'A'),('B', 'A'),('C','B'),('D','A'),('E','B'),
('F', 'C'),('G', 'A'),('H','B'),('I','B'),('J','C'),('K', 'A'),('L', 'C'),
('M','A'),('N','B'),('O','D'),('P', 'A'),('Q', 'B'),('R','D'),('S','C'),('T','D'),
('U', 'C'),('V', 'B'),('W','D'),('X','A'),('Y','C'),('Z','D')

INSERT INTO Book.Authors (AuthorName)
VALUES ('Mariah Campbell'),('Daniel Prewitt'),
('Misty Stanley'),('Joe Jones'),('Tony Vilorio')

INSERT INTO Publisher (Name, Address, Phone)
VALUES ('A','123 Fake St. Portland, OR','971-224-2786'),
('B','77 Lydon Dublin, Ireland',''),('C','6497 Jeff Goldblum Manor','+44-655-3214'),
('D','53104 Alkaline Chicago, IL','491-753-7756')

INSERT INTO	Library.Branch (BranchName, Address)
VALUES ('Isla Nublar','Nevada'),('Sharpstown','Oregon'),
('Isla Sorna','New York'),('Main One','Washington')

INSERT INTO Borrower (Name, Address, Phone)
VALUES ('Cole','Portland, OR','503-706-9812'),('Alex','New York','541-360-0542'),
('Jeff','Washington','360-917-5032'),('Kevin','Oregon','971-224-2256'),
('Casey','New York','710-623-9000'),('Kendra','','202-265-9531'),('Miraim','','914-752-7441')

UPDATE Book.Authors
SET Book.Authors.BookID =(SELECT Book.Book.BookID 
FROM Book.Book WHERE Book.Book.BookID = Book.Authors.BookID)

SELECT bookID FROM Book.Authors
