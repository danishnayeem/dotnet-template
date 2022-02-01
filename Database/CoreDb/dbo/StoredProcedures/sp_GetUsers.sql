CREATE PROCEDURE [dbo].[sp_GetUsers]
AS
BEGIN
  SELECT * FROM [dbo].[User];
END