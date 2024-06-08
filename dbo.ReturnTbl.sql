CREATE TABLE [dbo].[ReturnTbl] (
    [RNum] INT NOT NULL IDENTITY,
    [StId] INT NOT NULL, 
    [StName] VARCHAR(20) NOT NULL, 
    [BookId] INT NOT NULL, 
    [BookName] VARCHAR(20) NOT NULL, 
    [IssueDate] DATE NOT NULL, 
    [ReturnDate] DATE NOT NULL, 
    [Fine] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([RNum] ASC)
);

