CREATE PROC SP_RANDOM_MACH
@Upper INT,
@Lower INT
AS
BEGIN
DECLARE @Random INT;
DECLARE @so int,@KT varchar(10)
set @so=1
---- This will create a random number between 1 and 999
DELETE FROM RANDOM
SET @Random = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
INSERT INTO RANDOM VALUES(@Random)
WHILE (@so<=9)
BEGIN
SET @Random = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)

SET @KT=(SELECT top(1) SoCau FROM RANDOM WHERE SoCau=@Random)
if(@KT  is null)
BEGIN 
INSERT INTO RANDOM VALUES(@Random)
SET @so=@so+1;
END
END
END
EXEC SP_RANDOM_MACH 1,100

