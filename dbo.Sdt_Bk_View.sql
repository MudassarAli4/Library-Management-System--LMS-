CREATE VIEW [dbo].[Sdt_Bk_View]
	AS SELECT
    ST.StId,
    ST.StName,
    ST.StDep,
    ST.StSem,
    ST.StPhone,
    IT.BookId,
    IT.BookName,
    BT.BAuthor,
    BT.BPublisher,
	RT.IssueDate,
	RT.ReturnDate
FROM
    StudentTbl ST
    JOIN IssueTbl IT ON ST.StId = IT.StId
    JOIN BookTbl BT ON IT.BookId = BT.BId
    JOIN ReturnTbl RT ON ST.StId = RT.StId