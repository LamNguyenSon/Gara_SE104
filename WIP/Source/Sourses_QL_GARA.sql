﻿CREATE DATABASE QL_GARA
GO
USE QL_GARA
GO
CREATE TABLE TAIKHOAN
(
MATK NVARCHAR(10) PRIMARY KEY,

TENDN CHAR(20),
MATKHAU CHAR(20),
NGAYTAO DATETIME DEFAULT GETDATE() ,
)
GO
CREATE TABLE NHANVIEN 
(
MANV NVARCHAR(10) PRIMARY KEY,
MATK NVARCHAR(10) REFERENCES TAIKHOAN(MATK),
HOTEN NVARCHAR(20),
GIOITINH CHAR(3),
NGAYSINH DATETIME,
SDT CHAR(12),
CMND CHAR(10),
DIACHI NVARCHAR(20)
)
GO
CREATE TABLE BAOCAOTHANG
(
MABCT NVARCHAR(10) PRIMARY KEY,
DOANHTHU MONEY DEFAULT 0 ,
NGAYLAP DATETIME
)
GO
CREATE TABLE KHACHHANG
(
MAKH NVARCHAR(10)PRIMARY KEY,
HOTEN NVARCHAR(20),
GIOITINH CHAR(3),
NGAYSINH DATETIME,
SDT CHAR(12),
CMND CHAR(10),
DIACHI NVARCHAR(20),
BIENSO CHAR(10),
LOAIXE CHAR(10)
)
GO
CREATE TABLE PHIEUTHUTIEN 
(
MAPTT NVARCHAR(10) PRIMARY KEY,
MABCT NVARCHAR(10) REFERENCES BAOCAOTHANG(MABCT),
MAKH NVARCHAR(10) REFERENCES KHACHHANG(MAKH),
NGAYTHU DATETIME,
TIENTHU MONEY DEFAULT 0 
)
GO
CREATE TABLE PHIEUSUACHUA
(
MAPSC NVARCHAR(10) PRIMARY KEY,
MANV NVARCHAR(10) REFERENCES NHANVIEN(MANV),
MAKH NVARCHAR(10) REFERENCES KHACHHANG(MAKH),
NGAYSUACHUA DATETIME DEFAULT GETDATE(),
THANHTIEN MONEY DEFAULT 0 
)
GO
CREATE TABLE PHUTUNG 
(
MAPT NVARCHAR(10)PRIMARY KEY,
MABCT NVARCHAR(10) REFERENCES BAOCAOTHANG(MABCT),
TENPT NVARCHAR(20),
DONGGIA MONEY DEFAULT 0,
SOLUONG INT
)
GO
CREATE TABLE THONGTINSUACHUA
(
MAPT NVARCHAR(10) REFERENCES PHUTUNG(MAPT),
MAPSC NVARCHAR(10)REFERENCES PHIEUSUACHUA(MAPSC),
LOAISUACHUA INT ,--1 SUA CHUA--2 THAY MỚI
MOTA NVARCHAR(20),
SLPT_SUDUNG INT DEFAULT 0 ,
CHIPHI MONEY DEFAULT 0,
PRIMARY KEY(MAPT,MAPSC)
)
GO
-----------TRIGGER
--------------------------------------------------------------------------------------------
--STRIGGER TỰ ĐỘNG TRỪ SỐ LƯỢNG PHỤ TÙNG KHI SỬ DỤNG
CREATE TRIGGER REDUCE_SL_PHUTUNG ON THONGTINSUACHUA
FOR INSERT,UPDATE
AS 
BEGIN
DECLARE @SLPT INT,@MAPT CHAR(12)

SELECT @SLPT=SOLUONG-Inserted.SLPT_SUDUNG,@MAPT=Inserted.MAPT FROM Inserted JOIN dbo.PHUTUNG ON PHUTUNG.MAPT = Inserted.MAPT
IF(@SLPT<0)
BEGIN

