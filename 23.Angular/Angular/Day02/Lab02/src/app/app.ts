import { Component } from '@angular/core';
import { MovieTask } from "./Components/movie-task/movie-task";

@Component({
  selector: 'app-root',
  imports: [ MovieTask],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'Lab02';
}
