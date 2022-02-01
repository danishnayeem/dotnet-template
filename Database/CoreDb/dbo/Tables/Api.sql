CREATE TABLE [dbo].[Api]
(
  [Id]          INT                       NOT NULL PRIMARY KEY IDENTITY,
  [Name]        NVARCHAR(100)              NOT NULL,
  [Description] TEXT                      NULL    ,
  [Path]        NVARCHAR(100)              NOT NULL,
  [Status]      NVARCHAR(10) CHECK([Status] IN('Inactive','Active')) NOT NULL DEFAULT 'Inactive'
)
