import {Reservation} from '../../../_interfaces/Reservationmanage/Reservation/reservation.model'

export interface CreateSeating {
   
    seatingDate:Date; 
   
    reservation: Reservation;
}