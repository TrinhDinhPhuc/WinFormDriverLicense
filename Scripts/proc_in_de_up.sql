use SATHACHLAIXE
alter proc sp_NhanVien_Insert
(
@TaiKhoan varchar(20) output ,
@MatKhau varchar(20),
@HoNV nvarchar(30),
@TenNV nvarchar(30),
@DiaChi nvarchar(30),
@SDT nvarchar(11)
)
as
insert into TTNhanVien(TaiKhoan,MatKhau,HoNV,TenNV,[DiaChi],SDT)
values (@TaiKhoan,@MatKhau,@HoNV,@TenNV,@DiaChi,@SDT)
go

EXEC sp_NhanVien_Insert 'guaggf','asdsad','asdsad','sadasd','sadsad','01216547412'

alter procedure sp_NhanVien_Update
(
@TaiKhoan varchar(20) output,
@MatKhau varchar(20),
@HoNV nvarchar(30),
@TenNV nvarchar(30),
@DiaChi nvarchar(30),
@SDT nvarchar(11)
)
as
update TTNhanVien set MatKhau=@MatKhau, HoNV=@HoNV,TenNV=@TenNV,DiaChi=@DiaChi,SDT=@SDT
where TaiKhoan=@TaiKhoan

EXEC sp_NhanVien_Update 'guaggf','1111111','asdsad','sadasd','sadsad','01216547412'

select * from TTNhanVien