--CREATE TABLE Authors
--(
--	Id INT NOT NULL IDENTITY PRIMARY KEY,
--	FirstName NVARCHAR(100) NOT NULL,
--	LastName NVARCHAR(100) NOT NULL
--)

--CREATE TABLE Books
--(
--	Id INT NOT NULL IDENTITY PRIMARY KEY,
--	AuthorId INT NOT NULL FOREIGN KEY(AuthorId) REFERENCES Authors(Id),
--	Title NVARCHAR(100) NOT NULL,
--	Price MONEY,
--	Pages INT
--)

--CREATE PROC GetBooksNumber
--@AuthorId INT,
--@BookCount INT OUTPUT
--AS
--BEGIN
--	SET NOCOUNT ON;
--	SELECT @BookCount = COUNT(b.Id)
--	FROM Books b, Authors a
--	WHERE b.AuthorId = a.Id AND a.Id = @AuthorId
--END;

--INSERT INTO Books(AuthorId, Title, Price, Pages)
--VALUES(1, N'Тест', 500, 1000),
--(2, N'Тест_1', 500, 1000)

--SELECT * FROM Books