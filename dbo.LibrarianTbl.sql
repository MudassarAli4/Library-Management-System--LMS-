﻿CREATE TABLE [dbo].[LibrarianTbl]
(
	[LibId] INT NOT NULL PRIMARY KEY IDENTITY(500, 1), 
    [LibName] VARCHAR(20) NOT NULL, 
    [LibPhone] VARCHAR(20) NOT NULL, 
    [LibPass] VARCHAR(20) NOT NULL
)