PRINT N'KHÔNG ĐỦ PHỤ TÙNG ĐỂ SỬ DỤNG'
ROLLBACK TRANSACTION
END
ELSE
BEGIN

UPDATE dbo.PHUTUNG
SET SOLUONG=@SLPT
WHERE MAPT=@MAPT

END
END
------------TRIGGER TỰ ĐỘNG TÍNH DOANH THU BÁO THÁNG
GO
CREATE TRIGGER TINHDOANHTHU ON PHIEUTHUTIEN
for INSERT,UPDATE,DELETE
AS 
BEGIN
DECLARE @TONGDOANHTHU INT=0, @MABCT CHAR(12)
------------danh thu bảng vừa nhập
SELECT @MABCT=dbo.BAOCAOTHANG.MABCT,@TONGDOANHTHU=SUM (TIENTHU) FROM Inserted JOIN dbo.BAOCAOTHANG ON BAOCAOTHANG.MABCT=Inserted.MABCT AND  YEAR(NGAYLAP)=YEAR(GETDATE()) AND MONTH(NGAYLAP)=MONTH(GETDATE())
GROUP BY dbo.BAOCAOTHANG.MABCT
----------------------------------------
----xảy ra trường hợp xóa
IF((SELECT COUNT(*) FROM Deleted) >=1)
BEGIN
SELECT @TONGDOANHTHU=Deleted.TIENTHU *-1,@MABCT=Deleted.MABCT FROM dbo.BAOCAOTHANG JOIN Deleted ON Deleted.MABCT = BAOCAOTHANG.MABCT
END
-----doanh thu bãng cũ +/- doanh thu vừa nhập/XÓA
UPDATE dbo.BAOCAOTHANG
SET DOANHTHU+=@TONGDOANHTHU
WHERE MABCT=@MABCT
END
---------GOM nhóm báo cáo tháng hiện tại
GO
SELECT dbo.BAOCAOTHANG.MABCT,SUM (TIENTHU) FROM dbo.PHIEUTHUTIEN JOIN dbo.BAOCAOTHANG ON BAOCAOTHANG.MABCT=dbo.PHIEUTHUTIEN.MABCT AND  YEAR(NGAYLAP)=YEAR(GETDATE()) AND MONTH(NGAYLAP)=MONTH(GETDATE())
GROUP BY dbo.BAOCAOTHANG.MABCT

-----------------
--Ràng buộc loại sửa chữa 1/2
GO
CREATE TRIGGER TRIGGER_LOAISUACHUA ON THONGTINSUACHUA
FOR INSERT ,UPDATE
AS 
BEGIN
DECLARE @LOAISC INT, @SLSD INT;
SELECT @LOAISC=Inserted.LOAISUACHUA,@SLSD=Inserted.SLPT_SUDUNG FROM Inserted
--LOẠI SỮA CHƯA KHÔNG NẰM TRONG 1 : SỮA CHỮA HOẶC 2 : THAY THẾ
IF(@LOAISC >2 OR @LOAISC <1 OR @SLSD<0)
BEGIN
ROLLBACK TRAN
PRINT N'LOẠI CHỮA CHỮA PHẢI LÀ 1 :SỮA CHỮA HOẶC 2 : THAY THẾ HOẶC SỐ LƯỢNG SỬ DỤNG PHỤ TÙNG ÂM'
END
---------------LOẠI LÀ SỬA CHỮA THÌ SỐ LƯỢNG SỬ DỤNG PHẢI BẰNG 0
IF(@LOAISC=1 AND @SLSD!=0)
BEGIN
ROLLBACK TRAN
PRINT N'LOẠI LÀ SỬA CHỮA THÌ SỐ LƯỢNG SỬ DỤNG PHẢI BẰNG 0'
END
IF (@LOAISC=2 AND @SLSD=0)
BEGIN
ROLLBACK TRAN
PRINT N'LOẠI LÀ THAY THẾ THÌ SỐ LƯỢNG SỬ DỤNG PHẢI KHÁC 0'

