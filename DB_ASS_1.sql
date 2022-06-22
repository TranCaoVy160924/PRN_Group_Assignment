CREATE DATABASE ASS1_DB;
go
USE ASS1_DB;
go

CREATE TABLE FStore (
    MemberID INT,
	MemberName VARCHAR(50) NOT NULL,
	Email VARCHAR(100) NOT NULL, 
	Password VARCHAR(30) NOT NULL,
	City VARCHAR(15) NOT NULL,
	Country VARCHAR(15) NOT NULL,
	CONSTRAINT UC_Email UNIQUE (Email),
    CONSTRAINT PK PRIMARY KEY (MemberID)
)
go

INSERT INTO FStore values
(1, 'Dao Khac Nhien', 'dknhien@gmail.com', '12345678', 'HCM', 'Viet Nam'),
(2, 'Tran Cao Vy', 'tcvy@gmail.com', '12345678', 'HCM', 'Viet Nam'),
(3, 'Luong Minh Nhat', 'lmnhat@gmail.com', '12345678', 'HCM', 'Viet Nam'),
(4, 'To Ly Huu Nhan', 'tlhnhan@gmail.com', '12345678', 'HCM', 'Viet Nam'),
(5, 'Dao Dang Tung', 'ddtung@gmail.com', '12345678', 'HCM', 'Viet Nam'),
(6, 'Tran Van Dat', 'tvdat@gmail.com', '12345678', 'HCM', 'Viet Nam'),
(7, 'Le Ngoc Quang', 'lnquang@gmail.com', '12345678', 'HCM', 'Viet Nam')
go