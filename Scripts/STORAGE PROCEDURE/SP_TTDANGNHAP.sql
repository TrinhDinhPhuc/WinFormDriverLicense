-- Author : Phuc Bui 
-- Date : 2018-03-29
-- PROC OF TABLE : Thong tin nhân viên

-- PROC Kiểm tra tồn tại tài khoản khi thêm mới 1 user
create procedure SP_KiemTraTonTaiTK
 @USER varchar(20),
 @KQ int out
AS
BEGIN
SET @KQ=0
DECLARE @KT varchar(30)
SET @KT=(SELECT [TTDangNhap].TaiKhoan FROM [TTDangNhap] WHERE [TTDangNhap].TaiKhoan=@USER)
if(@KT is null) SET @KQ=1
else SET @KQ=0
return @KQ
END

-- PROC Kiểm tra thông tin đăng nhập
go
create procedure SP_KiemTraDangNhap
 @USER varchar(20),
 @PASS varchar(20),
 @KQ int out
AS
BEGIN
SET @KQ=0
DECLARE @KT varchar(30)
SET @KT=(SELECT [TTDangNhap].TaiKhoan FROM [TTDangNhap] WHERE [TTDangNhap].TaiKhoan=@USER AND [TTDangNhap].MatKhau=@PASS)
if(@KT is null) SET @KQ=1
else SET @KQ=0
return @KQ
END
-- PROC Thêm thông tin tài khoản đăng nhập
go
CREATE PROCEDURE SP_ThemTaiKhoan
 @USER varchar(20),
 @PASS varchar(20),
 @HONV nvarchar(30),
 @TENNV nvarchar(30),
 @DIACHI nvarchar(30),
 @SDT varchar(11),
 @MACV varchar(10),
 @KQ int out
 AS
BEGIN
SET @KQ=0
INSERT INTO [TTDangNhap] VALUES (@USER,@PASS,@HONV,@TENNV,@DIACHI,@SDT,@MACV)
SET @KQ=1
RETURN @KQ
END
-- PROC Sửa thông tin tài khoản đăng nhập
go
CREATE PROCEDURE SP_SuaTaiKhoan
 @USER varchar(20),
 @PASS varchar(20),
 @HONV nvarchar(30),
 @TENNV nvarchar(30),
 @DIACHI nvarchar(30),
 @SDT varchar(11),
 @MACV varchar(10),
 @KQ int out
 AS
BEGIN
SET @KQ=0
UPDATE [TTDangNhap]  SET MatKhau=@PASS,HoNV= @HONV, TenNV= @TENNV,DiaChi= @DIACHI,SDT=@SDT,MaCV= @MACV WHERE TaiKhoan=@USER
SET @KQ=1
RETURN @KQ
END
-- PROC Xóa thông tin tài khoản đăng nhập
go
CREATE PROCEDURE SP_XoaTaiKhoan
 @USER varchar(20),
 @KQ int out
AS
BEGIN
SET @KQ=0
DELETE FROM [TTDangNhap] WHERE TaiKhoan=@USER
SET @KQ=1
RETURN @KQ
END