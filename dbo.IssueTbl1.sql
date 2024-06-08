CREATE TABLE [dbo].[IssueTbl] (
    [INum]      INT          IDENTITY (1, 1) NOT NULL,
    [StId]      INT          NOT NULL,
    [StName]    VARCHAR (20) NOT NULL,
    [BookId]    INT          NOT NULL,
    [BookName]  VARCHAR (20) NOT NULL,
    [IssueDate] DATE         NOT NULL,
    PRIMARY KEY CLUSTERED ([INum] ASC)
);
GO
ALTER TABLE [dbo].[IssueTbl]
ADD CONSTRAINT FK_IssueTbl_StudentTbl
FOREIGN KEY ([StId]) REFERENCES [dbo].[StudentTbl] ([StId]);
GO
ALTER TABLE [dbo].[IssueTbl]
ADD CONSTRAINT FK_IssueTbl_BookTbl
FOREIGN KEY ([BookId]) REFERENCES [dbo].[BookTbl] ([BId]);

GO
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
		values( 'Student With ID: ' + cast(@StdId as nvarchar(5)) + 
		' Borrowed Book with Id: ' + cast(@BkId as nvarchar(5)) +
		' ON ' + cast( @dt as nvarchar(10)))

	END