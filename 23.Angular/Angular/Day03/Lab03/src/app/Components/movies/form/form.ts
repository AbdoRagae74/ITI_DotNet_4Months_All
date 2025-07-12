import { Component, Output,EventEmitter } from '@angular/core';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-form',
  imports: [FormsModule],
  templateUrl: './form.html',
  styleUrl: './form.css'
})



export class Form {

    @Output() allMovies = new EventEmitter();
    @Output() allCateg = new EventEmitter();

  movies:{name:string, desc:string, author:string, rate:string, file:string, category:string}[]=[];
  categories:Array<string> = [];
  Add(name:string, desc:string, author:string, rate:string, file:string, category:string){    
   this.movies.push({name, desc, author, rate, file, category});
     if (!this.categories.includes(category)) {
      this.categories.push(category);
      this.allCateg.emit(this.categories);
    }
      this.allMovies.emit(this.movies);
  }



}
