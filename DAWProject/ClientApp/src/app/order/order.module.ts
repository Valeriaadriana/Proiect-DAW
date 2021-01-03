import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {ViewDeliveryTypesComponent} from "./delivery-types/view-delivery-types/view-delivery-types.component";
import {CreateDeliveryTypeComponent} from "./delivery-types/create-delivery-type/create-delivery-type.component";
import {FormsModule} from "@angular/forms";
import {CreateOrderComponent} from './orders/create-order/create-order.component';
import {ViewOrdersComponent} from './orders/view-orders/view-orders.component';
import {ShopModule} from "../shop/shop.module";
import {OrderService} from "./orders/order.service";

@NgModule({
  declarations: [CreateDeliveryTypeComponent, ViewDeliveryTypesComponent, CreateOrderComponent, ViewOrdersComponent],
  imports: [
    CommonModule,
    FormsModule,
    ShopModule
  ],
  providers: [OrderService],
  exports: [CreateDeliveryTypeComponent, ViewDeliveryTypesComponent, CreateOrderComponent, ViewOrdersComponent]
})
export class OrderModule { }
