﻿CREATE TABLE [dbo].[BookTbl]
(
	[BId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BName] VARCHAR(20) NOT NULL, 
    [BAuthor] VARCHAR(20) NOT NULL, 
    [BPublisher] VARCHAR(100) NOT NULL, 
    [BPrice] INT NOT NULL, 
    [Bqty] INT NOT NULL
)