END
END
-----Ngày sinh của khách hàng phải nhỏ hơn ngày hiện tại
GO
CREATE TRIGGER BIRTHDAYKH ON KHACHHANG
FOR INSERT, UPDATE
AS 
BEGIN
DECLARE  @NGAYSINH DATETIME
SELECT  @NGAYSINH = Inserted.NGAYSINH FROM Inserted

IF((DATEDIFF(DAY,@NGAYSINH,GETDATE())) <0)
BEGIN
ROLLBACK TRANSACTION
PRINT N'NGÀY SINH CỦA KHÁCH HÀNG PHẢI NHỎ HƠN NGÀY HIỆN TẠI'

END

END
----------Ngày sinh của NHÂN VIÊN phải nhỏ hơn ngày hiện tại 
GO
CREATE TRIGGER BIRTHDAYNV ON dbo.NHANVIEN
FOR INSERT, UPDATE
AS 
BEGIN
DECLARE  @NGAYSINH DATETIME
SELECT  @NGAYSINH = Inserted.NGAYSINH FROM Inserted

IF((DATEDIFF(DAY,@NGAYSINH,GETDATE())) <0)
BEGIN
ROLLBACK TRANSACTION
PRINT N'NGÀY SINH CỦA NHÂN VIÊN PHẢI NHỎ HƠN NGÀY HIỆN TẠI'

END

END
---------------
GO
<<<<<<< HEAD
CREATE TRIGGER TINHTIENSUACHUA ON THONGTINSUACHUA
FOR INSERT
AS 
BEGIN
DECLARE @MAPSC CHAR(10),@CHIPHI MONEY
SELECT @MAPSC=Inserted.MAPSC,@CHIPHI= Inserted.CHIPHI FROM Inserted

UPDATE dbo.PHIEUSUACHUA
SET THANHTIEN=THANHTIEN+@CHIPHI
WHERE @MAPSC=MAPSC
END

GO
--TRIGGER
INSERT INTO TAIKHOAN VALUES('TK01','NV1','123456','07/05/2017')
INSERT INTO TAIKHOAN VALUES('TK02','NV2','123456','01/05/2013')
INSERT INTO TAIKHOAN VALUES('TK03','NV3','123456','04/01/2012')
INSERT INTO TAIKHOAN VALUES('TK04','NV4','123456','07/05/1998')
INSERT INTO TAIKHOAN VALUES('TK05','NV5','123456','07/02/1788')
--SELECT *FROM TAIKHOAN
-----------------------------
INSERT INTO NHANVIEN VALUES ('NV01','TK01','NGUYEN VAN A','NAM','08/08/1998','0989587761','272785421',N'TPHCM')
INSERT INTO NHANVIEN VALUES ('NV02','TK02','NGUYEN VAN B','NAM','08/08/1997','0989588765','272787654',N'HN')
INSERT INTO NHANVIEN VALUES ('NV03','TK03','NGUYEN VAN C','NAM','08/08/1995','0989580987','272789087',N'VUNGT TAU')
INSERT INTO NHANVIEN VALUES ('NV04','TK04','NGUYEN VAN D','NAM','08/08/1993','0989583542','272790765',N'NHA TRANG')
INSERT INTO NHANVIEN VALUES ('NV05','TK05','NGUYEN VAN E','NAM','08/08/1992','0989580000','272756890',N'TPHCM')

