import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {FormsModule} from '@angular/forms';
import {HTTP_INTERCEPTORS, HttpClientModule} from '@angular/common/http';
import {RouterModule} from '@angular/router';

import {AppComponent} from './app.component';
import {NavMenuComponent} from './nav-menu/nav-menu.component';
import {ViewProductsComponent} from "./shop/products/view-products/view-products.component";
import {ShopModule} from "./shop/shop.module";
import {CreateProductTypeComponent} from "./shop/product-types/create-product-type/create-product-type.component";
import {ViewProductTypesComponent} from "./shop/product-types/view-product-types/view-product-types.component";
import {CreateProductComponent} from "./shop/products/create-product/create-product.component";
import {ViewDeliveryTypesComponent} from "./order/delivery-types/view-delivery-types/view-delivery-types.component";
import {CreateDeliveryTypeComponent} from "./order/delivery-types/create-delivery-type/create-delivery-type.component";
import {OrderModule} from "./order/order.module";
import {AuthService} from "./auth.service";
import {Interceptor} from "./HttpInterceptor";
import {AuthGuard} from "./auth.guard";
import {LoginComponent} from "./shop/login/login.component";
import {RegisterComponent} from "./shop/register/register.component";
import {CreateOrderComponent} from "./order/orders/create-order/create-order.component";
import {ViewOrdersComponent} from "./order/orders/view-orders/view-orders.component";

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({appId: 'ng-cli-universal'}),
    HttpClientModule,
    FormsModule,
    ShopModule,
    OrderModule,
    RouterModule.forRoot([
      {path: '', component: ViewProductsComponent, pathMatch: 'full', canActivate: [AuthGuard]},
      {path: 'login', component: LoginComponent, pathMatch: 'full'},
      {path: 'register', component: RegisterComponent, pathMatch: 'full'},
      {path: 'view-products', component: ViewProductsComponent, pathMatch: 'full', canActivate: [AuthGuard]},
      {path: 'create-product', component: CreateProductComponent, pathMatch: 'full', canActivate: [AuthGuard]},
      {path: 'view-product-types', component: ViewProductTypesComponent, pathMatch: 'full', canActivate: [AuthGuard]},
      {path: 'create-product-type', component: CreateProductTypeComponent, pathMatch: 'full', canActivate: [AuthGuard]},
      {path: 'view-delivery-types', component: ViewDeliveryTypesComponent, pathMatch: 'full', canActivate: [AuthGuard]},
      {path: 'create-delivery-type', component: CreateDeliveryTypeComponent, pathMatch: 'full', canActivate: [AuthGuard]},
      {path: 'view-orders', component: ViewOrdersComponent, pathMatch: 'full', canActivate: [AuthGuard]},
      {path: 'create-order', component: CreateOrderComponent, pathMatch: 'full', canActivate: [AuthGuard]},
    ])
  ],
  providers: [
    AuthService,
    { provide: HTTP_INTERCEPTORS, useClass: Interceptor, multi: true },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
