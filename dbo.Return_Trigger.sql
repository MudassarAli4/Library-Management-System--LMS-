CREATE TRIGGER [Return_Trigger]
	ON [dbo].[ReturnTbl]
    for INSERT
	AS
	BEGIN

		declare @StdId int
		declare @BkId int
		declare @rt date
		declare @fn date

		select @StdId = StId from inserted
		select @fn = Fine from inserted
		select @BkId = BookId from inserted
		select @rt = ReturnDate from inserted

		insert into ReturnedBooksData
		values( 'Student With ID = ' + cast(@StdId as nvarchar(5)) + 
		'Returned the Book with Id = ' + cast(@BkId as nvarchar(5)) +
		' ON ' + cast( @rt as nvarchar(10)) + ' Having Fine Rs: ' + cast(@fn as nvarchar(5)))

	END