CREATE VIEW [dbo].[View]
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
    LT.LibId,
    LT.LibName
FROM
    StudentTbl ST
    JOIN IssueTbl IT ON ST.StId = IT.StId
    JOIN BookTbl BT ON IT.BookId = BT.BId
    JOIN LibrarianTbl LT ON IT.StId = LT.LibId;
