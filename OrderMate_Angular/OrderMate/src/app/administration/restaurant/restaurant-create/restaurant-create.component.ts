import { RestaurantStatus } from './../../../_interfaces/Administration/RestaurantStatus/restaurantstatus.model';
import { Component, OnInit } from '@angular/core'; 
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ErrorHandlerService } from './../../../shared/services/error-handler.service';
import { RepositoryService } from './../../../shared/services/repository.service';
import { Router } from '@angular/router';

import {CreateRestaurant} from '../../../_interfaces/Administration/Restaurant/restaurantcreate.model'

@Component({
  selector: 'app-restaurant-create',
  templateUrl: './restaurant-create.component.html',
  styleUrls: ['./restaurant-create.component.css']
})
export class RestaurantCreateComponent implements OnInit {
  public errorMessage: string = '';
 
  public restaurantForm: FormGroup; 

  Statuses : RestaurantStatus[];
  selectedStatus: RestaurantStatus;

  constructor( private errorHandler: ErrorHandlerService, private repository: RepositoryService,
    private router: Router ) { }

 ngOnInit(): void {
   this.getStatuses();
   this.restaurantForm = new FormGroup({
    restaurantName: new FormControl('',[Validators.required, Validators.maxLength(50)]),
    restaurantUrl: new FormControl('',[Validators.required, Validators.maxLength(50)]),
    restaurantDescription: new FormControl('',[Validators.required, Validators.maxLength(100)]),
    restaurantCoordinates: new FormControl('',[Validators.required, Validators.maxLength(50)]),
   // restaurantDateCreated: new FormControl('',[Validators.required, Validators.maxLength(50)]),
    restaurantAddressLine1: new FormControl('',[Validators.required, Validators.maxLength(100)]),
    restaurantAddressLine2: new FormControl('',[Validators.required, Validators.maxLength(100)]),
    restaurantCity: new FormControl('',[Validators.required, Validators.maxLength(50)]),
    restaurantProvince: new FormControl('',[Validators.required, Validators.maxLength(50)]),
    restaurantPostalCode: new FormControl('',[Validators.required, Validators.maxLength(50)]),
    restaurantCountry: new FormControl('',[Validators.required, Validators.maxLength(50)]),
    restaurantStatus: new FormControl('',[Validators.required]),
   });


  }


   public validateControl = (controlName: string) => {
    if (this.restaurantForm.controls[controlName].invalid && this.restaurantForm.controls[controlName].touched)
      return true;
 
    return false;
  }
 
  public hasError = (controlName: string, errorName: string) => {
    if (this.restaurantForm.controls[controlName].hasError(errorName))
      return true;
 
    return false;
  }
  getStatuses(){
    
    this.repository.getData("api/restaurantStatus")
      .subscribe(res => {
        this.Statuses = res as RestaurantStatus[];
 
      })
  }

  public createRestaurant = (RestaurantValue) => {
    if (this.restaurantForm.valid) {
      this.executeRestaurantCreation(RestaurantValue);
    }
  }
  private executeRestaurantCreation = (RestaurantValue) => {

    let [month, date, year]    = ( new Date() ).toLocaleDateString().split("/")
    if (month.length < 2) 
        month = '0' + month;
    if (date.length < 2) 
        date = '0' + date;
    var currentDate =  year + '-' + month +'-'+ date

    let id: number
 


        this.Statuses.forEach(x => {
          if(RestaurantValue.restaurantStatus == x.restaurantStatus1)
            id = x.restaurantStatusId
          
          })
      

    

  
    const restaurant: CreateRestaurant = {
      restaurantName: RestaurantValue.restaurantName,
      restaurantUrl: RestaurantValue.restaurantUrl,
      restaurantDescription: RestaurantValue.restaurantDescription,
      restaurantCoordinates: RestaurantValue.restaurantCoordinates,
      restaurantDateCreated: currentDate,
      restaurantAddressLine1: RestaurantValue.restaurantAddressLine1,
      restaurantAddressLine2: RestaurantValue.restaurantAddressLine2,
    
      restaurantCity: RestaurantValue.restaurantCity,
      restaurantPostalCode: RestaurantValue.restaurantPostalCode,
      restaurantCountry: RestaurantValue.restaurantCountry,
      restaurantProvince: RestaurantValue.restaurantProvince,
      RestaurantStatusIdFk: id,
    }
    console.log('restaurant',restaurant)
    
    const apiUrl = 'api/restaurant';
    this.repository.create(apiUrl, restaurant)
      .subscribe(res => {
        $('#successModal').modal();
      },
      (error => {
        this.errorHandler.handleError(error);
        this.errorMessage = this.errorHandler.errorMessage;
      })
    )
    
  }
  
  
  
  public redirectTorestaurantList(){
    this.router.navigate(['/restaurant/list']);
  }
  

 } 

 

