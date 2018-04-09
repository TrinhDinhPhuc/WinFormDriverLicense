USE SATHACHBANGLAI1
GO
drop TRIGGER TG_NGAYDK
ON [TTHOCVIEN]
FOR INSERT
AS
BEGIN
DECLARE @NGAYDK VARCHAR(10);
SET @NGAYDK=CONVERT(VARCHAR(10),GETDATE(),120);
UPDATE dbo.TTHocVien SET dbo.TTHocVien.NgayDK=@NGAYDK WHERE KyThi='' or MaHV='' or NgayDK=''
END