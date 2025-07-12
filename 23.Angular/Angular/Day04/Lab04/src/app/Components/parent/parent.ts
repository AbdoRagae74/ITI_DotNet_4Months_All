import { Component } from '@angular/core';
import { RegisterForm } from "../register-form/register-form";
import { Profile } from "../profile/profile";

@Component({
  selector: 'app-parent',
  imports: [RegisterForm, Profile],
  templateUrl: './parent.html',
  styleUrl: './parent.css'
})
export class Parent {

userdata: { name: string; age: string; address: string; email: string } = {
  name: '',
  age: '',
  address: '',
  email: '',
};
flag : boolean = false;
getData(data:any){
    this.userdata.name = data.name;
    this.userdata.age = data.age;
    this.userdata.address = data.address;
    this.userdata.email = data.email;
    this.flag = true;
    console.log(this.userdata);
    console.log(this.flag)
  }

  logout(data:boolean){
    console.log(data);
    this.flag=false;
  }
}
