import {Component, OnInit} from '@angular/core';
import {Product} from "../../models/Product";
import {ProductService} from "../product.service";

@Component({
  selector: 'app-view-products',
  templateUrl: './view-products.component.html',
})
export class ViewProductsComponent implements OnInit {
  products: Product[];

  constructor(private service: ProductService) {
  }

  ngOnInit() {
    this.service.getAll().subscribe(results => this.products = results);
  }
}
