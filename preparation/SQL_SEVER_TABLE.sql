create database QUANLYBANHANG_LTTQ

use QUANLYBANHANG_LTTQ

create table NHANVIEN
(
	NVID varchar(4),
	HOTEN VARCHAR(40),
	SDT VARCHAR(15),
	NGVL SMALLDATETIME,
	NGSINH SMALLDATETIME,
	THUONG TINYINT,
	CV VARCHAR(20),
	USERNAME VARCHAR(40),
	PASSWD VARCHAR(40),
	LUONG MONEY,
	HESO FLOAT,
	CONSTRAINT PK_NV PRIMARY KEY (NVID)
)

CREATE TABLE KHACHHANG
(
	KHID VARCHAR(4),
	HOTEN VARCHAR(40),
	DIACHI VARCHAR(50),
	SDT VARCHAR (10), 
	NGDK SMALLDATETIME,
	DOANHSO TINYINT,
	LOAIID VARCHAR(4)
	CONSTRAINT PK_KH PRIMARY KEY (KHID)
)

CREATE TABLE LOAIKH
(
	LOAIID VARCHAR(4),
	TENLOAI VARCHAR (40),
	UUDAI INT,
	CONSTRAINT PK_LKH PRIMARY KEY (LOAIID)
)



CREATE TABLE SANPHAM
(
	SPID VARCHAR(4),
	TENSP VARCHAR(40),
	LOAIID VARCHAR(4),
	NUOCSX VARCHAR (10), 
	GIABAN MONEY,
	GIANHAP MONEY,
	DVT TINYINT,
	SOLUONG INT,
	SLTT INT,
	MOTA VARCHAR(500),
	CONSTRAINT PK_SP PRIMARY KEY (SPID)
)

CREATE TABLE LOAISP
(
	LOAIID VARCHAR(4),
	TENLOAI VARCHAR (40),
	MOTA VARCHAR(100),
	CONSTRAINT PK_LSP PRIMARY KEY (LOAIID)
)




CREATE TABLE DTCC
(
	DTID VARCHAR(4),
	TENDT VARCHAR (40),
	SDT VARCHAR(10),
	NGDT SMALLDATETIME,
	DIACHI VARCHAR(50),
	CONSTRAINT PK_DT PRIMARY KEY (DTID)
)


CREATE TABLE HDBH
(
	SOHD_BH VARCHAR(4),
	NGHD SMALLDATETIME,
	KHID VARCHAR(4),
	NVID VARCHAR(4),
	TRIGIA MONEY,
	LOAIHD VARCHAR(20),
	TRANGTHAI VARCHAR(20),
	CONSTRAINT PK_HDBH PRIMARY KEY (SOHD_BH)
)

create table CTHDBH
(
	SOHD_BH VARCHAR(4), 
	SPID VARCHAR(4),
	SL TINYINT
	CONSTRAINT PK_CTHD PRIMARY KEY (SOHD_BH, SPID)
)

CREATE TABLE HDNH
(
	SOHD_NH VARCHAR(4),
	NGNHAP  SMALLDATETIME,
	DTID VARCHAR(4),
	NVID VARCHAR(4),
	TRIGIA MONEY,
	CONSTRAINT PK_HDNH PRIMARY KEY (SOHD_NH)
)

CREATE TABLE CTHDNH
(
	SOHD_NH VARCHAR(4),
	SPID VARCHAR(4),
	SL TINYINT,
	CONSTRAINT PK_CTHDNH PRIMARY KEY (SOHD_NH, SPID)
)

CREATE TABLE CALAMVIEC
(
	CAID VARCHAR(4),
	THU VARCHAR(15),
	GIO_BD DATETIME,
	GIO_NGHI DATETIME,
	CONSTRAINT PK_CLV PRIMARY KEY (CAID)
)

CREATE TABLE CT_LAMVIEC
(
	NVID VARCHAR(4), 
	CAID VARCHAR(4),
	NGAYLAM SMALLDATETIME,
	TRANGTHAI VARCHAR(20),
	CONSTRAINT PK_CTLV PRIMARY KEY (CAID, NVID)
)

