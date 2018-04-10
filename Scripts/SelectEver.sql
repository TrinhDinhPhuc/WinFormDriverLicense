select TTCauHoi.MaCH ,TTCauHoi.SoDA ,TTCauHoi.DapAn from  
TTCauHoi inner join TTDeThiCauHoi on TTCauHoi.MaCH = TTDeThiCauHoi.MaCH  
where TTDeThiCauHoi.MaDeThi =   (select TOP(1) TTDeThi.MaDeThi
from TTHocVien  inner join TTDeThi 
on     TTHocVien.KyThi= TTDeThi.KyThi
inner join TTDeThiCauHoi 
on     TTDeThiCauHoi.MaDeThi = TTDeThi.MaDeThi
inner join TTCauHoi
on TTCauHoi.MaCH= TTDeThiCauHoi.MaCH
where TTHocVien.MaHV='KT01002' 
ORDER BY NEWID()) 


create table DAPAN
(
STT int,
MsCauHoi varchar(30),
DapAnofTS varchar(30)
)


--------------------------------------------------------------------------
USE SATHACHLAIXE
GO
/****** Object:  UserDefinedFunction [dbo].[Check_Dap_An]    Script Date: 4/10/2018 7:54:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function Check_Dap_An()
Returns int
begin
declare @SoLuong int;
Set @SoLuong= (SELECT Count(*) FROM TTCauHoi O INNER JOIN DAPAN C ON C.MsCauHoi = O.MaCH and C.DapAnofTS=O.DapAn)
return @SoLuong;
End;

print dbo.Check_Dap_An()



create proc [Xem_Dap_An_Sai]
as
SELECT STT, MaCH,DapAn FROM TTCauHoi O INNER JOIN DAPAN C ON C.MsCauHoi = O.MaCH and C.DapAnofTS != O.DapAn
exec[Xem_Dap_An_Dung]
create proc [Xem_Dap_An_Dung]
as
SELECT STT, MaCH,DapAn FROM TTCauHoi O INNER JOIN DAPAN C ON C.MsCauHoi = O.MaCH and C.DapAnofTS = O.DapAn



Insert into TTBaiThi (STT, MaDeThi ,MaHV ,DapAnTS)	SELECT STT , 'KT01001' ,'KT01001' , DapAnofTS FROM DAPAN 

Insert into TTBaiThi (STT, MaDeThi ,MaHV ,DapAnTS) SELECT STT , 'KT01001' , +(select distinct MaDeThi from TTBaiThi where MaHV = 'KT01001')  , DapAnofTS FROM DAPAN 

	delete from TTBaiThi
select distinct MaDeThi from TTBaiThi where MaHV = 'KT01001'