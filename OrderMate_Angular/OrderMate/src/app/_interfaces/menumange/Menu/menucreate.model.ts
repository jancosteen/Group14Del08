import {Restaurant} from '../../../_interfaces/Administration/Restaurant/restaurant.model'

export interface CreateMenu {

    menuName:string,
    menuDescription:string,
    menuDateCreated:string,
    menuTimeActiveFrom:Date,
    menuTimeActiveTo:Date,
   // restaurant: Restaurant
 
}