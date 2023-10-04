import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Employee } from 'src/app/Models/employee';
import { EmployeeService } from 'src/app/Services/employee-service.service';

@Component({
  selector: 'app-reactive-forms',
  templateUrl: './reactive-forms.component.html',
  styleUrls: ['./reactive-forms.component.css']
})
export class ReactiveFormsComponent {
  title: string = "Reactive Forms Demo";
  emp: Employee = {} as Employee;
  empForm : FormGroup = new FormGroup({
    empId: new FormControl(0,[Validators.required,Validators.min(100),Validators.max(200)]),//0 is initial value
    empName: new FormControl("",[Validators.required]),
    emailAddress: new FormControl("",[Validators.required,Validators.email]),
    phoneNo: new FormControl(0,[Validators.required,Validators.min(1000000000),Validators.max(9999999999),Validators.minLength(10),Validators.maxLength(10)]),
    imageFile: new FormControl("Image File Here",[Validators.required])
  })

  get empId(){
    return this.empForm.get("empId")
  }

  get empName(){
    return this.empForm.get("EmpName")
  }

  get emailAddress(){
    return this.empForm.get("emailAddress")
  }

  get phoneNo(){
    return this.empForm.get("phoneNo")
  }

  get imageFile(){
    return this.empForm.get("imageFile");
  }
  constructor(private empService:EmployeeService,private router:Router){

  }

  onSubmit(){
    this.emp = {
      // empId : this.empId?.value,
      empName: this.empName?.value,
      emailAddress: this.emailAddress?.value,
      phoneNo: this.phoneNo?.value,
      imageFile:this.imageFile?.value
    } as Employee;
    this.empService.addEmployee(this.emp).subscribe((e)=>{
      alert("Employee added successfully");
      this.router.navigate(["/"]);
    })
  }
  

}
