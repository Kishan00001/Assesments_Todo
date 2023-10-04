import { Pipe, PipeTransform } from '@angular/core';
import { Employee } from '../Models/employee';

@Pipe({
  name: 'sort'
})
export class SortPipe implements PipeTransform {

  transform(inputs:Employee[] ,order:string): Employee[]{
    if(order=="atoz")
      return inputs.sort((a,b) => a.empName.localeCompare(b.empName));
    else if(order=="ztoa"){
      return inputs.sort((a,b) => a.empName.localeCompare(b.empName)).reverse();
    }  
    else if(order==""){
      return inputs;
    }
    else{
      return inputs;
    }
  }
}
