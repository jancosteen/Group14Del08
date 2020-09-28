CREATE PROCEDURE SP_RESERVATIONS
AS
SELECT 
	R1.Reservation_Id
	,R1.User_Id_FK
	,R1.Reservation_date_Created
	,R1.Reservation_Date_Reserved
	,R1.Reservation_NumberOfBills
	,R1.Reservation_Party_Qty
	,RS.Reservation_Status
	,R2.Restaurant_Name
	,R2.Restaurant_Address_Line_1
	,R2.Resaturant_Address_Line_2
	,R2.Restaurant_City
FROM [dbo].[Reservation] R1
LEFT JOIN [dbo].[Reservation_Status] RS ON RS.Reservation_Status_Id = R1.Reservation_Status_Id_FK
LEFT JOIN [dbo].[Reservation_Restaurant] RR ON RR.Reservation_Id_FK = R1.Reservation_Id
LEFT JOIN [dbo].[Restaurant] R2 ON R2.Restaurant_Id = RR.Restaurant_Id_FK