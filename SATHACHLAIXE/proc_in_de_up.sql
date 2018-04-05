use SATHACHLAIXE
create proc sp_NhanVien_Insert
(
@TaiKhoan varchar(20),
@MatKhau varchar(20),
@HoNV nvarchar(30),
@TenNV nvarchar(30),
@DiaChi nvarchar(30),
@SDT nvarchar(11),
@TruyCapCuoi datetime
)
as
insert into TTNhanVien(TaiKhoan,MatKhau,HoNV,TenNV,[DiaChi],SDT,TruyCapCuoi)
values (@TaiKhoan,@MatKhau,@HoNV,@TenNV,@DiaChi,@SDT,@TruyCapCuoi)
go
create procedure sp_NhanVien_Update
(
@TaiKhoan varchar(20),
@MatKhau varchar(20),
@HoNV nvarchar(30),
@TenNV nvarchar(30),
@DiaChi nvarchar(30),
@SDT nvarchar(11),
@TruyCapCuoi datetime
)
as
update TTNhanVien set MatKhau=@MatKhau, HoNV=@HoNV,TenNV=@TenNV,DiaChi=@DiaChi,SDT=@SDT,TruyCapCuoi=@TruyCapCuoi
where TaiKhoan=@TaiKhoan