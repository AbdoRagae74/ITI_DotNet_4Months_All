import { Component, OnInit,Input, OnChanges, SimpleChanges } from '@angular/core';
import { RouterLink } from '@angular/router';
import { IProduct } from '../../models/iproduct';
import { StaticProductsService } from '../../services/static-products-service';
import { CurrencyPipe } from '@angular/common';

@Component({
  selector: 'app-product-list',
  imports: [RouterLink,CurrencyPipe],
  templateUrl: './product-list.html',
  styleUrl: './product-list.css'
})
export class ProductList implements OnInit,OnChanges {
ngOnInit(): void {
  this.products = this.prodService.getAllProducts();
  this.filteredProducts = this.products;
}
@Input() srchdata="";
products:IProduct[] =[];
filteredProducts!:IProduct[] ;

constructor(private prodService:StaticProductsService) {}
  ngOnChanges(changes: SimpleChanges): void {
    if(this.srchdata=='')
      this.filteredProducts = this.products;
    else
    {this.filteredProducts = this.products.filter(p=>p.name.toLowerCase().includes(this.srchdata.toLowerCase()));  console.log(this.srchdata)}
  }

deleteProduct(id:string){
  this.products = this.products.filter(p=>p.id!=id);
  this.prodService.deleteProduct(id);
}


}
