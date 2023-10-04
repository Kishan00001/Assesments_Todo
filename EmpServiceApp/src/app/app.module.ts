import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EmpMgrComponent } from './Components/emp-mgr/emp-mgr.component';
import { NavBarComponent } from './Components/nav-bar/nav-bar.component';
import { ViewEmpComponent } from './Components/view-emp/view-emp.component';
import { EditEmpComponent } from './Components/edit-emp/edit-emp.component';
import { AddEmpComponent } from './Components/add-emp/add-emp.component';
import { HttpClientModule } from '@angular/common/http';
import { SearchPipe } from './Pipes/search.pipe';
import { SortPipe } from './Pipes/sort.pipe';
import { TemplateComponent } from './Components/template/template.component';
import { ReactiveFormsComponent } from './Components/reactive-forms/reactive-forms.component';
import { AdminRoutingModule } from './Modules/admin/admin-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    EmpMgrComponent,
    NavBarComponent,
    ViewEmpComponent,
    EditEmpComponent,
    AddEmpComponent,
    SearchPipe,
    SortPipe,
    TemplateComponent,
    ReactiveFormsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule,
    AdminRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
