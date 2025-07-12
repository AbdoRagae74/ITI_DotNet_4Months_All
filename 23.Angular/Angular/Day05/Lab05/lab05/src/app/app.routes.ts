import { Routes } from '@angular/router';
import { Home } from './pages/home/home';
import { Products } from './pages/products/products';
import { ProductDetails } from './pages/product-details/product-details';
import { Account } from './pages/account/account';
import { Component } from '@angular/core';
import { Login } from './Components/login/login';
import { register } from 'module';
import { Register } from './Components/register/register';
import { Notfound } from './pages/notfound/notfound';
import { ProductForm } from './pages/product-form/product-form';

export const routes: Routes = [

    {path:'',redirectTo:'home',pathMatch:'full'   },
    {path:'home',component:Home   },
    {path:'products',component:Products   },
    {path:'products/:id',component:ProductDetails   },
    { path: 'products/:id/edit', component: ProductForm },
    { path: 'products/add/new', component: ProductForm },
    {path:'account',component:Account,   
        children:[
            {path:"",redirectTo:'login',pathMatch:'full'},    
            {path:"login",component:Login},
            {path:"register",component:Register},
            
        ]



    },
    { path: '**', component: Notfound },



];