--SELECT *FROM NHANVIEN
INSERT INTO BAOCAOTHANG VALUES('BCT01',0,'08/03/1998')
INSERT INTO BAOCAOTHANG VALUES('BCT02',0,'08/03/1996')
INSERT INTO BAOCAOTHANG VALUES('BCT03',0,'08/03/2000')
INSERT INTO BAOCAOTHANG VALUES('BCT04',0,'08/03/2017')
INSERT INTO BAOCAOTHANG VALUES('BCT05',0,'08/03/2015')
--
INSERT INTO KHACHHANG VALUES('KH01','PHAM VAN A','NU','11/12/1991','0989581234','272709890','DONG NAI','kind1','bs01')
INSERT INTO KHACHHANG VALUES('KH02','PHAM VAN R','NU','11/12/1992','0989586534','272708909','HA NOI','kind2','bs02')
INSERT INTO KHACHHANG VALUES('KH03','PHAM VAN E','NU','11/12/1995','0989580999','272701111','TPHCM','kind3','bs03')
INSERT INTO KHACHHANG VALUES('KH04','PHAM VAN J','NU','11/12/1997','0989580666','272702345','DONG NAI','kind4','bs04')
INSERT INTO KHACHHANG VALUES('KH05','PHAM VAN L','NU','11/12/1999','0989585555','272700762','DONG THAP','kind5','bs05')
--
INSERT INTO PHIEUTHUTIEN VALUES('PTT01','BCT01','KH01',GETDATE(),3000000)
INSERT INTO PHIEUTHUTIEN VALUES('PTT02','BCT02','KH02',GETDATE(),2000000)
INSERT INTO PHIEUTHUTIEN VALUES('PTT03','BCT03','KH03','04/06/2000',500000)
INSERT INTO PHIEUTHUTIEN VALUES('PTT04','BCT04','KH04','04/06/2015',200000)
INSERT INTO PHIEUTHUTIEN VALUES('PTT05','BCT05','KH05','04/06/2011',7000000)

--SELECT *FROM PHIEUTHUTIEN
--
INSERT INTO PHIEUSUACHUA VALUES('PSC01','NV01','KH01',GETDATE(),0)
INSERT INTO PHIEUSUACHUA VALUES('PSC02','NV02','KH02',GETDATE(),0)
INSERT INTO PHIEUSUACHUA VALUES('PSC03','NV03','KH03','08/02/2002',0)
INSERT INTO PHIEUSUACHUA VALUES('PSC04','NV04','KH04','08/02/2003',0)
INSERT INTO PHIEUSUACHUA VALUES('PSC05','NV05','KH05','08/02/2006',0)
---
INSERT INTO PHUTUNG VALUES ('PT01','BCT01','BUGI',2000000,4)
INSERT INTO PHUTUNG VALUES ('PT02','BCT02','BANH XE',1000000,3)
INSERT INTO PHUTUNG VALUES ('PT03','BCT03','THUNGNHOT',200000,1)
INSERT INTO PHUTUNG VALUES ('PT04','BCT04','GHE',5000000,8)
INSERT INTO PHUTUNG VALUES ('PT05','BCT05','LAUKINH',3000000,7)
---
INSERT INTO THONGTINSUACHUA VALUES ('PT01','PSC01',1,'SỬA LỌC NHỚT',0,3000000)
INSERT INTO THONGTINSUACHUA VALUES ('PT02','PSC02',2,'THAY BÁNH TRƯỚC',2,2000000)
INSERT INTO THONGTINSUACHUA VALUES ('PT03','PSC03',2,'THAY BUGI',1,5000000)
INSERT INTO THONGTINSUACHUA VALUES ('PT04','PSC04',1,'SỬA VOLAN',0,2000000)
INSERT INTO THONGTINSUACHUA VALUES ('PT05','PSC05',1,'SỬA ĐỒ LAU KÍNH',0,7000000)
GO



