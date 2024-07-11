CREATE DATABASE Demo_Test_ASP_01
GO

USE Demo_Test_ASP_01
GO

CREATE TABLE Category (
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(150) NOT NULL UNIQUE
)
GO

CREATE TABLE Product(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(150) NOT NULL UNIQUE,
	Price FLOAT NOT NULL,
	SalePrice FLOAT DEFAULT 0,
	Description NVARCHAR(200),
	CategoryID INT FOREIGN KEY REFERENCES Category(Id)
)
GO

INSERT INTO Category([Name]) VALUES 
('Category O1'),
('Category O2'),
('Category O3'),
('Category O4'),
('Category O5')
GO

INSERT INTO Product([Name], [Price], [SalePrice], [Description], [CategoryID]) VALUES 
('Prod 01', 11000, 0, 'Des 1', 1),
('Prod 02', 12000, 0, 'Des 2', 1),
('Prod 03', 13000, 0, 'Des 3', 1),
('Prod 04', 14000, 0, 'Des 4', 1),
('Prod 05', 15000, 0, 'Des 5', 1),
('Prod 06', 16000, 0, 'Des 6', 1),
('Prod 07', 17000, 0, 'Des 7', 1),
('Prod 08', 18000, 0, 'Des 8', 1),
('Prod 09', 19000, 0, 'Des 9', 1),
('Prod 10', 20000, 0, 'Des 10', 1)
GO