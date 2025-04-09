
CREATE PROCEDURE GetBooksSortedByPublisherAuthorTitle
AS
BEGIN
    SELECT * FROM Books
    ORDER BY Publisher, AuthorLastName, AuthorFirstName, Title;
END;
GO


CREATE PROCEDURE GetBooksSortedByAuthorTitle
AS
BEGIN
    SELECT * FROM Books
    ORDER BY AuthorLastName, AuthorFirstName, Title;
END;
GO
