import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {RouterModule} from '@angular/router';
import { SharedModule } from '../../shared/shared.module';
import { MatTableModule } from '@angular/material/table';
import { DataTablesModule } from 'angular-datatables';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {MatDatepickerModule} from '@angular/material/datepicker'
import {MatFormFieldModule} from '@angular/material/form-field'

 



import { ReservationListComponent } from './reservation-list/reservation-list.component';
import { ReservationComponent} from '../reservation/reservation.component';
import { ReservationDetailsComponent } from './reservation-details/reservation-details.component';
import { ReservationUpdateComponent } from './reservation-update/reservation-update.component';
import { ReservationDeleteComponent } from './reservation-delete/reservation-delete.component';
import { ReservationCreateComponent } from './reservation-create/reservation-create.component';
import { MatListModule } from '@angular/material/list';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSidenavModule } from '@angular/material/sidenav';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RoutingModule } from 'src/app/routing/routing.module';
import { HttpClientModule } from '@angular/common/http';
import {MatInputModule} from '@angular/material/input'

import {MatPaginator, MatPaginatorModule} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';



@NgModule({
  declarations: [
    ReservationListComponent,
    ReservationComponent,
    ReservationDetailsComponent,
    ReservationUpdateComponent,
    ReservationDeleteComponent,
    ReservationCreateComponent,
    
  ],
  imports: [
    CommonModule,
    FormsModule,
    SharedModule,
    ReactiveFormsModule,
    HttpClientModule,  
    RoutingModule,
    BrowserAnimationsModule,
    MatSidenavModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    DataTablesModule,
    MatListModule,
    MatDatepickerModule,
    MatFormFieldModule,
    MatInputModule,
    MatPaginatorModule,
    MatTableModule,
    
    


    
    RouterModule.forChild([
      {path: 'list', component: ReservationListComponent},
      {path: 'create', component: ReservationCreateComponent},
      {path: 'update/:id', component: ReservationUpdateComponent},
      {path: 'details/id', component: ReservationDetailsComponent},
      {path: 'delete/:id', component: ReservationDeleteComponent}
    ]),
    
  ],
  exports: [
    MatTableModule,
    DataTablesModule,
    MatFormFieldModule,
    MatDatepickerModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatSidenavModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    DataTablesModule,
    MatListModule,
    MatDatepickerModule,
    MatFormFieldModule,

  ]
})
export class ReservationModule { }
