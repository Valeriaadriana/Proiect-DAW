import {Component, OnInit} from '@angular/core';
import {ProductType} from "../../models/Product";
import {ProductTypeService} from "../product-type.service";

@Component({
  selector: 'app-view-product-types',
  templateUrl: './view-product-types.component.html',
})
export class ViewProductTypesComponent implements OnInit {
  productTypes: ProductType[];

  constructor(private service: ProductTypeService) {}

  ngOnInit() {
    this.service.getAll().subscribe(results => this.productTypes = results);
  }
}
