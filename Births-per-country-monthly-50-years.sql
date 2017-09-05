CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL IDENTITY (1,1)  PRIMARY KEY, 
    [Country] NVARCHAR(200) NOT NULL, 
    [Year] INT NOT NULL, 
    [Month] NVARCHAR(100) NOT NULL, 
    [Births] INT NOT NULL  
)
