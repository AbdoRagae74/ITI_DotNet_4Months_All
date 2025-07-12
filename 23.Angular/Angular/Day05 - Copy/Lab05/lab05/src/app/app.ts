import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Navbar } from "./Components/Layout/navbar";
import { ProductForm } from "./pages/product-form/product-form";


@Component({
  selector: 'app-root',
  imports: [Navbar, RouterOutlet, ProductForm],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'lab05';
}
