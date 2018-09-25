USE [###]
GO
/****** Object:  Trigger [dbo].[ti_to2PN]    Script Date: 12/02/2015 14:41:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--12/02/2015 Cole: Added prevention against insertion of Carriage Return/LineBreak resulting in a blank PNID.
ALTER TRIGGER [dbo].[ti_to2PN]
ON [dbo].[to2PN]
AFTER INSERT
AS 
BEGIN
	DECLARE @errno int, @errmsg VARCHAR(200), @PNID VARCHAR(30), @iPNID VARCHAR(30), @PNKey int
	--12/02/2015 CD
	SELECT @PNID = PNID FROM inserted
	SELECT @iPNID = LTRIM(RTRIM(REPLACE(PNID, CHAR(13)+CHAR(10)+CHAR(9), ''))) FROM inserted
	--CHAR(13)=Carriage Return / CHAR(10)=Line Feed / CHAR(9)=Tab
	
	IF (LEN(@iPNID)<> LEN(@PNID))
	   BEGIN
            SELECT @errno =50001, @errmsg = 'ti_to2PN Cannot insert into to2PN because PNID is contains a Line Break or a Carriage Return.'
            GOTO ERROR
        END
        RETURN
--12/02/2015 CD
		ERROR:
        raiserror (@errmsg,16,1)
            ROLLBACK TRAN