// import { Component } from '@angular/core';
// import { FormsModule } from '@angular/forms';

// @Component({
//   selector: 'app-movie-task',
//   imports: [FormsModule],
//   templateUrl: './movie-task.html',
//   styleUrl: './movie-task.css'
// })
// export class MovieTask {
//   Name:string="";
//   Desc:string="";
//   Author:string="";
//   Rate:number=0;
//   File:string="";
//   Category:string="";
//   SelectedCategory:string="All";
//   srchtxt:string ="";
//   Movies : {Name:string , Desc:string , author:string , Rate:number , File:string , Category:string}[]=[];

//   Categories: string[]=[]; 
//     Add(){
//     this.Movies.push(
//       {
//         Name:this.Name,
//         Rate:this.Rate,
//         Desc:this.Desc,
//         author:this.Author,
//         File:this.File,
//         Category:this.Category.toLowerCase()
//       }  
//     )
//     if(!this.Categories.includes(this.Category.toLowerCase()) ) {
//       this.Categories.push(this.Category.toLowerCase())
//     }
//     this.SelectedCategory="All";
//     this.filter();
//   }

//   filterdMovies : {Name:string , Desc:string , author:string , Rate:number , File:string , Category:string}[]=[];

//   filter(){
//     this.filterdMovies =
//     this.SelectedCategory=='All'?
//     this.Movies
//     :this.Movies.filter(
//       (categ)=>
//         categ.Category.toLowerCase() == this.SelectedCategory.toLowerCase()    
//     );
//   }

//   searchMovie(){
//     if(this.srchtxt=="") this.filter();
//     this.filterdMovies = this.Movies.filter(
//       (txt)=>
//         txt.Name.toLowerCase().includes(this.srchtxt.toLowerCase())    
//     );
//   }

//   remove(index: number) {
  
//     this.Movies.splice(index, 1);
//     this.filter();
//   }
// }
