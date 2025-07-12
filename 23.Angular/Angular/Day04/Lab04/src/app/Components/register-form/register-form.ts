import { CommonModule } from '@angular/common';
import { Component, Output, EventEmitter } from '@angular/core';
import { FormControl,FormGroup,  ReactiveFormsModule,Validators } from '@angular/forms';


@Component({
  selector: 'app-register-form',
  imports: [ReactiveFormsModule,CommonModule],
  templateUrl: './register-form.html',
  styleUrl: './register-form.css'
})
export class RegisterForm {

  userForm  = new FormGroup({
    name:new FormControl('',[Validators.required,Validators.minLength(3),Validators.pattern('^[a-zA-Z ]+$')]),
    age: new FormControl('',[Validators.required,Validators.min(18)]) ,
    email:new FormControl ('',[Validators.required,Validators.email]),
    address:new FormControl('',[Validators.required,Validators.pattern('^[A-Za-z0-9 ]+$')])
  });

  get getName(){
        return this.userForm.controls['name'];
  }
  get getAge(){
        return this.userForm.controls['age'];
  }
  get getEmail(){
        return this.userForm.controls['email'];
  }
  get getAddress(){
        return this.userForm.controls['address'];
  }


  @Output() emailData = new EventEmitter<any>() ;  
  @Output() reg = new EventEmitter<boolean>() ;  

  AddUser(){
    
    if(this.userForm.status=="VALID"){
      this.emailData.emit(this.userForm.value);
      this.reg.emit(true);
    }
    else{
      alert("Enter valid data")
    }
    
  }

}
