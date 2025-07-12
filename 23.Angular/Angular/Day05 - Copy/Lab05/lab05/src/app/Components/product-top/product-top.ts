import { Component, Output,EventEmitter } from '@angular/core';
import { RouterLink } from '@angular/router';
import { StaticProductsService } from '../../services/static-products-service';


@Component({
  selector: 'app-product-top',
  imports: [RouterLink],
  templateUrl: './product-top.html',
  styleUrl: './product-top.css'
})
export class ProductTop {

  constructor(serv:StaticProductsService) {
        
  }
  @Output() srch = new EventEmitter<string>() ;  
search(data:string){

  this.srch.emit(data);
}

}
