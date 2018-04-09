select TTCauHoi.MaCH ,TTCauHoi.SoDA ,TTCauHoi.DapAn from  TTCauHoi inner join TTDeThiCauHoi on TTCauHoi.MaCH = TTDeThiCauHoi.MaCH  where TTDeThiCauHoi.MaDeThi =   (select TOP(1) TTDeThi.MaDeThi
from TTHocVien  inner join TTDeThi 
on     TTHocVien.KyThi= TTDeThi.KyThi
inner join TTDeThiCauHoi 
on     TTDeThiCauHoi.MaDeThi = TTDeThi.MaDeThi
inner join TTCauHoi
on TTCauHoi.MaCH= TTDeThiCauHoi.MaCH
where TTHocVien.MaHV='KT01002' 
ORDER BY NEWID()) 
