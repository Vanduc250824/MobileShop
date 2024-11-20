-- Tạo cơ sở dữ liệu MobileShop
CREATE DATABASE MobileShop;
GO

-- Sử dụng cơ sở dữ liệu MobileShop
USE MobileShop;
GO

-- Bảng Sản phẩm
CREATE TABLE Sanpham (
    sanphamid INT IDENTITY(1,1) PRIMARY KEY,
    tenSP NVARCHAR(100) NOT NULL,
    gia DECIMAL(10, 2) NOT NULL,
    hangSX NVARCHAR(50) NOT NULL
);
GO

-- Bảng Khách hàng
CREATE TABLE Khachhang (
    khachhangid INT IDENTITY(1,1) PRIMARY KEY,
    ten NVARCHAR(100) NOT NULL,
    diachi NVARCHAR(MAX) NOT NULL,
    sdt NVARCHAR(15) NOT NULL
);
GO

-- Bảng Đơn hàng
CREATE TABLE Donhang (
    id INT IDENTITY(1,1) PRIMARY KEY,
    khachhangid INT NOT NULL,
    sanphamid INT NOT NULL,
    soluong INT NOT NULL,
    ngaymua DATE NOT NULL,
    FOREIGN KEY (khachhangid) REFERENCES Khachhang(khachhangid),
    FOREIGN KEY (sanphamid) REFERENCES Sanpham(sanphamid)
);
GO

-- Bảng Người dùng
CREATE TABLE Nguoidung (
    id INT IDENTITY(1,1) PRIMARY KEY,
    tendangnhap NVARCHAR(50) NOT NULL UNIQUE,
    matkhau NVARCHAR(255) NOT NULL
);
GO
INSERT INTO Sanpham (tenSP, gia, hangSX)
VALUES 
('iPhone 15', 29999.99, 'Apple'),
('Galaxy S23', 24999.99, 'Samsung'),
('Xiaomi Mi 13', 15999.99, 'Xiaomi'),
('Oppo Reno 8', 12999.99, 'Oppo');
go
INSERT INTO Khachhang (ten, diachi, sdt)
VALUES 
('Nguyen Van A', '123 Le Loi, HCM', '0987654321'),
('Tran Thi B', '456 Tran Hung Dao, HCM', '0978123456'),
('Le Van C', '789 Nguyen Hue, HN', '0909123456'),
('Pham Thi D', '101 Le Lai, DN', '0912345678');
go
-- Giả định khachhangid và sanphamid đã tồn tại
INSERT INTO Donhang (khachhangid, sanphamid, soluong, ngaymua)
VALUES 
(1, 1, 2, '2024-11-20'),
(2, 2, 1, '2024-11-19'),
(3, 3, 3, '2024-11-18'),
(4, 4, 1, '2024-11-17');
go
INSERT INTO Nguoidung (tendangnhap, matkhau)
VALUES 
('admin', 'hashed_password_123'),
('user1', 'hashed_password_456'),
('user2', 'hashed_password_789'),
('user3', 'hashed_password_000');
SELECT COUNT(*) FROM Nguoidung WHERE tendangnhap = 'admin' AND matkhau = 'hashed_password_123';
SElect * FROM Sanpham