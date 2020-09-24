import { RestaurantStatus } from "../RestaurantStatus/restaurantstatus.model";

export interface Restaurant{
    restaurantId:number;
    restaurantName:string;
    restaurantUrl:string;
    restaurantDescription:string;
    restaurantCoordinates:string;
    restaurantDateCreated:string;
    restaurantAddressLine1:string;
    restaurantAddressLine2:string;

    restaurantCity:string;
    restaurantPostalCode:string;
    restaurantProvince:string;
    restaurantCountry:string;
    RestaurantStatusIdFk?: number;
}