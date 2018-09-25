INSERT INTO Book.Book (BookID)
	SELECT BC.No_ofCopies
	FROM Book.Copies as BC
	WHERE BC.No_ofCopies= 14 and Book.Authors= 
		(SELECT AuthorName FROM Book.Authors WHERE AuthorName = 'Dan%' )