-- Author : Phuc Bui 
-- Date : 2018-03-29
-- PROC OF TABLE : Thong tin chuc vu

--PROC Thêm Tên Chức Vụ
CREATE PROCEDURE Insert_ChucVu
   @TenCV nvarchar(50),
   @KQ int out
AS
BEGIN
   SET @KQ=0;
   DECLARE @CVKT nvarchar(50)
   SET @TenCV=REPLACE(@TenCV,'  ',' ')
   SET @TenCV=LTRIM(@TenCV)
   SET @TenCV=RTRIM(@TenCV)
   SET @CVKT=(SELECT MaCV FROM [TTCHUCVU] WHERE TENCV=@TenCV)
   if(@CVKT is Null) SET @KQ=0;
   Else SET @KQ=1;
   if(@KQ = 0)
   INSERT INTO [TTCHUCVU] VALUES('',@TenCV)
   Return @KQ;
END