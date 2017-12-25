--CREATE DATABASE BHTrangSuc
USE master
GO
IF EXISTS(SELECT name FROM sys.databases WHERE name='BHTrangSuc') DROP DATABASE BHTrangSuc
GO
CREATE DATABASE BHTrangSuc COLLATE Vietnamese_CI_AS
----------------------------------------------------------------------------------------------------
GO
USE BHTrangSuc
GO
-- CREATE TABLE NhanVien
CREATE TABLE NhanVien(
	NhanVienID nvarchar(5) NOT NULL PRIMARY KEY,
	TenNhanVien nvarchar(50),
	DiaChi nvarchar(100),
	Email nvarchar(50) NOT NULL,
	Pass nvarchar(32) NOT NULL,
	DienThoai nvarchar(15),
	TrangThai int
)
GO
-- CREATE TABLE KhachHang
CREATE TABLE KhachHang(
	KhachHangID nvarchar(5) NOT NULL PRIMARY KEY,
	TenKhachHang nvarchar(50),
	DiaChi nvarchar(100),
	Email nvarchar(50),
	Pass nvarchar(32),
	DienThoai nvarchar(15),
	GhiChu nvarchar(1000)
)
GO
-- CREATE TABLE DanhMucSanPham
CREATE TABLE DanhMuc(
	DanhMucID nvarchar(5) NOT NULL PRIMARY KEY,
	TenDanhMuc nvarchar(50),
	TrangThai int
)
GO
-- CREATE TABLE SanPham
CREATE TABLE SanPham(
	SanPhamID nvarchar(5) NOT NULL PRIMARY KEY,
	TenSanPham nvarchar(50),
	DanhMucID nvarchar(5) FOREIGN KEY REFERENCES DanhMuc(DanhMucID),
	DonGia float,
	DonViTinh nvarchar(10),
	SoLuong int,
	Anh nvarchar(100),
	GhiChu nvarchar(1000),
	TrangThai int
)
GO
-- CREATE TABLE HoaDonBan
CREATE TABLE HoaDonBan(
	HoaDonBanID nvarchar(5) NOT NULL PRIMARY KEY,
	NhanVienID nvarchar(5) FOREIGN KEY REFERENCES NhanVien(NhanVienID),
	KhachHangID nvarchar(5) FOREIGN KEY REFERENCES KhachHang(KhachHangID),
	TongTien float,
	NgayBan datetime,
	TrangThai int NOT NULL
)
GO
-- CREATE TABLE ChiTietHoaDonBan
CREATE TABLE ChiTietHDBan(
	HoaDonBanID nvarchar(5) NOT NULL PRIMARY KEY FOREIGN KEY REFERENCES HoaDonBan(HoaDonBanID),
	SanPhamID nvarchar(5) FOREIGN KEY REFERENCES SanPham(SanPhamID),
	DonGia float,
	SoLuong int,
	GiamGia float,
	ThanhTien float
)