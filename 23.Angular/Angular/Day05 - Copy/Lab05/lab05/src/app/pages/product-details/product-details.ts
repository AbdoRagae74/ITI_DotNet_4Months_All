import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, RouterLink } from '@angular/router';
import { IProduct } from '../../models/iproduct';
import { StaticProductsService } from '../../services/static-products-service';
import { CurrencyPipe } from '@angular/common';

@Component({
  selector: 'app-product-details',
  imports: [CurrencyPipe,RouterLink],
  templateUrl: './product-details.html',
  styleUrl: './product-details.css'
})
export class ProductDetails implements OnInit {
  product!:IProduct|undefined;
  constructor(private activatedRoute:ActivatedRoute , private service:StaticProductsService) {
  }
  id?:string|null;
    ngOnInit(): void {
    this.id = this.activatedRoute.snapshot.paramMap.get('id');
    this.product = this.service.getProductById(this.id);
    console.log(this.product);    
}



}
