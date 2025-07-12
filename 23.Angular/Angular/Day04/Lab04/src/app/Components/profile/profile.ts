import { Component,Input, Output,EventEmitter } from '@angular/core';

@Component({
  selector: 'app-profile',
  imports: [],
  templateUrl: './profile.html',
  styleUrl: './profile.css'
})
export class Profile {

  @Input() data : { name: string; age: string; address: string; email: string } = {
  name: '',
  age: '',
  address: '',
  email: ''
}; 

@Output() reg = new EventEmitter<boolean>() ;

profileout(){
  this.reg.emit(false);
}  



}
