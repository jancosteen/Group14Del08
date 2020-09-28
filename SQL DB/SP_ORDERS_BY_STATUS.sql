create procedure SP_ORDERS_BY_STATUS @ORDER_STATUS_ID INT
AS
SELECT O.Order_Id
	,O.QrCode_Seating_Id_FK
	,O.Order_Date_Created
	,O.Order_Date_Completed
	,OS.Order_Status
FROM [dbo].[Order] O
LEFT JOIN [dbo].[Order_Status] OS ON OS.Order_Status_Id = O.Order_Status_Id_FK
WHERE O.Order_Status_Id_FK = @ORDER_STATUS_ID
GO