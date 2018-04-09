CREATE DATABASE SATHACHLAIXE
USE SATHACHLAIXE
GO
-- Tạo bảng nhân viên
create table TTNhanVien(
TaiKhoan varchar(20)  primary key not null ,
MatKhau varchar(20) not null,
HoNV nvarchar(30) not null,
TenNV nvarchar(30) not null,
DiaChi nvarchar(30) not null,
SDT nvarchar(11) not null,
TruyCapCuoi datetime,
AnhNV varchar(250)
)



-- Tạo bảng thông tin Kỳ Thi
Create table TTKyThi(
KyThi varchar(10) primary key not null,
NgayBatDauDK date not null,
TaiKhoan varchar(20) References TTNhanVien(TaiKhoan) on delete cascade
)
-- Tạo bảng câu hỏi
Create table TTCauHoi(
MaCH varchar(10) primary key not null,
SoDA int not null,
DapAn varchar(10) not null
)
-- Tạo bảng thông tin đề thi 
Create table TTDeThi(
MaDeThi varchar(10) primary key not null,
KyThi varchar(10) references TTKyThi(KyThi) on delete cascade
)
-- Tạo bảng random đề thi
Create table TTDeThiCauHoi(
MaDeThi varchar(10) references TTDeThi(MaDeThi) on delete cascade,
MaCH varchar(10) references TTCauHoi(MaCH) on delete cascade,
primary key(MaDeThi,MaCH)
)
-- Tạo bảng thông tin học viên 
Create table TTHocVien(
MaHV varchar(10) primary key not null,
TenHV nvarchar(30) not null,
HoHV nvarchar(30) not null,
NgaySinh date not null,
SoCMND varchar(10) not null,
NgayCapCMND date not null,
SDT varchar(11) not null,
DiaChi nvarchar(30) not null,
DiemTH int not null,
NgayDK date not null,
KyThi varchar(10) references TTKyThi(KyThi) 
)
-- Tạo bảng lưu thông tin bài thi học viên
create table TTBaiThi(
STT int,
MaDeThi varchar(10) references TTDeThi(MaDeThi) on delete cascade,
MaHV varchar(10) references TTHocVien(MaHV) on delete cascade,
DapAnTS varchar(5),
primary key(MaDeThi,STT,MaHV)
)