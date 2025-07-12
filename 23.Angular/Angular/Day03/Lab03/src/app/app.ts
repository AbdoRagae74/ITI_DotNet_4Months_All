import { Component, input } from '@angular/core';
import { Movies } from "./Components/movies/movies";
import { InputTask } from "./Components/input-task/input-task";
import { HomeTask } from "./Components/home-task/home-task";




@Component({
  selector: 'app-root',
  imports: [Movies, InputTask, HomeTask],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'Lab02';
  home:boolean = true;
  movies:boolean = false;
  iinput:boolean = false;

  showHome(){
    this.home = true;
    this.movies = false;
    this.iinput = false;
  }
  showMovies(){
    this.home = false;
    this.movies = true;
    this.iinput = false;
  }
  showInput(){
    this.home = false;
    this.movies = false;
    this.iinput = true;
  }


}
