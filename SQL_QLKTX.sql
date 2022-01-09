CREATE DATABASE QLKTX
USE QLKTX
SET DATEFORMAT dmy;
CREATE TABLE TOANHA
(
	MATOA VARCHAR(10) NOT NULL PRIMARY KEY,
	TENTOA VARCHAR(20) 
)

INSER

CREATE TABLE PHONGSV
(
	MAPHONG VARCHAR(10) NOT NULL PRIMARY KEY,
	TENPHONG NVARCHAR(50),
	LOAIPHONG NVARCHAR(30),
	SOLUONG INT,
	GIAPHONG FLOAT,
	TRANGTHAI NVARCHAR(30),
	MATOA VARCHAR(10),
	FOREIGN KEY(MATOA) REFERENCES TOANHA(MATOA)
)

CREATE TABLE TRUONGHOC
(
	MATRUONG VARCHAR(20) NOT NULL PRIMARY KEY,
	TENTRUONG NVARCHAR(30)
)

CREATE TABLE SINHVIEN
(
	CCCD VARCHAR(13) NOT NULL PRIMARY KEY,
	MSSV VARCHAR(11),
	HOTEN NVARCHAR(30),
	NAMSINH DATETIME,
	GIOITINH NVARCHAR(10),
	SDT	VARCHAR(10),
	EMAIL VARCHAR(30),
	DIACHI NVARCHAR(50),
	NGAYVAOKTX DATETIME,
	NGAYRAKTX DATETIME,
	TRANGTHAI NVARCHAR(20),
	MAPHONG VARCHAR(10),
	MATRUONG VARCHAR(20),
	FOREIGN KEY (MAPHONG) REFERENCES PHONGSV(MAPHONG),
	FOREIGN KEY (MATRUONG) REFERENCES TRUONGHOC(MATRUONG)
)

CREATE TABLE NGUOITHANSV
(
	MANT INT IDENTITY PRIMARY KEY,
	TENNGUOITHAN NVARCHAR(30),
	QUANHEVOISV NVARCHAR(10),
	SDT VARCHAR(10),
	DIACHI NVARCHAR(50),
	CCCD VARCHAR(13),
	FOREIGN KEY(CCCD) REFERENCES SINHVIEN(CCCD)
)

CREATE TABLE NOIQUYKTX
(
	MANOIQUY VARCHAR(10) NOT NULL PRIMARY KEY,
	TENNOIQUY NVARCHAR(50) NOT NULL,
	NOIDUNG NVARCHAR(50),
	HINHTHUCPHAT NVARCHAR(50)
)

CREATE TABLE NHANVIEN
(
	MANV VARCHAR(20) PRIMARY KEY,
	HOTENNV NVARCHAR(50),
	NGAYSINH DATETIME,
	GIOITINH NVARCHAR(10),
	SDT VARCHAR(10),
	DIACHI NVARCHAR(50),
	CHUCVU NVARCHAR(50),
	LUONG FLOAT,
	TRANGTHAI NVARCHAR(20)
)

CREATE TABLE KYLUAT
(
	MAKYLUAT VARCHAR(20) NOT NULL PRIMARY KEY,
	CCCD VARCHAR(13),
	MANV VARCHAR(20),
	NGAYKYLUAT DATETIME  NOT NULL,
	FOREIGN KEY (CCCD) REFERENCES SINHVIEN(CCCD),
	FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
)

CREATE TABLE CTKYLUAT
(
	ID INT IDENTITY PRIMARY KEY,
	MAKYLUAT VARCHAR(20),
	MANOIQUY VARCHAR(10),
	/*PRIMARY KEY(MAKYLUAT),*/
	FOREIGN KEY(MANOIQUY) REFERENCES NOIQUYKTX(MANOIQUY),
	FOREIGN KEY(MAKYLUAT) REFERENCES KYLUAT(MAKYLUAT)
)

CREATE TABLE BANGGIADIENNUOC
(
	MABANGGIA VARCHAR(10) NOT NULL PRIMARY KEY,
	TENDICHVU NVARCHAR(10),
	GIATHANH FLOAT
)

CREATE TABLE HOADONDIENNUOC
(
	MAHDDIENNUOC INT IDENTITY PRIMARY KEY,
	/*MAHDDIENNUOC VARCHAR(10) NOT NULL PRIMARY KEY,*/
	NGAYLAP DATETIME,	
	MAPHONG VARCHAR(10),
	TONGTIEN FLOAT,
	FOREIGN KEY(MAPHONG) REFERENCES PHONGSV(MAPHONG),
	MANV VARCHAR(20),
	FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV),
	TRANGTHAI NVARCHAR(20)
)

SELECT * FROM BANGGIADIENNUOC

CREATE TABLE CTHOADONDIENNUOC
(
	ID INT IDENTITY PRIMARY KEY,
	CHISOSUDUNG FLOAT,
	MABANGGIA VARCHAR(10),
	FOREIGN KEY (MABANGGIA) REFERENCES BANGGIADIENNUOC(MABANGGIA),
	MAHDDIENNUOC INT,
	FOREIGN KEY (MAHDDIENNUOC) REFERENCES HOADONDIENNUOC(MAHDDIENNUOC),
	/*PRIMARY KEY(MAHDDIENNUOC)*/
)

CREATE TABLE HOADONLEPHI
(
	MAHDLEPHI INT IDENTITY PRIMARY KEY,
	HANCUOI DATETIME,
	NGAYLAP DATETIME,
	TONGTIEN FLOAT,
	TRANGTHAI NVARCHAR,
	MANV VARCHAR(20),
	FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV),
	CCCD VARCHAR(13),
	FOREIGN KEY(CCCD) REFERENCES SINHVIEN(CCCD)
)

CREATE TABLE CTHOADONLEPHI
(
	ID INT IDENTITY PRIMARY KEY,
	SOTHANG INT,
	MAHDLEPHI INT,
	FOREIGN KEY(MAHDLEPHI) REFERENCES HOADONLEPHI(MAHDLEPHI),
	MAPHONG VARCHAR(10),
	FOREIGN KEY(MAPHONG) REFERENCES PHONGSV(MAPHONG)
)

CREATE TABLE ACCOUNT
(
    [USER] VARCHAR(32) NOT NULL,
    [PASS] VARCHAR(32) NOT NULL,
    QUYEN NVARCHAR(10) NOT NULL,
	MANV VARCHAR(20),
	CCCD VARCHAR(13),
    PRIMARY KEY([USER]),
	FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV),
	FOREIGN KEY (CCCD) REFERENCES SINHVIEN(CCCD)
)