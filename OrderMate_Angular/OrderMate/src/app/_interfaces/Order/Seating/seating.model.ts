import {Reservation} from '../../../_interfaces/Reservationmanage/Reservation/reservation.model'

export interface Seating {

    seatingId:number;
    seatingDate:Date; 

    reservation: Reservation; 
}  