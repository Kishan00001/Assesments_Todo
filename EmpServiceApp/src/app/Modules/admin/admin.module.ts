import { NgModule } from '@angular/core';

import { DashboardComponent } from 'src/app/Components/dashboard/dashboard.component';
import { UserComponent } from 'src/app/Components/user/user.component';
import { RightsComponent } from 'src/app/Components/rights/rights.component';
import { AdminRoutingModule } from './admin-routing.module';



@NgModule({
  declarations: [
    DashboardComponent,
    RightsComponent,
    UserComponent
  ],
  imports: [
    AdminRoutingModule
  ]
})
export class AdminModule { }
