CREATE DATABASE ASS2_DB;
GO
USE ASS2_DB;
GO

/*MEMBER*/
CREATE TABLE Member (
    MemberId INT IDENTITY(1,1),
	Email VARCHAR(100) NOT NULL,
	CompanyName VARCHAR(40) NOT NULL,
	City VARCHAR(15) NOT NULL,
	Country VARCHAR(15) NOT NULL,
	Password VARCHAR(30) NOT NULL,
	isAdmin BIT NOT NULL,
    CONSTRAINT PK_Member PRIMARY KEY (MemberId)
)
GO


INSERT INTO Member (Email, CompanyName, City, Country, Password, isAdmin)
values
('dknhien@gmail.com', 'FPT', 'HCM', 'Viet Nam', '12345678', 1),
('tcvy@gmail.com', 'FPT', 'Ha Noi', 'Viet Nam', '12345678', 1),
('lmnhat@gmail.com', 'FPT', 'Quy Nhon', 'Viet Nam', '12345678', 1),
('ddtung@gmail.com', 'FPT', 'Hai Phong', 'Viet Nam', '12345678', 1),
('tlhnhan@gmail.com', 'FPT', 'HCM', 'Viet Nam', '12345678', 1),
('tvdat@gmail.com', 'ABC', 'Da Nang', 'Viet Nam', '12345678', 1),
('lnquang@gmail.com', 'PHP', 'Phu Yen', 'Viet Nam', '12345678', 1),
('vdhoa@gmail.com', 'High Land', 'Nha Trang', 'Viet Nam', '12345678', 1),
('dnbchau@gmail.com', 'Duy Tan', 'Binh Dinh', 'Viet Nam', '12345678', 0),
('cdquan@gmail.com', 'HUTECH', 'HCM', 'Viet Nam', '12345678', 0),
('ntbngoc@gmail.com', 'HUTECH', 'HCM', 'Viet Nam', '12345678', 0),
('pqanh@gmail.com', 'HUTECH', 'HCM', 'Viet Nam', '12345678', 0)

GO

/*ORDER*/
CREATE TABLE UserOrder (
    OrderId INT IDENTITY(1,1),
	MemberId INT NOT NULL, 
	OrderDate DATETIME NOT NULL,
	RequiredDate DATETIME,
	ShippedDate DATETIME,
	Freight MONEY,
	CONSTRAINT FK_MemberId FOREIGN KEY (MemberId) REFERENCES Member(MemberId),
    CONSTRAINT PK_Order PRIMARY KEY (OrderId)
)
GO

INSERT INTO UserOrder (MemberId, OrderDate, RequiredDate, ShippedDate, Freight)
values
(1, '2022-06-25 10:30:30', '2022-07-25 10:30:30', '2022-07-10 10:30:30', 100),
(2, '2022-06-26 10:30:30', '2022-07-26 10:30:30', '2022-07-11 10:30:30', 200),
(3, '2022-06-27 10:30:30', '2022-07-27 10:30:30', '2022-07-12 10:30:30', 300),
(4, '2022-06-28 10:30:30', '2022-07-28 10:30:30', '2022-07-13 10:30:30', 400),
(5, '2022-06-29 10:30:30', '2022-07-29 10:30:30', '2022-07-14 10:30:30', 500),
(6, '2022-06-30 10:30:30', '2022-07-30 10:30:30', '2022-07-15 10:30:30', 600),
(7, '2022-07-01 10:30:30', '2022-07-31 10:30:30', '2022-07-16 10:30:30', 700),
(8, '2022-07-02 10:30:30', '2022-08-01 10:30:30', '2022-07-17 10:30:30', 800),
(9, '2022-07-03 10:30:30', '2022-08-02 10:30:30', '2022-07-14 18:30:30', 900),
(10, '2022-07-04 10:30:30', '2022-08-03 10:30:30', '2022-07-19 10:30:30', 1000)
GO


/*PRODUCT*/
CREATE TABLE Product (
    ProductId INT IDENTITY(1,1),
	Category INT NOT NULL, 
	ProductName VARCHAR(40) NOT NULL,
	Weight VARCHAR(20) NOT NULL,
	UnitPrice MONEY NOT NULL,
	UnitsInStock INT NOT NULL,
    CONSTRAINT PK_Product PRIMARY KEY (ProductId)
)
GO


INSERT INTO Product (Category, ProductName, Weight, UnitPrice, UnitsInStock)
values
(1, 'Laptop TUF ASUS', '5 KG', 30000, 100),
(2, 'Laptop Rogue ASUS', '6 KG', 25000, 200),
(3, 'Laptop eBook ASUS', '2 KG', 40000, 300),
(4, 'Laptop MSI', '3 KG', 20000, 400),
(5, 'Laptop Alien', '4 KG', 50000, 500),
(1, 'Laptop Acer', '5 KG', 50000, 100),
(2, 'Laptop Levono', '4 KG', 40000, 200),
(3, 'Laptop Hyper', '3 KG', 30000, 300),
(4, 'Laptop HP', '4 KG', 20000, 400),
(5, 'Laptop Dell', '3 KG', 50000, 500)
GO

/*ORDER DETAIL*/
CREATE TABLE OrderDetail (
    OrderId INT,
	ProductId INT NOT NULL, 
	UnitPrice money NOT NULL,
	Quantity int NOT NULL,
	Discount float NOT NULL,
	CONSTRAINT FK_OrderId FOREIGN KEY (OrderId) REFERENCES UserOrder(OrderId),
	CONSTRAINT FK_ProductId FOREIGN KEY (ProductId) REFERENCES Product(ProductId),
    CONSTRAINT PK_OrderDetail PRIMARY KEY NONCLUSTERED (OrderId, ProductId)
)
GO

/*
INSERT INTO OrderDetail (OrderId, ProductId, UnitPrice, Quantity, Discount)
values
(1, 1, 30000, 1, 30),
(2, 2, 50000, 4, 50),
(3, 3, 40000, 8, 20),
(4, 4, 60000, 7, 10),
(5, 5, 20000, 9, 0),
(6, 6, 40000, 2, 5),
(7, 7, 60000, 2, 40),
(8, 8, 80000, 0, 10),
(9, 9, 90000, 4, 0),
(10, 10, 10000, 10, 20)
GO
*/