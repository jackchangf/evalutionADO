USE [BOOKS]
GO
/****** Object:  StoredProcedure [dbo].[DeleteBook]    Script Date: 25/4/2021 3:30:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DeleteBook]
@BookId int
AS
delete from BOOK where BookId=@BookId
