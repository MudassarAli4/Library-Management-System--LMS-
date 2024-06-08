CREATE TABLE [dbo].[ReturnTbl] (
    [RNum]       INT          IDENTITY (1, 1) NOT NULL,
    [StId]       INT          NOT NULL,
    [StName]     VARCHAR (20) NOT NULL,
    [BookId]     INT          NOT NULL,
    [BookName]   VARCHAR (20) NOT NULL,
    [IssueDate]  DATE         NOT NULL,
    [ReturnDate] DATE         NOT NULL,
    [Fine]       INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([RNum] ASC)
);
GO
ALTER TABLE [dbo].[ReturnTbl]
ADD CONSTRAINT FK_ReturnTbl_StudentTbl
FOREIGN KEY ([StId]) REFERENCES [dbo].[StudentTbl] ([StId]);
GO
ALTER TABLE [dbo].[ReturnTbl]
ADD CONSTRAINT FK_ReturnTbl_BookTbl
FOREIGN KEY ([BookId]) REFERENCES [dbo].[BookTbl] ([BId]);

