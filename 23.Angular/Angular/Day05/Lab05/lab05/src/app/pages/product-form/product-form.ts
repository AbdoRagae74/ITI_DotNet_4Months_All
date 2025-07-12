import { CommonModule } from '@angular/common';
import { AfterViewInit, Component, OnInit } from '@angular/core';
import {
  FormControl,
  FormGroup,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
// import { StaticProductService } from '../../services/static-product-service';
import { ActivatedRoute, Router } from '@angular/router';
import { IProduct } from '../../models/iproduct';
import { StaticProductsService } from '../../services/static-products-service';

@Component({
  selector: 'app-product-form',
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './product-form.html',
  styleUrl: './product-form.css',
})
export class ProductForm implements OnInit  {
  constructor(
    private productService: StaticProductsService,
    private router: Router,private activatedroute:ActivatedRoute
  ) {}

  id?:string|null;
  toEdit? : IProduct;
   productForm!: FormGroup;

  ngOnInit(): void {
    this.id = this.activatedroute.snapshot.paramMap.get('id');
    console.log(this.id);
    if(this.id!='add')
    {
      this.toEdit = this.productService.getProductById(this.id);
    
    this.productForm = new FormGroup({
    name: new FormControl(this.id==null ?'' : this.toEdit?.name, [Validators.required, Validators.minLength(3)]),
    price: new FormControl(this.id==null ?'' : this.toEdit?.price, Validators.required),
    quantity: new FormControl(this.id==null ?'' : this.toEdit?.quantity, Validators.required),
  });
}
else{
    this.productForm = new FormGroup({
    name: new FormControl('', [Validators.required, Validators.minLength(3)]),
    price: new FormControl('', Validators.required),
    quantity: new FormControl('', Validators.required),
  });
}

  }


  get getName() {
    return this.productForm.controls['name'];
  }
  get getPrice() {
    return this.productForm.controls['price'];
  }
  get getQuantity() {
    return this.productForm.controls['quantity'];
  }
  addNewProduct() {
    if (this.productForm.status == 'VALID') {
      const id = (this.productService.getNextID()+1).toString();
      let product = { id, ...this.productForm.value };
      this.productService.addNewProduct(product);
      this.router.navigate(['/products']);
    } else {
      console.log('Fix Errors');
  }
}
p!:IProduct;
updateCurrentProduct(){
if (this.productForm.status == 'VALID') {
     this.p=
     {id:this.id!
      ,name:this.productForm.value.name,
      price:this.productForm.value.price,
      quantity:this.productForm.value.quantity}; 
      console.log(this.p);
      this.productService.updateProduct(this.p);
      this.router.navigate(['/products']);
    } else {
      console.log('Fix Errors');
  }
    }

    handleFormButton(){
    if(this.id==null) this.addNewProduct();
    else this.updateCurrentProduct();
    }
  }

