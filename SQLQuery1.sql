SELECT * FROM Book

SELECT * FROM Genre

SELECT a.Name FROM Genre a
INNER JOIN BookGenre b ON a.Id = b.GenreId
WHERE b.BookId = 1;

SELECT a.Name FROM Genre a
INNER JOIN BookGenre b ON a.Id = b.GenreId
WHERE b.BookId = 11;

UPDATE Book
SET Name = 'The Holy Bible'
WHERE Id = 1;

INSERT INTO Book
VALUES ('The Cancer Code', 'Dr. Jason Fung', 360, 'A look at the history of cancer.');

DELETE FROM Book
WHERE Id = 12;