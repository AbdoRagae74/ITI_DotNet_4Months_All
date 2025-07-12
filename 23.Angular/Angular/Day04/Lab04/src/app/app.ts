import { Component } from '@angular/core';
import { RegisterForm } from "./Components/register-form/register-form";
import { Parent } from "./Components/parent/parent";

@Component({
  selector: 'app-root',
  imports: [ Parent],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'Lab02';
}
