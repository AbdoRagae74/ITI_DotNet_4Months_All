import { Injectable } from '@angular/core';
import { IProduct } from '../models/iproduct';
import { from } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StaticProductsService {

  products :IProduct[] = [];
  maxID:number=0;
  constructor() {
this.products = [
      {
        id: '1',
        name: 'Book',
        price: 200,
        quantity: 20,
      },
      {
        id: '2',
        name: 'Pen',
        price: 100,
        quantity: 60,
      },
      {
        id: '3',
        name: 'watch',
        price: 60,
        quantity: 60,
      },
    ];
   }
     getAllProducts(): IProduct[] {
    return this.products;
  }

  getProductById(productId: string | null): IProduct | undefined {
    return this.products.find((product) => product.id == productId);
  }

  addNewProduct(product: any): IProduct[] {
    this.products.push(product);
    return this.products;
  }
  deleteProduct(productId: string | null) {
    this.products = this.products.filter(x=>x.id!=productId);
  }
  fromList?:IProduct;
  updateProduct(toEdit:IProduct) {
     this.fromList = this.products.find(x=>x.id == toEdit.id);
      if(this.fromList)
     {
      this.fromList.name = toEdit.name;  
      this.fromList.price = toEdit.price;  
      this.fromList.quantity = toEdit.quantity;
    } 
  }
  getNextID(){
    return Math.max(...this.products.map(p=> Number(p.id)));
  }
}
