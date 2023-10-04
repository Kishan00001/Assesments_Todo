import { Pipe, PipeTransform } from '@angular/core';
import { Employee } from '../Models/employee';

@Pipe({
  name: 'search'
})
export class SearchPipe implements PipeTransform {

  transform(inputs:Employee[] ,name:string): Employee[]{
    if(name=="")
      return inputs;
    else{
      return inputs.filter(e=>e.empName.toUpperCase().includes(name.toUpperCase()))
    }  
  }

}
