USE SATHACHLAIXE
GO
--drop TRIGGER TG_MAHV_NGAYDK_KYTHI
create TRIGGER TG_MAHV_NGAYDK_KYTHI
ON [TTHOCVIEN]
FOR INSERT
AS
BEGIN
DECLARE @NGAYDK VARCHAR(10),@KYTHI VARCHAR(5),@MAHV VARCHAR(15),@TAM VARCHAR(15),@MASO VARCHAR(15),@MACUOI VARCHAR(15);

SET @NGAYDK=CONVERT(VARCHAR(10),GETDATE(),120);
SET @KYTHI=(SELECT TOP (1) KyThi from TTKyThi where ((NgayBatDauDK <= @NGAYDK) AND (@NGAYDK <= (DATEADD(DAY,30,NgayBatDauDK)))) ORDER BY KyThi ASC)
PRINT @KYTHI
SET @TAM=@KYTHI

SET @MACUOI=(SELECT TOP (1) MAHV FROM TTHocVien WHERE KyThi = @KYTHI ORDER BY MaHV DESC) 
IF (@MACUOI IS NULL)
BEGIN
SET @MAHV=@TAM+'001';
UPDATE dbo.TTHocVien SET dbo.TTHocVien.MaHV = @MAHV,dbo.TTHocVien.KyThi=@KYTHI,dbo.TTHocVien.NgayDK=@NGAYDK WHERE dbo.TTHocVien.MaHV =''or KyThi='' or NgayDK=''
END
ELSE 
BEGIN
SET @TAM=REPLACE(@MACUOI,left(@MACUOI,4),'')+1
SET @MAHV=@KYTHI+
CASE
       WHEN LEN(@TAM)<9
          THEN REPLICATE('0',3-LEN(@TAM))
          ELSE ''
  
END
+ @TAM
UPDATE dbo.TTHocVien SET dbo.TTHocVien.MaHV = @MAHV,dbo.TTHocVien.KyThi=@KYTHI,dbo.TTHocVien.NgayDK=@NGAYDK WHERE dbo.TTHocVien.MaHV =''or KyThi='' or NgayDK=''
END

END