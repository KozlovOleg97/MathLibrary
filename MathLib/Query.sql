CREATE TABLE Products 
(
	ProductID INT IDENTITY(1,1) PRIMARY KEY,
	ProductName NVARCHAR(100) NOT NULL
);

CREATE TABLE Categories 
(
	CategoryID INT IDENTITY(1,1) PRIMARY KEY,
	CategoryName NVARCHAR(100) NOT NULL 
);

CREATE TABLE ProductCategories 
(
	ProductID INT NOT NULL,
	CategoryID INT NOT NULL,     
	PRIMARY KEY (ProductID, CategoryID),
	FOREIGN KEY (ProductID) REFERENCES Products(ProductID) ON DELETE CASCADE,
	FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID) ON DELETE CASCADE
);

CREATE INDEX IX_ProductCategories_ProductID ON ProductCategories(ProductID);
CREATE INDEX IX_ProductCategories_CategoryID ON ProductCategories(CategoryID);

INSERT INTO Products (ProductName) VALUES
('Product A'),
('Product B'),
('Product C'),
('Product D');

INSERT INTO Categories (CategoryName) VALUES
('Category 1'),
('Category 2'),
('Category 3');

INSERT INTO ProductCategories (ProductID, CategoryID) VALUES
(1, 1),
(1, 2),
(2, 1),
(3, 3);

SELECT product.ProductName, category.CategoryName
FROM Products product
LEFT JOIN ProductCategories productCategory ON product.ProductID = productCategory.ProductID
LEFT JOIN Categories category ON productCategory.CategoryID = category.CategoryID
ORDER BY product.ProductName, category.CategoryName;