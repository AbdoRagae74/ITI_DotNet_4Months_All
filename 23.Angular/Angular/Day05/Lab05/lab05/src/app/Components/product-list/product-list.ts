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
export class ProductList implements OnInit {
ngOnInit(): void {
  this.products = this.prodService.getAllProducts();
  
}
@Input() srchdata="";
products:IProduct[] =[];

constructor(private prodService:StaticProductsService) {}

deleteProduct(id:string){
  this.products = this.products.filter(p=>p.id!=id);
  this.prodService.deleteProduct(id);
}


}
