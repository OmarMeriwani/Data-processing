CREATE TABLE [dbo].[Countries] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [title]            NVARCHAR (200) NOT NULL,
    [WinterJul]        BIT            NULL,
    [HemsphereDevided] BIT            NULL,
    [WinterAvgMin]     FLOAT (53)     NULL,
    [SummerAvgMax]     FLOAT (53)     NULL,
    [Equator]          BIT            NULL,
    [NorthPole]        BIT            NULL,
    [AnnualTemp] FLOAT NULL, 
    [ISOCode] NCHAR(3) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

