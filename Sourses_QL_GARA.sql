CREATE DATABASE QL_GARA
GO
USE QL_GARA
GO
CREATE TABLE KHACHHANG
(
MAKH CHAR(10) PRIMARY KEY,
HOTEN NVARCHAR(20),
DIACHI NVARCHAR(20),
SODT CHAR(10),
)
GO
CREATE TABLE DOANHTHU
(
MADT CHAR(10) PRIMARY KEY,
DOANHTHU MONEY,
NGAYLAP DATETIME
)
GO
CREATE TABLE NHANVIEN
(
MANV CHAR(10) PRIMARY KEY,
HOTEN NVARCHAR(20),
GIOITINH INT,
CMND CHAR(10),
DIACHI NVARCHAR(20)
)
GO
CREATE TABLE PHUTUNG
(
MAPT CHAR(10) PRIMARY KEY,
TENPT NCHAR(20),
DONGIA MONEY,
SOLUONG INT
)
GO
CREATE TABLE PHIEUBAOHANH 
(
MABH CHAR(10) PRIMARY KEY ,
BIENSO CHAR(15),
THOIHAN DATETIME
)
GO
CREATE TABLE PHIEUTHUTIEN
(
MATT CHAR(10) PRIMARY KEY,
MAKH CHAR(10) FOREIGN KEY REFERENCES dbo.KHACHHANG(MAKH),
MADT CHAR(10) FOREIGN KEY REFERENCES dbo.DOANHTHU(MADT),
NGAYTHU DATETIME,
TIENTHU MONEY
)
GO
CREATE TABLE BAOHANH_PHIEUTHU
(
MABH CHAR(10) FOREIGN KEY REFERENCES dbo.PHIEUBAOHANH(MABH),
MATT CHAR(10) FOREIGN KEY REFERENCES dbo.PHIEUTHUTIEN(MATT),
NGAYBH DATETIME,
PRIMARY KEY(MABH,MATT)
)
GO
CREATE TABLE PHIEUSUACHUA
(
MASC CHAR(10) PRIMARY KEY,
MATT CHAR(10) FOREIGN KEY REFERENCES dbo.PHIEUTHUTIEN(MATT),
BIENSO CHAR(10),
CHUXE NVARCHAR(20),
NGAYSUA DATETIME,
THANHTIEN MONEY
)
GO
CREATE TABLE SUDUNGPHUTUNG
(
MASC CHAR(10) FOREIGN KEY REFERENCES dbo.PHIEUSUACHUA(MASC),
MAPT CHAR(10) FOREIGN KEY REFERENCES dbo.PHUTUNG(MAPT),
SOLUONG INT,
PRIMARY KEY(MASC,MAPT)
)
GO
CREATE TABLE NHANVIENSUACHUA
(
MASC CHAR(10) FOREIGN KEY REFERENCES dbo.PHIEUSUACHUA(MASC),
MANV CHAR(10) FOREIGN KEY REFERENCES dbo.NHANVIEN(MANV),
TIENCONG MONEY,
PRIMARY KEY(MASC,MANV)
)
-------------------------------
--nhập DATA
INSERT INTO dbo.KHACHHANG
        ( MAKH, HOTEN, DIACHI, SODT )
VALUES  ( 'KH01', -- MAKH - char(10)
          N'NGUYỄN A', -- HOTEN - nvarchar(20)
          N'TPHCM', -- DIACHI - nvarchar(20)
          '0987647474'  -- SODT - char(10)
          )
INSERT INTO dbo.KHACHHANG
        ( MAKH, HOTEN, DIACHI, SODT )
VALUES  ( 'KH02', -- MAKH - char(10)
          N'NGUYỄN B', -- HOTEN - nvarchar(20)
          N'HA NOI', -- DIACHI - nvarchar(20)
          '0984456209'  -- SODT - char(10)
          )
INSERT INTO dbo.KHACHHANG
        ( MAKH, HOTEN, DIACHI, SODT )
VALUES  ( 'KH03', -- MAKH - char(10)
          N'NGUYỄN C', -- HOTEN - nvarchar(20)
          N'DONG NAI', -- DIACHI - nvarchar(20)
          '0987568902'  -- SODT - char(10)
          )
----
INSERT INTO dbo.DOANHTHU
        ( MADT, DOANHTHU, NGAYLAP )
VALUES  ( 'DT01', -- MADT - char(10)
          NULL, -- DOANHTHU - money
          GETDATE()  -- NGAYLAP - datetime
          )
