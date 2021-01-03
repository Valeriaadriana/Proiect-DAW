import {Component, OnInit} from '@angular/core';
import {ProductType} from "../../models/Product";
import {Router} from "@angular/router";
import {ProductTypeService} from "../product-type.service";

@Component({
  selector: 'app-create-product-type',
  templateUrl: './create-product-type.component.html',
  styleUrls: ['./create-product-type.component.css']
})
export class CreateProductTypeComponent implements OnInit {
  productType: ProductType;


  constructor(private router: Router, private service: ProductTypeService) {
  }

  ngOnInit() {
    this.productType = new ProductType();
  }

  onCreate() {
    return this.service.create(this.productType).subscribe(_ =>
      this.router.navigateByUrl('view-product-types').then()
    )
  }
}
