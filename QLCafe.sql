-- Create the QLCafe database
CREATE DATABASE QLCafe;
GO

-- Use the QLCafe database
USE QLCafe;
GO
drop table HoaDonChiTiet,HoaDon,MonAn,LoaiMonAn,TaiKhoan
-- Create TaiKhoan table
CREATE TABLE TaiKhoan(
    tendangnhap NVARCHAR(30) PRIMARY KEY,
    matkhau NVARCHAR(30)
);
GO

-- Create LoaiMonAn table
CREATE TABLE LoaiMonAn(
    MaLoai NVARCHAR(100) PRIMARY KEY,
    TenLoai NVARCHAR(100)
);
GO

-- Create MonAn table
CREATE TABLE MonAn(
    MaMonAn NVARCHAR(100) PRIMARY KEY,
    MaLoai NVARCHAR(100) FOREIGN KEY REFERENCES LoaiMonAn(MaLoai),
    TenMonAn NVARCHAR(100),
    DonGia MONEY
);
GO

-- Create HoaDon table
CREATE TABLE HoaDon(
    MaHoaDon INT PRIMARY KEY,
	TrangThai NVARCHAR(20),
	datecheckin DATETIME,
	datecheckout DATETIME
);
GO

CREATE TABLE HoaDonChiTiet(
	MaHoaDon INT FOREIGN KEY REFERENCES HoaDon(MaHoaDon),
	SoBan NVARCHAR(10),
    MaMonAn NVARCHAR(100) FOREIGN KEY REFERENCES MonAn(MaMonAn),
    SoLuong INT,
	ThanhTien money,
    TongTien MONEY
);

-- Insert values into LoaiMonAn table
INSERT INTO LoaiMonAn VALUES
('LMA02', N'Món ăn'),
('LMA01', N'Nước uống');
GO

-- Insert values into MonAn table
INSERT INTO MonAn VALUES
('MA05', 'LMA01', N'Trà chanh', 17000),
('MA01', 'LMA01', N'Trà đào', 10000),
('MA02', 'LMA01', N'Cafe', 20000),
('MA03', 'LMA02', N'Cua hoàng đế', 300000),
('MA04', 'LMA02', N'Cá hồi nướng', 350000);
GO

-- Select all from MonAn table
SELECT * FROM MonAn;
SELECT * FROM LoaiMonAn;
SELECT * FROM HoaDon;
SELECT * FROM HoaDonChiTiet;

delete HoaDonChiTiet
delete HoaDon

select hd.MaHoaDon, hd.datecheckin, hd.datecheckout, hdct.SoBan, ma.TenMonAn, hdct.SoLuong, hdct.ThanhTien, hdct.TongTien from HoaDon hd, HoaDonChiTiet hdct, MonAn ma  where hd.MaHoaDon = hdct.MaHoaDon and hdct.MaMonAn = ma.MaMonAn;