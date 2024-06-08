CREATE TRIGGER [Issue_Trigger]
	ON [dbo].[IssueTbl]
	FOR INSERT
	AS
	BEGIN

		declare @StdId int
		declare @BkId int
		declare @dt date

		select @StdId = StId from inserted
		select @BkId = BookId from inserted
		select @dt = IssueDate from inserted

		insert into IssuedBooksData
		values( 'Student With ID = ' + cast(@StdId as nvarchar(5)) + 
		'Borrowed the Book with Id = ' + cast(@BkId as nvarchar(5)) +
		' ON ' + cast( @dt as nvarchar(10)))

	END
