-- Stored Procedure 1: Sort by Publisher, Author, Title
CREATE PROCEDURE GetBooksSortedByPublisherAuthorTitle
AS
BEGIN
    SELECT * FROM Books
    ORDER BY Publisher, AuthorLastName, AuthorFirstName, Title;
END;
GO

-- Stored Procedure 2: Sort by Author, Title
CREATE PROCEDURE GetBooksSortedByAuthorTitle
AS
BEGIN
    SELECT * FROM Books
    ORDER BY AuthorLastName, AuthorFirstName, Title;
END;
GO
