import { Component, ElementRef, OnInit,ViewChild } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ErrorHandlerService } from '../../../shared/services/error-handler.service';
import { RepositoryService } from '../../../shared/services/repository.service';
import { Router } from '@angular/router';
import { DatePipe} from '@angular/common'

import {CreateReservation} from '../../../_interfaces/Reservationmanage/Reservation/reservationcreate.model'
import {ReservationStatus} from '../../../_interfaces/Reservationmanage/ReservationStatus/reservationstatus.model';


import { User } from 'src/app/_interfaces/UserManage/User/user.model';

@Component({
  selector: 'app-reservation-create',
  templateUrl: './reservation-create.component.html',
  styleUrls: ['./reservation-create.component.css']
})
export class ReservationCreateComponent implements OnInit {

  public statuses: ReservationStatus[];
  public errorMessage: string = '';
  selectedStatus: ReservationStatus;
  selectedUser: User;
  public users: User[];
  todayDate = Date.now();

  
   
  public reservationForm: FormGroup; 

  constructor( private errorHandler: ErrorHandlerService, private repository: RepositoryService,
    private router: Router ) { }

    
   

 ngOnInit(): void {
  
  StartDate()
  

  this.getStatus();
  this.getUsers();
  

  this.reservationForm = new FormGroup({
    reservationDateReserved: new FormControl(''),
    reservationPartyQty: new FormControl('',[Validators.required, Validators.maxLength(2)]),
    reservationStatusName: new FormControl('',[Validators.required]),
    reservationNumberOfBills: new FormControl('',[Validators.required, Validators.maxLength(2)]),
    user: new FormControl('',[Validators.required])

  });
  

  }

  public validateControl = (controlName: string) => {
    if (this.reservationForm.controls[controlName].invalid && this.reservationForm.controls[controlName].touched)
      return true;
 
    return false;
  }
 
  public hasError = (controlName: string, errorName: string) => {
    if (this.reservationForm.controls[controlName].hasError(errorName))
      return true;
 
    return false;
  }

  getStatus(){
    let apiAddress: string = "api/reservationstatus";
      this.repository.getData(apiAddress)
      .subscribe(res => { 
        this.statuses = res as ReservationStatus[];
      });
  }

  getUsers(){

    let apiAddress: string = "api/user";
      this.repository.getData(apiAddress)
      .subscribe(res => { 
        this.users = res as User[];
        console.log('users', this.users) 
      });
  }



  public create = (Value) => {
    if (this.reservationForm.valid) {

      


      this.executeCreation(Value);
    }
  }

  private executeCreation = (Value) => {

    let [month, date, year]    = ( new Date() ).toLocaleDateString().split("/")
    if (month.length < 2) 
        month = '0' + month;
    if (date.length < 2) 
        date = '0' + date;
    var currentDate =  year + '-' + month +'-'+ date

    let userId: string;
    let status: number;

    this.getUsers();

    for(let x of this.users){
      if(Value.user == x.userName )
      userId = x.id
    }
   
    for(let x of this.statuses){
      if(Value.reservationStatusName == x.reservationStatus1){
        status = x.reservationStatusId
      }
    }
    let qty:number;
    qty= Value.reservationPartyQty
    let qty2 = parseInt(Value.reservationPartyQty)
    let nob:number;
    nob = parseInt(Value.reservationNumberOfBills)






    //this line retrieves it from the html    
    var dater = (<HTMLInputElement>document.getElementById("reservationDateReserved")).value

  
    const reservation: CreateReservation = {

      reservationStatusName :Value.reservationStatusName,
      reservationDateCreated : currentDate,
      reservationDateReserved : dater,
      reservationPartyQty : qty2,
      reservationNumberOfBills : nob ,
      reservationStatusIdFk: status, 
      userIdFk: userId,
  
    }
   
  
    const apiUrl = 'api/reservation';
    
    this.repository.create(apiUrl, reservation)
      .subscribe(res => {
        $('#successModal').modal();
      },
      (error => {
        this.errorHandler.handleError(error);
        this.errorMessage = this.errorHandler.errorMessage;
      })
    )
    
  }
  public redirectToList(){
    this.router.navigate(['/reservation/list']);
  }

}

function StartDate() {
  $('#reservationDateReserved').datepicker({ 
    minDate: new Date(),
    dateFormat : "yy-mm-dd"
});

}

