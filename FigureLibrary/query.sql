CREATE TABLE Products (
	ProductId INT PRIMARY KEY,
	"Title" TEXT
);

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Title" TEXT
);

INSERT INTO Products
VALUES 
	(1, "Samsung"),
	(2, "Apple"),
	(3, "Sony"),
	(4, "BlackBerry")
  	(5, "BMW");

INSERT INTO Categories
VALUES
	(1, 'Phone'),
	(2, 'Console'),
	(3, 'Television');

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(1, 1),
  	(1, 3)
	(2, 1),
  	(3, 2),
	(4, 1);

SELECT P."Title", C."Title"
FROM Products P
LEFT JOIN ProductCategories PC ON P.Id = PC.ProductId
LEFT JOIN Categories C ON PC.CategoryId = C.Id;
