CREATE DATABASE ASS2_DB;
GO
USE ASS2_DB;
GO

/*MEMBER*/
CREATE TABLE Member (
    MemberId INT,
	Email VARCHAR(100) NOT NULL,
	CompanyName VARCHAR(40) NOT NULL,
	City VARCHAR(15) NOT NULL,
	Country VARCHAR(15) NOT NULL,
	Password VARCHAR(30) NOT NULL,
	isAdmin BIT NOT NULL,
    CONSTRAINT PK_Member PRIMARY KEY (MemberId)
)
GO

/*ORDER*/
CREATE TABLE [Order] (
    OrderId INT,
	MemberId INT NOT NULL, 
	OrderDate DATETIME NOT NULL,
	RequiredDate DATETIME,
	ShippedDate DATETIME,
	Freight MONEY,
	CONSTRAINT FK_MemberId FOREIGN KEY (MemberId) REFERENCES Member(MemberId),
    CONSTRAINT PK_Order PRIMARY KEY (OrderId)
)
GO

/*PRODUCT*/
CREATE TABLE Product (
    ProductId INT,
	Category INT NOT NULL, 
	ProductName VARCHAR(40) NOT NULL,
	Weight VARCHAR(20) NOT NULL,
	UnitPrice MONEY NOT NULL,
	UnitsInStock INT NOT NULL,
    CONSTRAINT PK_Product PRIMARY KEY (ProductId)
)
GO

/*ORDER DETAIL*/
CREATE TABLE OrderDetail (
    OrderId INT,
	ProductId INT NOT NULL, 
	OrderDate datetime NOT NULL,
	UnitPrice money NOT NULL,
	Quantity int NOT NULL,
	Discount float NOT NULL,
	CONSTRAINT FK_OrderId FOREIGN KEY (OrderId) REFERENCES [Order](OrderId),
	CONSTRAINT FK_ProductId FOREIGN KEY (ProductId) REFERENCES Product(ProductId),
    CONSTRAINT PK_OrderDetail PRIMARY KEY NONCLUSTERED (OrderId, ProductId)
)
GO