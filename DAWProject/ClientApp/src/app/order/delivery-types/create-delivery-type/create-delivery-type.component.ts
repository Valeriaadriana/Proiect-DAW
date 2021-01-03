import {Component, OnInit} from '@angular/core';
import {DeliveryType} from "../../models/DeliveryType";
import {Router} from "@angular/router";
import {DeliveryTypeService} from "../delivery-type.service";

@Component({
  selector: 'app-create-delivery-type',
  templateUrl: './create-delivery-type.component.html',
})
export class CreateDeliveryTypeComponent implements OnInit {
  deliveryType: DeliveryType;


  constructor(private router: Router, private service: DeliveryTypeService) {
  }

  ngOnInit() {
    this.deliveryType = new DeliveryType();
  }

  onCreate() {
    return this.service.create(this.deliveryType).subscribe(_ =>
      this.router.navigateByUrl('view-delivery-types').then()
    )
  }
}
