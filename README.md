#Developer Assessment

This is a .NET Core Web API Assessment using ASP.NET Core  and Entity Framework Core with a Code First approach, designed to manage book-related data. The application follows RESTful principles and connects to a SQL Server database.


Implementation:

1)Developed a .NET Core Web API using MVC architecture.

2)Created the Book model with properties: Publisher, Title, AuthorFirstName, AuthorLastName, and Price.

3)Added MLA and Chicago citation properties to the Book class.

4)Used Entity Framework Core ORM with Code First Approach for data modeling and database generation.

5)Designed and created a SQL Server database schema using EF Core migrations.

6)Implemented the Repository Pattern and Service Layer to follow clean architecture principles.

7)Created API endpoints to:
    Get books sorted by Publisher → Author (First, Last) → Title.
    Get books sorted by Author (First, Last) → Title.

8)Implemented the same sorting logic using Stored Procedures.

9)Integrated stored procedure calls using EF Core's FromSqlInterpolated method.

10)Developed an API to return the total price of all books.

11)Created a bulk insert API to save a large list of books in a single database call.

12)Applied Dependency Injection (DI) and followed Inversion of Control (IoC).

13)Used async/await for all asynchronous database operations.

14)Integrated Swagger for API documentation and testing.

15)Included test data and SQL scripts for validation and demonstration of all functionalities
