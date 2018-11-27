﻿CREATE TABLE [dbo].[Member]
(
	[MemberId] INT IDENTITY(1,1),
	[Email] NVARCHAR (100),
	[FullName] NVARCHAR (100),
	CONSTRAINT PK_MEMBER PRIMARY KEY (MemberId)
)
