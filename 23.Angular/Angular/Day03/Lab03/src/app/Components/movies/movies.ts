import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Form } from "./form/form";

@Component({
  selector: 'app-movies',
  imports: [FormsModule, Form],
  templateUrl: './movies.html',
  styleUrl: './movies.css'
})


export class Movies {

  
  srchtxt:string ="";
  SelectedCategory:string="All";
  Movies : {name:string, desc:string, author:string, rate:string, file:string, category:string}[]=[];
  Categories: string[]=[]; 
  filterdMovies : {name:string, desc:string, author:string, rate:string, file:string, category:string}[]=this.Movies;
  
getMovies(data:any){
    this.Movies = data;
    this.filter();
    console.log(this.filterdMovies);
  }


getCateg(data:any) {
    this.Categories = data;
    // console.log(data);

  }

    filter(){
      console.log(this.srchtxt);
    this.filterdMovies =
    this.SelectedCategory=='All'?
    this.Movies
    :this.Movies.filter(
      (categ)=>
        categ.category.toLowerCase() == this.SelectedCategory.toLowerCase()    
    );
  }

  searchMovie(){
    if(this.srchtxt=="") this.filter();
    this.filterdMovies = this.Movies.filter(
      (txt)=>
        txt.name.toLowerCase().includes(this.srchtxt.toLowerCase())    
    );
  }

  remove(index: number) {
    console.log("ASDASDA");
    this.Movies.splice(index, 1);
    this.filter();
  }
  


}
