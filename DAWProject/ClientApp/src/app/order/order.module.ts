import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {ViewDeliveryTypesComponent} from "./delivery-types/view-delivery-types/view-delivery-types.component";
import {CreateDeliveryTypeComponent} from "./delivery-types/create-delivery-type/create-delivery-type.component";
import {FormsModule} from "@angular/forms";

@NgModule({
  declarations: [CreateDeliveryTypeComponent, ViewDeliveryTypesComponent],
  imports: [
    CommonModule,
    FormsModule
  ],
  exports: [CreateDeliveryTypeComponent, ViewDeliveryTypesComponent]
})
export class OrderModule { }
