CREATE DATABASE ASS1_DB;
go
USE ASS1_DB;
go

CREATE TABLE FStore (
    MemberID INT IDENTITY(1,1),
	MemberName VARCHAR(50) NOT NULL,
	Email VARCHAR(100) NOT NULL, 
	Password VARCHAR(30) NOT NULL,
	City VARCHAR(15) NOT NULL,
	Country VARCHAR(15) NOT NULL,
	CONSTRAINT UC_Email UNIQUE (Email),
    CONSTRAINT PK PRIMARY KEY (MemberID)
)
go

INSERT INTO FStore (MemberName, Email, Password, City, Country)
values
('Dao Khac Nhien', 'dknhien@gmail.com', '12345678', 'HCM', 'Viet Nam'),
('Tran Cao Vy', 'tcvy@gmail.com', '12345678', 'HCM', 'Viet Nam'),
('Luong Minh Nhat', 'lmnhat@gmail.com', '12345678', 'HCM', 'Viet Nam'),
('To Ly Huu Nhan', 'tlhnhan@gmail.com', '12345678', 'HCM', 'Viet Nam'),
('Dao Dang Tung', 'ddtung@gmail.com', '12345678', 'HCM', 'Viet Nam'),
('Tran Van Dat', 'tvdat@gmail.com', '12345678', 'HCM', 'Viet Nam'),
('Le Ngoc Quang', 'lnquang@gmail.com', '12345678', 'HCM', 'Viet Nam')
go