--XÓA NHÂN VIÊN
CREATE PROCEDURE DELETE_NHANVIEN
@MANV VARCHAR(10)
AS
BEGIN
DECLARE @MAPSC VARCHAR(10)
--xóa theo thứ tự thông tin sữa chữa-> phiếu sửa chữa ->nhân viên
WHILE((SELECT COUNT(*) FROM dbo.NHANVIEN JOIN dbo.PHIEUSUACHUA ON PHIEUSUACHUA.MANV = NHANVIEN.MANV AND @MANV=NHANVIEN.MANV)>0)
BEGIN--MỘT PHIẾU SỮA CHỮA CÓ NHIỀU THÔNG TIN SỮA CHỮA VÀ MỘT NHÂN VIÊN CÓ THỂ CÓ NHIỀU PHIẾU SỮA CHỮA
SELECT @MAPSC=MAPSC FROM dbo.NHANVIEN JOIN dbo.PHIEUSUACHUA ON PHIEUSUACHUA.MANV = NHANVIEN.MANV AND @MANV=NHANVIEN.MANV

DELETE dbo.THONGTINSUACHUA 
WHERE @MAPSC=MAPSC

DELETE dbo.PHIEUSUACHUA 
WHERE @MAPSC=MAPSC
END
DELETE dbo.NHANVIEN 
WHERE @MANV=MANV

END 
--


--EXEC dbo.DELETE_NHANVIEN @MANV = 'NV04' -- varchar(10)

GO
--XÓA PHỤ TÙNG
CREATE PROCEDURE DELETE_PHUTUNG 
@MAPT VARCHAR(10)
AS
BEGIN
--XÓA THEO THỨ TỰ : THONTINSUACHUA->PHIEUSUACHUA->PHUTUNG

DECLARE @MAPSC VARCHAR(10)
WHILE((SELECT COUNT(*) FROM dbo.PHUTUNG JOIN dbo.THONGTINSUACHUA ON THONGTINSUACHUA.MAPT = PHUTUNG.MAPT AND @MAPT=PHUTUNG.MAPT)>0)
BEGIN
SELECT @MAPSC=MAPSC  FROM dbo.PHUTUNG JOIN dbo.THONGTINSUACHUA ON THONGTINSUACHUA.MAPT = PHUTUNG.MAPT AND @MAPT=PHUTUNG.MAPT


=======
--DROP DATABASE QL_GARA
--XÓA NHÂN VIÊN
CREATE PROCEDURE DELETE_NHANVIEN
@MANV VARCHAR(10)
AS
BEGIN
DECLARE @MAPSC VARCHAR(10)
--xóa theo thứ tự thông tin sữa chữa-> phiếu sửa chữa ->nhân viên
WHILE((SELECT COUNT(*) FROM dbo.NHANVIEN JOIN dbo.PHIEUSUACHUA ON PHIEUSUACHUA.MANV = NHANVIEN.MANV AND @MANV=NHANVIEN.MANV)>0)
BEGIN--MỘT PHIẾU SỮA CHỮA CÓ NHIỀU THÔNG TIN SỮA CHỮA VÀ MỘT NHÂN VIÊN CÓ THỂ CÓ NHIỀU PHIẾU SỮA CHỮA
SELECT @MAPSC=MAPSC FROM dbo.NHANVIEN JOIN dbo.PHIEUSUACHUA ON PHIEUSUACHUA.MANV = NHANVIEN.MANV AND @MANV=NHANVIEN.MANV

DELETE dbo.THONGTINSUACHUA 
WHERE @MAPSC=MAPSC

DELETE dbo.PHIEUSUACHUA 
WHERE @MAPSC=MAPSC
END
DELETE dbo.NHANVIEN 
WHERE @MANV=MANV

END 
--


--EXEC dbo.DELETE_NHANVIEN @MANV = 'NV04' -- varchar(10)

GO
--XÓA PHỤ TÙNG
CREATE PROCEDURE DELETE_PHUTUNG 
@MAPT VARCHAR(10)
AS
BEGIN
--XÓA THEO THỨ TỰ : THONTINSUACHUA->PHIEUSUACHUA->PHUTUNG

