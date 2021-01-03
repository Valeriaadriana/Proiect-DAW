import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {ViewProductsComponent} from './products/view-products/view-products.component';
import {ViewProductTypesComponent} from "./product-types/view-product-types/view-product-types.component";
import {CreateProductTypeComponent} from './product-types/create-product-type/create-product-type.component';
import {FormsModule} from "@angular/forms";
import {CreateProductComponent} from "./products/create-product/create-product.component";
import {ProductService} from "./products/product.service";
import {ProductTypeService} from "./product-types/product-type.service";
import {BooleanPipe} from "./boolean.pipe";
import {LoginComponent} from "./login/login.component";
import {RegisterComponent} from "./register/register.component";

@NgModule({
  declarations: [BooleanPipe, ViewProductsComponent, ViewProductTypesComponent, CreateProductTypeComponent, CreateProductComponent, LoginComponent, RegisterComponent],
  imports: [
    CommonModule,
    FormsModule,
  ],
  providers: [ProductService, ProductTypeService],
  exports: [BooleanPipe, ViewProductsComponent, ViewProductTypesComponent, CreateProductTypeComponent, CreateProductComponent, LoginComponent, RegisterComponent]
})
export class ShopModule { }
