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
	NhanVienID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	TenNhanVien nvarchar(50),
	Email nvarchar(50) NOT NULL,
	Pass nvarchar(32) NOT NULL,
	Avatar nvarchar(100),
	TrangThai int
)
GO
-- CREATE TABLE KhachHang
CREATE TABLE KhachHang(
	KhachHangID int NOT NULL PRIMARY KEY IDENTITY(1,1),
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
	DanhMucID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	TenDanhMuc nvarchar(50),
	TrangThai int
)
GO
-- CREATE TABLE SanPham
CREATE TABLE SanPham(
	SanPhamID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	TenSanPham nvarchar(50),
	DonGia float,
	DonViTinh nvarchar(10),
	Anh nvarchar(100),
	MoTa nvarchar(MAX),
	NgayCapNhat smalldatetime,
	DanhMucID int,
	SoLuongBan int,
	TrangThai int
)
GO
-- CREATE TABLE HoaDonBan
CREATE TABLE HoaDon(
	HoaDonID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	KhachHangID int,
	NgayDatHang smalldatetime,
	NgayGiaoHang smalldatetime,
	NguoiNhan nvarchar(50),
	DiaChiNhan nvarchar(100),
	DienThoai nvarchar(20),
	TongTien float,
	TrangThai int NOT NULL
)
GO
-- CREATE TABLE ChiTietHoaDonBan
CREATE TABLE ChiTietHD(
	HoaDonID int ,
	SanPhamID int,
	DonGia float,
	SoLuong int,
	ThanhTien float,
	PRIMARY KEY(HoaDonID, SanPhamID)
)