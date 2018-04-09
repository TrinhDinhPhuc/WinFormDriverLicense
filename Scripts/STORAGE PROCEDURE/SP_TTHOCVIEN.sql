-- Author : Phuc Bui 
-- Date : 2018-03-29
-- PROC OF TABLE : Thong tin hoc vien

-- PROC Kiểm tra tồn tại chứng minh đã đăng ký trong kỳ thi khi thêm mới
create procedure SP_KiemTraTonTaiCMND
 @CMND varchar(20),
 @KQ int out
AS
BEGIN
SET @KQ=0
DECLARE @KT varchar(30)
SET @KT=(SELECT [TTHocVien].SoCMND FROM [TTHocVien] WHERE [TTHocVien].SoCMND=@CMND)
if(@KT is null) SET @KQ=1
else SET @KQ=0
return @KQ
END
-- PROC Kiểm tra thông tin đăng nhập thi
go
create procedure SP_KiemTraDangNhapThi
 @MAHV varchar(20),
 @CMND varchar(20),
 @KQ int out
AS
BEGIN
SET @KQ=0
DECLARE @KT varchar(30)
SET @KT=(SELECT [TTHocVien].MaHV FROM [TTHocVien] WHERE [TTHocVien].MaHV=@MAHV AND [TTHocVien].SoCMND=@CMND)
if(@KT is null) SET @KQ=1
else SET @KQ=0
return @KQ
END
-- PROC Thêm thông tin học viên đăng ký
go
CREATE PROCEDURE SP_ThemTaiKhoan
 @TENHV nvarchar(30),
 @HOHV nvarchar(30),
 @NGAYSINH varchar(10),
 @SoCMND varchar(10),
 @NgayCap varchar(10),
 @SDT varchar(11),
 @DiaChi nvarchar(30),
 @KQ int out
 AS
BEGIN
SET @KQ=0
INSERT INTO [TTHocVien] VALUES ('',@TENHV,@HOHV,@NGAYSINH,@SoCMND,@NgayCap,@SDT,@DiaChi,0,'','')
SET @KQ=1
RETURN @KQ
END
-- PROC Sửa thông tin học viên đăng ký
go
CREATE PROCEDURE SP_SuaTaiKhoanThi
 @MAHV varchar(10),
 @TENHV nvarchar(30),
 @HOHV nvarchar(30),
 @NGAYSINH varchar(10),
 @SoCMND varchar(10),
 @NgayCap varchar(10),
 @SDT varchar(11),
 @DiaChi nvarchar(30),
 @KQ int out
AS
BEGIN
SET @KQ=0
UPDATE [TTHocVien] SET TenHV=@TENHV,HoHV=@HOHV,NgaySinh=@NGAYSINH,SoCMND=@SoCMND,NgayCapCMND=@NgayCap,SDT=@SDT,DiaChi=@DiaChi WHERE MaHV=@MAHV
SET @KQ=1
RETURN @KQ
END
--PROC Xóa Thông Tin Học Viên Đăng Ký
go
CREATE PROCEDURE SP_XoaTaiKhoanThi
 @MAHV varchar(10),
 @KQ int out
AS
BEGIN
SET @KQ=0
DELETE FROM [TTHocVien] WHERE MAHV=@MAHV
SET @KQ=1
RETURN @KQ
END