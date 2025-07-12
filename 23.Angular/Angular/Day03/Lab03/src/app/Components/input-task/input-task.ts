import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-input-task',
  imports: [FormsModule],
  templateUrl: './input-task.html',
  styleUrl: './input-task.css'
})
export class InputTask {
value:string="";
  upper (val:string){
    this.value = val.toUpperCase();
  }
}
