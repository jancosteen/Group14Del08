CREATE PROCEDURE SP_MENU_MENUITEMS @MENU_ID INT
AS
SELECT 
	M.Menu_Id,
	M.Menu_Name,
	MI.Menu_Item_Id,
	MI.Menu_Item_Name,
	MI.Menu_Item_Description,
	MIP.Menu_Item_Price,
	MIC.Menu_Item_Category

FROM [dbo].[Menu_Restaurant] MR
LEFT JOIN [dbo].[Menu_Item] MI ON MI.Menu_Item_Id = MR.Menu_Item_Id_FK
LEFT JOIN [dbo].[Menu] M ON M.Menu_Id = MR.Menu_Id_FK
LEFT JOIN [dbo].[Menu_Item_Price] MIP ON MIP.Menu_Item_Price_Id = MI.Menu_Item_Price_Id_FK
LEFT JOIN [dbo].[Menu_Item_Category] MIC ON MIC.Menu_Item_Category_Id = MI.Menu_Item_Category_Id_FK

WHERE MR.Menu_Id_FK = @MENU_ID