CREATE PROCEDURE [dbo].[spUser_BasicInfo_Filter]
  @param1 int = 0,
  @param2 int
AS
  SELECT @param1, @param2;
  SELECT * FROM vwUser_BasicInfo;
RETURN 0