INSERT INTO dbo.DOANHTHU
        ( MADT, DOANHTHU, NGAYLAP )
VALUES  ( 'DT02', -- MADT - char(10)
          NULL, -- DOANHTHU - money
          GETDATE()  -- NGAYLAP - datetime
          )
INSERT INTO dbo.DOANHTHU
        ( MADT, DOANHTHU, NGAYLAP )
VALUES  ( 'DT03', -- MADT - char(10)
          NULL, -- DOANHTHU - money
          GETDATE()  -- NGAYLAP - datetime
        )
------------------
INSERT INTO dbo.NHANVIEN
        ( MANV, HOTEN, GIOITINH, CMND, DIACHI )
VALUES  ( 'NV01', -- MANV - char(10)
          N'VĂN A', -- HOTEN - nvarchar(20)
          1, -- GIOITINH - int
          '2364223', -- CMND - char(10)
          N'HA TINH'  -- DIACHI - nvarchar(20)
          )
INSERT INTO dbo.NHANVIEN
        ( MANV, HOTEN, GIOITINH, CMND, DIACHI )
VALUES  ( 'NV02', -- MANV - char(10)
          N'VĂN B', -- HOTEN - nvarchar(20)
          0, -- GIOITINH - int
          '2347822', -- CMND - char(10)
          N'HA NAM'  -- DIACHI - nvarchar(20)
          )
INSERT INTO dbo.NHANVIEN
        ( MANV, HOTEN, GIOITINH, CMND, DIACHI )
VALUES  ( 'NV03', -- MANV - char(10)
          N'VĂN C', -- HOTEN - nvarchar(20)
          1, -- GIOITINH - int
          '1243998', -- CMND - char(10)
          N'PHU QUOC'  -- DIACHI - nvarchar(20)
          )
-------------------
INSERT INTO dbo.PHUTUNG
        ( MAPT, TENPT, DONGIA, SOLUONG )
VALUES  ( 'PT01', -- MAPT - char(10)
          N'BÁNH XE', -- TENPT - nchar(20)
          1000000, -- DONGIA - money
          4 -- SOLUONG - int
          )
INSERT INTO dbo.PHUTUNG
        ( MAPT, TENPT, DONGIA, SOLUONG )
VALUES  ( 'PT02', -- MAPT - char(10)
          N'BUGI', -- TENPT - nchar(20)
          2000000, -- DONGIA - money
          2 -- SOLUONG - int
          )
INSERT INTO dbo.PHUTUNG
        ( MAPT, TENPT, DONGIA, SOLUONG )
VALUES  ( 'PT03', -- MAPT - char(10)
          N'LỌC NHỚT', -- TENPT - nchar(20)
          4000000, -- DONGIA - money
          1 -- SOLUONG - int
          )
--------------------
INSERT INTO dbo.PHIEUBAOHANH
        ( MABH, BIENSO, THOIHAN )
VALUES  ( 'BH01', -- MABH - char(10)
          'SDF8S7', -- BIENSO - char(15)
          GETDATE()  -- THOIHAN - datetime
          )
INSERT INTO dbo.PHIEUBAOHANH
        ( MABH, BIENSO, THOIHAN )
VALUES  ( 'BH02', -- MABH - char(10)
          'TER234', -- BIENSO - char(15)
          GETDATE()  -- THOIHAN - datetime
          )
INSERT INTO dbo.PHIEUBAOHANH
        ( MABH, BIENSO, THOIHAN )
VALUES  ( 'BH03', -- MABH - char(10)
          'WERWE232', -- BIENSO - char(15)
          GETDATE()  -- THOIHAN - datetime
          )
----
INSERT INTO dbo.PHIEUTHUTIEN
        ( MATT, MAKH, MADT, NGAYTHU, TIENTHU )
VALUES  ( 'TT01', -- MATT - char(10)
          'KH03', -- MAKH - char(10)
          'DT01', -- MADT - char(10)
          GETDATE(), -- NGAYTHU - datetime
          NULL  -- TIENTHU - money
          )
INSERT INTO dbo.PHIEUTHUTIEN
        ( MATT, MAKH, MADT, NGAYTHU, TIENTHU )
VALUES  ( 'TT02', -- MATT - char(10)
          'KH02', -- MAKH - char(10)
          'DT02', -- MADT - char(10)
          GETDATE(), -- NGAYTHU - datetime
          NULL  -- TIENTHU - money
          )
