import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';
import { DataTableDirective } from 'angular-datatables';
import { Subject } from 'rxjs';
import { ErrorHandlerService } from 'src/app/shared/services/error-handler.service';
import { RepositoryService } from 'src/app/shared/services/repository.service';
import { Reservation } from 'src/app/_interfaces/Reservationmanage/Reservation/reservation.model';
import { ReservationStatus } from 'src/app/_interfaces/Reservationmanage/ReservationStatus/reservationstatus.model';
import { User } from 'src/app/_interfaces/UserManage/User/user.model';


@Component({
  selector: 'app-reservation-list',
  templateUrl: './reservation-list.component.html',
  styleUrls: ['./reservation-list.component.css']
})
export class ReservationListComponent implements OnInit, AfterViewInit {
  public users : User[];
  public reservationsFromServer: Reservation[];
  reservations:Reservation[];
  xreservations:Reservation[];
  public statuses: ReservationStatus[];

  public errorMessage: string = '';
  dtTrigger: Subject<any>  =  new Subject();
  @ViewChild(DataTableDirective, {static: false})
  datatableElement: DataTableDirective;
  min:number;
  max:number;

  displayedColumns: string[] = ['id','dateCreated','dateReserved','partyQuantity','reservationStatus','reservationNumberOfBills','actions']
  dataSource: MatTableDataSource<Reservation>;

  @ViewChild(MatPaginator,{static:true}) paginator: MatPaginator;
  @ViewChild(MatSort,{static:true}) sort: MatSort;

  constructor(private repository :  RepositoryService, private errorHandler: ErrorHandlerService, 
    private router: Router) { }

    ngAfterViewInit() {
      // this.dataSource.paginator = this.paginator;
      // this.dataSource.sort = this.sort;
    }
  

    ngOnInit(): void {

      let apiAddress: string = "api/reservation";
      this.repository.getData(apiAddress)
        .subscribe(res => {
          this.reservationsFromServer = res as Reservation[];

          //iterate through the list, for each statusId find match in status list and retrive status name
          this.reservations =[];
          this.reservationsFromServer.forEach(resevation=>{
            //formet date here
            //call method and pass reservation here
            let apiAddress: string = "api/reservationstatus";
              this.repository.getData(apiAddress)
                .subscribe(res => {
                  this.statuses = res as ReservationStatus[];
                  this.statuses.forEach(status=>{
                    if(resevation.reservationStatusIdFk == status.reservationStatusId){
                      //match found              
                      resevation.reservationStatusName = status.reservationStatus1;
                      this.reservations.push(resevation);

                      //this is problem
                      this.dataSource = new MatTableDataSource(this.reservations)
                      this.dataSource.paginator = this.paginator;
                      this.dataSource.sort = this.sort;               
                   
                    }
                  })
            });
       
          })
 
        });
        
    } 


    applyFilter(event: Event){
      const filterValue = (event.target as HTMLInputElement).value;
      this.dataSource.filter = filterValue.trim().toLowerCase();

      if(this.dataSource.paginator){
        this.dataSource.paginator.firstPage();
      }
    }







  public getDetails = (reservationId) => { 
    const detailsUrl: string = '/reservation/details/' + reservationId; 
    this.router.navigate([detailsUrl]); 
  }
  
  public redirectToUpdatePage = (reservationId) => { 
    const updateUrl: string = '/reservation/update/' + reservationId; 
    this.router.navigate([updateUrl]); 
  }

  public redirectToDeletePage = (reservationId) => { 
    const deleteUrl: string = '/reservation/delete/' + reservationId; 
    this.router.navigate([deleteUrl]);  
  }

}
