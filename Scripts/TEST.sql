USE SATHACHLAIXE
GO
ALTER TABLE TTHOCVIEN NOCHECK CONSTRAINT FK__TTHocVien__KyThi__30F848ED
INSERT INTO TTHocVien VALUES('','PHUC','TRINH','1996-03-16','251011078','2011-10-07','01216585084','ĐÀ LẠT',0,'','')

ALTER TABLE TTHOCVIEN WITH CHECK CHECK CONSTRAINT ALL


alter proc sp_HocVien_Insert
(
@MaHV varchar(10) output,
@TenHV nvarchar(30),
@HoHV nvarchar(30),
@NgaySinh date,
@SoCMND varchar(10),
@NgayCapCMND date,
@SDT varchar(11),
@DiaChi nvarchar(30),
@DiemTH int, 
@NgayDK date,
@KyThi varchar(10)
)
as
ALTER TABLE TTHOCVIEN NOCHECK CONSTRAINT FK__TTHocVien__KyThi__30F848ED
if @NGAYDK <= (DATEADD(DAY,30, ))
insert into TTHOCVIEN(MaHV,TenHV,HoHV,NgaySinh,SoCMND,NgayCapCMND,SDT,DiaChi,DiemTH,NgayDK,KyThi)
values (@MaHV,@TenHV,@HoHV,@NgaySinh,@SoCMND,@NgayCapCMND,@SDT,@DiaChi,@DiemTH,@NgayDK,@KyThi)
ALTER TABLE TTHOCVIEN WITH CHECK CHECK CONSTRAINT ALL
go

-------------------------------------------------------------------------------------
alter proc sp_HocVien_Insert
(
@MaHV varchar(10) output,
@TenHV nvarchar(30),
@HoHV nvarchar(30),
@NgaySinh date,
@SoCMND varchar(10),
@NgayCapCMND date,
@SDT varchar(11),
@DiaChi nvarchar(30),
@DiemTH int, 
@NgayDK date,
@KyThi varchar(10)
)
as
begin
declare @ngaydangky date,@ngaybatdau date, @kithi varchar(10)

select @ngaydangky = @NgayDK
from dbo.TTHocVien
where KyThi=@kithi;

select @ngaybatdau = p.NgayBatDauDK, @kithi = p.KyThi
FROM dbo.TTKyThi p
INNER JOIN dbo.TTHocVien t
ON p.KyThi=t.KyThi
where t.KyThi = @kithi; 

if @ngaybatdau<=(DATEADD(DAY,30,@ngaydangky))
begin
begin tran;
ALTER TABLE TTHOCVIEN NOCHECK CONSTRAINT FK__TTHocVien__KyThi__30F848ED
insert into TTHOCVIEN(MaHV,TenHV,HoHV,NgaySinh,SoCMND,NgayCapCMND,SDT,DiaChi,DiemTH,NgayDK,KyThi)
values (@MaHV,@TenHV,@HoHV,@NgaySinh,@SoCMND,@NgayCapCMND,@SDT,@DiaChi,@DiemTH,@NgayDK,@KyThi)
ALTER TABLE TTHOCVIEN WITH CHECK CHECK CONSTRAINT ALL
commit tran;
end;
end;
go
-------------------------------------------------------------------------------------
alter proc sp_HocVien_Insert
(
@MaHV varchar(10) output,
@TenHV nvarchar(30),
@HoHV nvarchar(30),
@NgaySinh date,
@SoCMND varchar(10),
@NgayCapCMND date,
@SDT varchar(11),
@DiaChi nvarchar(30),
@DiemTH int, 
@NgayDK date,
@KyThi varchar(10)
)
AS
begin
declare @cmnd varchar(10)
select @cmnd = @SoCMND from dbo.TTHocVien 
begin
begin tran;
IF NOT EXISTS (SELECT * FROM TTHocVien With(updlock)  WHERE SoCMND = @cmnd)
begin
ALTER TABLE TTHOCVIEN NOCHECK CONSTRAINT FK__TTHocVien__KyThi__30F848ED
insert into TTHOCVIEN(MaHV,TenHV,HoHV,NgaySinh,SoCMND,NgayCapCMND,SDT,DiaChi,DiemTH,NgayDK,KyThi)
values (@MaHV,@TenHV,@HoHV,@NgaySinh,@SoCMND,@NgayCapCMND,@SDT,@DiaChi,@DiemTH,@NgayDK,@KyThi)
ALTER TABLE TTHOCVIEN WITH CHECK CHECK CONSTRAINT ALL

end
commit tran;
end;
end;
go

-------------------------------------------------------------------------------------
exec sp_HocVien_Insert ' ','LALA','LALA','1996-10-15','256858748','2012-05-10','09858748759','BÌNH ĐỊNH',0,'',''

Alter procedure sp_HocVien_Update
(
@MaHV varchar(10) output ,
@TenHV nvarchar(30),
@HoHV nvarchar(30),
@NgaySinh date,
@SoCMND varchar(10),
@NgayCapCMND date,
@SDT varchar(11),
@DiaChi nvarchar(30),
@DiemTH int
)
as
update TTHOCVIEN set TenHV=@TenHV,HoHV=@HoHV,NgaySinh=@NgaySinh,SoCMND=@SoCMND,NgayCapCMND=@NgayCapCMND,SDT=@SDT,DiaChi=@DiaChi,DiemTH=@DiemTH
where MaHV=@MaHV
exec sp_HocVien_Update 'KT01004','LALA1','LALA1','1996-10-15','256858748','2012-05-10','09858748759','Ba Vi',0


-------------------------------------------------------------------------------------
alter proc	
(
@KyThi varchar(10) output,
@NgayBatDauDK varchar(30),
@TaiKhoan varchar(20)
)
AS
begin
declare @ngaybatdau varchar(10)
select @ngaybatdau = @KyThi from dbo.TTKyThi
begin
begin tran;
if NOT EXISTS (SELECT NgayBatDauDK FROM TTKyThi WHERE @NgayBatDauDK between NgayBatDauDK and dateadd(DAY,30,NgayBatDauDK) ) 
begin
insert into TTKyThi(KyThi, NgayBatDauDK ,TaiKhoan)
values (@KyThi,@NgayBatDauDK,@TaiKhoan)
end
commit tran;
end;
end;
go

-------------------------------------------------------------------------------------

create procedure sp_KyThi_Update
(
@KyThi varchar(10) output,
@NgayBatDauDK varchar(30),
@TaiKhoan varchar(20)
)
as
update TTKyThi set NgayBatDauDK=@NgayBatDauDK,TaiKhoan=@TaiKhoan
where KyThi=@KyThi
exec sp_HocVien_Update 