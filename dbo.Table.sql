CREATE TABLE [dbo].[Table]
(
	[tickerId] INT NOT NULL PRIMARY KEY, 
    [tickerName] TEXT NOT NULL, 
    [lastPrice] INT NULL, 
    [lastUpdate] DATE NULL
)
