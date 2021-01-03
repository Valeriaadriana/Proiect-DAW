import {Component, OnInit} from '@angular/core';

import {DeliveryType} from "../../models/DeliveryType";
import {DeliveryTypeService} from "../delivery-type.service";

@Component({
  selector: 'app-view-delivery-types',
  templateUrl: './view-delivery-types.component.html',
})
export class ViewDeliveryTypesComponent implements OnInit {
  deliveryTypes: DeliveryType[];

  constructor(private service: DeliveryTypeService) {}

  ngOnInit() {
    this.service.getAll().subscribe(results => this.deliveryTypes = results);
  }
}