CREATE TABLE DOANHTHUNGAY
(
	TODAY DATETIME,
	SLHOADON INT,
	SLDONNHAP INT,
	DOANHTHU MONEY,
	TONGCHI MONEY
	CONSTRAINT PK_DTN PRIMARY KEY (TODAY)
)

 -- CAC KHOA NGOAI --

ALTER TABLE KHACHHANG ADD CONSTRAINT FK_KH FOREIGN KEY (LOAIID) REFERENCES LOAIKH(LOAIID)
ALTER TABLE SANPHAM ADD CONSTRAINT FK_SP FOREIGN KEY (LOAIID) REFERENCES LOAISP(LOAIID)

ALTER TABLE HDBH ADD CONSTRAINT FK_HDBH FOREIGN KEY (NVID) REFERENCES NHANVIEN(NVID)
ALTER TABLE HDNH ADD CONSTRAINT FK_HDNH FOREIGN KEY (NVID) REFERENCES NHANVIEN(NVID)
ALTER TABLE CTHDNH ADD CONSTRAINT FK_CTHDNH FOREIGN KEY (SPID) REFERENCES SANPHAM(SPID)
ALTER TABLE CTHDNH ADD CONSTRAINT FK_CTHDNH2 FOREIGN KEY (SOHD_NH) REFERENCES HDNH(SOHD_NH)
ALTER TABLE CTHDBH ADD CONSTRAINT FK_CTHDBH FOREIGN KEY (SPID) REFERENCES SANPHAM(SPID)
ALTER TABLE CTHDBH ADD CONSTRAINT FK_CTHDBH2 FOREIGN KEY (SOHD_BH) REFERENCES HDBH(SOHD_BH)


ALTER TABLE CT_LAMVIEC ADD CONSTRAINT FK_CT_LV FOREIGN KEY (NVID) REFERENCES NHANVIEN(NVID)
ALTER TABLE CT_LAMVIEC ADD CONSTRAINT FK_CT_LV2 FOREIGN KEY (CAID) REFERENCES CALAMVIEC(CAID)


--CAC DIEU KIEN --

ALTER TABLE NHANVIEN ADD CONSTRAINT DK_LV CHECK( NGVL > NGSINH)
alter table SANPHAM ADD CONSTRAINT DK_SP CHECK( GIABAN > GIANHAP)


--TABLE HDBH : HDBH.NGHD>=NHANVIEN.NGVL, HDBH.NGHD>=KHACHHANG.NGDK, CONG DON DOANH SO KHACHHANG --
create trigger QLBH_ins_upd_HDBH on HDBH for insert, update as
begin
	declare @NGHD SMALLDATETIME, @NVID VARCHAR(4), @NGVL SMALLDATETIME, @NGDK SMALLDATETIME, @KHID VARCHAR(4), @TRIGIA MONEY
	SELECT @NGHD = NGHD, @NVID = NVID, @KHID = KHID, @TRIGIA =TRIGIA FROM inserted
	SELECT @NGVL = NGVL FROM NHANVIEN WHERE NHANVIEN.NVID = @NVID
	
	SELECT @NGDK = NGDK FROM KHACHHANG WHERE KHACHHANG.KHID = @KHID

	IF(@NGHD < @NGVL)
	begin
		PRINT('sai ngay hoa don')
		ROLLBACK TRANSACTION
	end
	ELSE IF(@KHID IS NOT NULL)
		BEGIN
			SELECT @NGDK = NGDK FROM KHACHHANG WHERE KHACHHANG.KHID = @KHID
			IF(@NGDK > @NGHD)
			begin
				PRINT('sai ngay hoa don')
				ROLLBACK TRANSACTION
			end
			UPDATE KHACHHANG SET DOANHSO = DOANHSO + @TRIGIA WHERE KHACHHANG.KHID = @KHID
		END
end

create trigger QLBH_DEL_HDBH on HDBH for DELETE as
begin
	DECLARE @KHID VARCHAR(4), @TRIGIA MONEY
	SELECT @KHID = KHID, @TRIGIA =TRIGIA FROM deleted
	IF(@KHID IS NOT NULL)
		BEGIN
			UPDATE KHACHHANG SET DOANHSO = DOANHSO - @TRIGIA WHERE KHACHHANG.KHID = @KHID
		END
END


