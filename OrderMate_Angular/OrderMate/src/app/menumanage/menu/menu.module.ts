import { MatListModule } from '@angular/material/list';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatIconModule } from '@angular/material/icon';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSidenavModule } from '@angular/material/sidenav';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { SharedModule } from './../../shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MenuListComponent } from './menu-list/menu-list.component';
import { MenuDetailsComponent } from './menu-details/menu-details.component';
import { MenuDeleteComponent } from './menu-delete/menu-delete.component';
import { MenuCreateComponent } from './menu-create/menu-create.component';
import { MenuUpdateComponent } from './menu-update/menu-update.component';
import { BrowserModule } from '@angular/platform-browser';
//import { ItemsMenuComponent } from './menuitems/menuitems.component';
import { MenuitemsComponent } from './menuitems/menuitems.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatNativeDateModule } from '@angular/material/core';
import { MatButtonModule } from '@angular/material/button';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: 
  [ 
    
    MenuListComponent, 
    MenuDetailsComponent, 
    MenuDeleteComponent,      
    MenuCreateComponent,
    MenuUpdateComponent,
  //  ItemsMenuComponent,
    MenuitemsComponent],
  imports: [
    CommonModule,
      SharedModule,
      ReactiveFormsModule,
      DataTablesModule,
      RouterModule.forChild([
        {path: 'list', component: MenuListComponent},
        {path: 'details/:id', component: MenuDetailsComponent},
        {path: 'create', component: MenuCreateComponent},
        {path: 'delete/:id', component: MenuDeleteComponent},
        {path: 'update/:id', component: MenuUpdateComponent}
      
    ])
    ]
})
export class MenuModule { }
