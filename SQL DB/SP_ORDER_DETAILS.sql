create procedure SP_ORDER_DETAILS
AS
SELECT O.Order_Id
	,O.QrCode_Seating_Id_FK
	,O.Order_Date_Created
	,O.Order_Date_Completed
	,OS.Order_Status
	,MI.Menu_Item_Name
	,OL.Item_Qty
	,MIP.Menu_Item_Price
	
FROM [dbo].[Menu_Item] MI
LEFT JOIN [dbo].[Order_Line] OL ON OL.Menu_Item_Id_FK = MI.Menu_Item_Id
LEFT JOIN [dbo].[Order] O ON O.Order_Id = OL.Order_Id_FK
LEFT JOIN [dbo].[Order_Status] OS ON OS.Order_Status_Id = O.Order_Status_Id_FK
LEFT JOIN [dbo].[Menu_Item_Price] MIP ON MIP.Menu_Item_Price_Id = MI.Menu_Item_Price_Id_FK

