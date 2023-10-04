import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from 'src/app/Models/employee';
import { EmployeeService } from 'src/app/Services/employee-service.service';

@Component({
  selector: 'app-emp-mgr',
  templateUrl: './emp-mgr.component.html',
  styleUrls: ['./emp-mgr.component.css']
})
export class EmpMgrComponent implements OnInit{
  empList : Employee[] = [];
  
  searchByName :string = "";

  sortOrder:string = "";

  constructor(private myService : EmployeeService, private router : Router) {

  }
  ngOnInit(): void {
    this.myService.getAllEmployees().subscribe((data : Employee[])=>{
      this.empList = data
    })
  }

  onDelete(id : number){
    this.myService.deleteEmployee(id).subscribe(data=>{
      alert(data);
      this.router.navigate(["/"]);
    })
  }

  onUpdate(id:number){
  const emp = this.empList.find(e=>e.empId==id)!;
    this.myService.updateEmployee(emp).subscribe(data=>{
      alert(emp);
      // this.router.navigate(["/"]);
    }) 
  }
}