--GIABAN > GIANHAP--
ALTER TABLE SANPHAM ADD CONSTRAINT C_GIA CHECK (GIABAN > GIANHAP)

--TABLE CTHDBH : CAP NHAT GIA KHI INSERT VAO BANG CTHDBH, GIAM SO LUONG TU BANG SANPHAM--
CREATE TRIGGER QLBH_INS_UPD_CT_HDBH ON CTHDBH FOR INSERT, UPDATE AS
BEGIN
	DECLARE @SOHD_BH VARCHAR(4), @SPID VARCHAR(4), @SL INT, @GIABAN MONEY
	SELECT @SOHD_BH = SOHD_BH , @SPID = SPID, @SL = SL FROM INSERTED
	SELECT @GIABAN = GIABAN FROM SANPHAM WHERE @SPID = SANPHAM.SPID
	UPDATE HDBH SET TRIGIA = TRIGIA + (@GIABAN*@SL) WHERE HDBH.SOHD_BH = @SOHD_BH
	UPDATE SANPHAM SET SOLUONG = SOLUONG - @SL WHERE SANPHAM.SPID = @SPID
END

--TABLE CTHDNH : CAP NHAT SO LUONG SAN PHAM --
CREATE TRIGGER QLBH_INS_CTHDNH ON CTHDNH FOR INSERT AS
BEGIN
	DECLARE @SOHD_NH VARCHAR(4), @SPID VARCHAR(4), @SL INT
	SELECT @SOHD_NH =SOHD_NH, @SPID = SPID, @SL = SL FROM inserted

	IF ( EXISTS(SELECT * FROM SANPHAM WHERE (SANPHAM.SPID = @SPID)))
	BEGIN 
		UPDATE SANPHAM SET SANPHAM.SOLUONG = SANPHAM.SOLUONG + @SL WHERE (SANPHAM.SPID = @SPID)
	END
	ELSE 
		PRINT('KHONG TON TAI MAT HANG, VUI LONG CAP NHAT')
END
CREATE TRIGGER QLBH_DEL_CTHDNH ON CTHDNH FOR DELETE AS
BEGIN
	DECLARE @SOHD_NH VARCHAR(4), @SPID VARCHAR(4), @SL INT
	SELECT @SOHD_NH =SOHD_NH, @SPID = SPID, @SL = SL FROM deleted

	IF ( EXISTS(SELECT * FROM SANPHAM WHERE (SANPHAM.SPID = @SPID)))
	BEGIN 
		UPDATE SANPHAM SET SANPHAM.SOLUONG = SANPHAM.SOLUONG - @SL WHERE (SANPHAM.SPID = @SPID)
	END
	ELSE 
		PRINT('KHONG TON TAI MAT HANG, VUI LONG KIEM TRA LAI')
END




ALTER TABLE LOAIKH ADD CONSTRAINT CHECK_LOAI CHECK (TENLOAI IN('BINHTHUONG','LAUNAM', 'VIP'))
ALTER TABLE HDBH ADD CONSTRAINT CHECK_LOAIHD_TRANGTHAI CHECK (LOAIHD IN('DDH','DTT') AND TRANGTHAI IN('NHANDON','DANGGIAO','HOANTAT'))

--DIEU KIEN DAT HANG -- 
ALTER TABLE HDBH ADD CONSTRAINT CHECK_LOAIHD_DIEUKIEN CHECK ( (LOAIHD = 'DTT' AND TRANGTHAI IS NULL) OR (LOAIHD = 'DDH' AND KHID IS NOT NULL ) ) 

--NGAYLAM = CALAMVIEC.THU
CREATE TRIGGER QLBH_INS_CT_LAMVIEC ON CT_LAMVIEC FOR INSERT AS
BEGIN
	DECLARE @NGAYLAM  DATETIME, @CAID VARCHAR(4)
	SELECT @NGAYLAM =  NGAYLAM, @CAID = CAID FROM inserted

	IF( datename(DW,@NGAYLAM) = (SELECT THU FROM CALAMVIEC WHERE (CALAMVIEC.CAID = @CAID)))
	BEGIN
		PRINT('SAI NGAY LAM VIEC ')
		ROLLBACK TRANSACTION
	END
END




