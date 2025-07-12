import { Component } from '@angular/core';
import { ProductTop } from "../../Components/product-top/product-top";
import { ProductList } from "../../Components/product-list/product-list";

@Component({
  selector: 'app-products',
  imports: [ProductTop, ProductList],
  templateUrl: './products.html',
  styleUrl: './products.css'
})
export class Products {

  srchval:string="";

  getx(data:string){

    this.srchval = data;
  }

}
