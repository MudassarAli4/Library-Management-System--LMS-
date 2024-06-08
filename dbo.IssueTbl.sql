CREATE TABLE [dbo].[IssueTbl]
(
	[INum] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StId] INT NOT NULL, 
    [StName] VARBINARY(20) NOT NULL, 
    [BookId] INT NOT NULL, 
    [BookName] VARCHAR(20) NOT NULL, 
    [IssueDate] DATE NOT NULL
)