INSERT INTO dbo.PHIEUTHUTIEN
        ( MATT, MAKH, MADT, NGAYTHU, TIENTHU )
VALUES  ( 'TT03', -- MATT - char(10)
          'KH01', -- MAKH - char(10)
          'DT03', -- MADT - char(10)
          GETDATE(), -- NGAYTHU - datetime
          NULL  -- TIENTHU - money
          )
---
INSERT INTO dbo.BAOHANH_PHIEUTHU
        ( MABH, MATT, NGAYBH )
VALUES  ( 'BH01', -- MABH - char(10)
          'TT03', -- MATT - char(10)
          GETDATE()  -- NGAYBH - datetime
          )
INSERT INTO dbo.BAOHANH_PHIEUTHU
        ( MABH, MATT, NGAYBH )
VALUES  ( 'BH02', -- MABH - char(10)
          'TT02', -- MATT - char(10)
          GETDATE()  -- NGAYBH - datetime
          )
INSERT INTO dbo.BAOHANH_PHIEUTHU
        ( MABH, MATT, NGAYBH )
VALUES  ( 'BH03', -- MABH - char(10)
          'TT01', -- MATT - char(10)
          GETDATE()  -- NGAYBH - datetime
          )
---------------
INSERT INTO dbo.PHIEUSUACHUA
        ( MASC ,
          MATT ,
          BIENSO ,
          CHUXE ,
          NGAYSUA ,
          THANHTIEN
        )
VALUES  ( 'SC01' , -- MASC - char(10)
          'TT03' , -- MATT - char(10)
          '' , -- BIENSO - char(10)
          N'' , -- CHUXE - nvarchar(20)
          GETDATE() , -- NGAYSUA - datetime
          NULL  -- THANHTIEN - money
        )
INSERT INTO dbo.PHIEUSUACHUA
        ( MASC ,
          MATT ,
          BIENSO ,
          CHUXE ,
          NGAYSUA ,
          THANHTIEN
        )
VALUES  ( 'SC02' , -- MASC - char(10)
          'TT02' , -- MATT - char(10)
          '' , -- BIENSO - char(10)
          N'' , -- CHUXE - nvarchar(20)
          GETDATE() , -- NGAYSUA - datetime
          NULL  -- THANHTIEN - money
        )
INSERT INTO dbo.PHIEUSUACHUA
        ( MASC ,
          MATT ,
          BIENSO ,
          CHUXE ,
          NGAYSUA ,
          THANHTIEN
        )
VALUES  ( 'SC03' , -- MASC - char(10)
          'TT01' , -- MATT - char(10)
          '' , -- BIENSO - char(10)
          N'' , -- CHUXE - nvarchar(20)
          GETDATE() , -- NGAYSUA - datetime
          NULL  -- THANHTIEN - money
        )
--------------------------
INSERT INTO dbo.SUDUNGPHUTUNG
        ( MASC, MAPT, SOLUONG )
VALUES  ( 'SC01', -- MASC - char(10)
          'PT01', -- MAPT - char(10)
          3  -- SOLUONG - int
          )
INSERT INTO dbo.SUDUNGPHUTUNG
        ( MASC, MAPT, SOLUONG )
VALUES  ( 'SC02', -- MASC - char(10)
          'PT02', -- MAPT - char(10)
          1  -- SOLUONG - int
          )
INSERT INTO dbo.SUDUNGPHUTUNG
        ( MASC, MAPT, SOLUONG )
VALUES  ( 'SC03', -- MASC - char(10)
          'PT03', -- MAPT - char(10)
          0  -- SOLUONG - int
          )
--------
INSERT INTO dbo.NHANVIENSUACHUA
        ( MASC, MANV, TIENCONG )
VALUES  ( 'SC01', -- MASC - char(10)
          'NV03', -- MANV - char(10)
          NULL  -- TIENCONG - money
          )
INSERT INTO dbo.NHANVIENSUACHUA
        ( MASC, MANV, TIENCONG )
VALUES  ( 'SC02', -- MASC - char(10)
          'NV02', -- MANV - char(10)
          NULL  -- TIENCONG - money
          )
INSERT INTO dbo.NHANVIENSUACHUA
        ( MASC, MANV, TIENCONG )
VALUES  ( 'SC03', -- MASC - char(10)
          'NV01', -- MANV - char(10)
          NULL  -- TIENCONG - money
          )