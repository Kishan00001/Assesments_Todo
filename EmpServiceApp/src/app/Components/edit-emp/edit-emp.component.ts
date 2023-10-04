import { Component } from '@angular/core';
import { ActivatedRoute,ParamMap,Router } from '@angular/router';
import { Employee } from 'src/app/Models/employee';
import { EmployeeService } from 'src/app/Services/employee-service.service';

@Component({
  selector: 'app-edit-emp',
  templateUrl: './edit-emp.component.html',
  styleUrls: ['./edit-emp.component.css']
})

export class EditEmpComponent {  
   updEmp : Employee = {} as Employee;
   
   constructor(private myService : EmployeeService, private router : Router,private activatedRoute : ActivatedRoute) {     }
  
   ngOnInit(): void {
  
    this.activatedRoute.paramMap.subscribe((parameters : ParamMap) =>{
      this.updEmp.empId = parseInt(parameters.get("id")!);
      this.myService.getEmployee(this.updEmp.empId).subscribe((data: Employee)=>{
        this.updEmp = data
      })
    })

  }

   onUpdateEmp(){
    const file = this.updEmp.imageFile;
      if(file.includes("assets/images/")){
        file.replace("assets/images/","")
        this.updEmp.imageFile.replace("assets/images/","");
      }
      else
        this.updEmp.imageFile = "assets/images/" + file;
      
      this.myService.updateEmployee(this.updEmp).subscribe((emp)=>{
      });
      alert("Employee Updated successfully");
      this.router.navigate(['/']);   
   }
}