DECLARE @MAPSC VARCHAR(10)
WHILE((SELECT COUNT(*) FROM dbo.PHUTUNG JOIN dbo.THONGTINSUACHUA ON THONGTINSUACHUA.MAPT = PHUTUNG.MAPT AND @MAPT=PHUTUNG.MAPT)>0)
BEGIN
SELECT @MAPSC=MAPSC  FROM dbo.PHUTUNG JOIN dbo.THONGTINSUACHUA ON THONGTINSUACHUA.MAPT = PHUTUNG.MAPT AND @MAPT=PHUTUNG.MAPT


>>>>>>> ef48318e6f157635ad9bc1f334c975ec9ad37e1d
DELETE dbo.THONGTINSUACHUA 
WHERE @MAPSC=MAPSC

DELETE dbo.PHIEUSUACHUA 
WHERE @MAPSC=MAPSC
END
DELETE dbo.PHUTUNG 
WHERE @MAPT=MAPT
END

--
--EXECUTE dbo.DELETE_PHUTUNG @MAPT = 'PT01' -- varchar(10)
GO
--XÓA KHÁCH HÀNG
CREATE PROCEDURE DELETE_KHACHHANG
@MAKH VARCHAR(10) 
AS
BEGIN

--XÓA THEO THỨ TỰ : PHIẾU THU TIỀN -> THÔN TIN SỬA CHỮA->PHIẾU SỬA CHỮA->KHÁCH HÀNG
DELETE dbo.PHIEUTHUTIEN 
WHERE @MAKH=MAKH

DECLARE @MAPSC VARCHAR(10)
WHILE((SELECT COUNT(*) FROM dbo.KHACHHANG JOIN dbo.PHIEUSUACHUA ON PHIEUSUACHUA.MAKH = KHACHHANG.MAKH AND @MAKH=KHACHHANG.MAKH)>0)
BEGIN--MỘT PHIẾU SỮA CHỮA CÓ NHIỀU THÔNG TIN SỮA CHỮA VÀ MỘT NHÂN VIÊN CÓ THỂ CÓ NHIỀU PHIẾU SỮA CHỮA
SELECT @MAPSC=MAPSC FROM dbo.KHACHHANG JOIN dbo.PHIEUSUACHUA ON PHIEUSUACHUA.MAKH = KHACHHANG.MAKH AND @MAKH=KHACHHANG.MAKH

DELETE dbo.THONGTINSUACHUA 
WHERE @MAPSC=MAPSC

DELETE dbo.PHIEUSUACHUA 
WHERE @MAPSC=MAPSC
END

DELETE dbo.KHACHHANG 
WHERE @MAKH=MAKH
END
GO
--EXEC dbo.DELETE_KHACHHANG @MAKH = 'KH01' -- varchar(10)
--DROP DATABASE QL_GARA
--SELECT SUM(TIENTHU) as N'DOANHTHU' FROM dbo.PHIEUTHUTIEN WHERE YEAR(NGAYTHU)=YEAR(GETDATE()) AND MONTH(NGAYTHU)=MONTH(GETDATE())
--SELECT PHUTUNG.MAPT AS N'Mã Phụ Tùng',TENPT AS N'Tên Phụ Tùng',SUM(SLPT_SUDUNG) AS N'Số Lượng Sử Dụng Trong Tháng',SOLUONG AS N'Số Lượng Còn Lại',SUM(THANHTIEN) AS'Tiền Thu' FROM dbo.THONGTINSUACHUA JOIN dbo.PHUTUNG ON PHUTUNG.MAPT = THONGTINSUACHUA.MAPT JOIN dbo.PHIEUSUACHUA ON PHIEUSUACHUA.MAPSC = THONGTINSUACHUA.MAPSC AND YEAR(NGAYSUACHUA)=YEAR(GETDATE()) AND MONTH(NGAYSUACHUA)=MONTH(GETDATE()) GROUP BY dbo.PHUTUNG.MAPT,dbo.PHUTUNG.TENPT,SOLUONG
--SELECT *FROM dbo.PHUTUNG

