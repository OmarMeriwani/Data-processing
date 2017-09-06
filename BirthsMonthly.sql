CREATE TABLE [dbo].BirthsMonthly
(
    [Country] INT NOT NULL, 
    [Year] INT NOT NULL, 
    [Month] NVARCHAR(100) NOT NULL, 
    [Births] INT NOT NULL, 
    [id] INT NOT NULL  identity (1,1), 
    [Datee] DATE NULL, 
    [SexDate] DATE NULL, 
    [SexDateAvgTemp] FLOAT NULL 
)
