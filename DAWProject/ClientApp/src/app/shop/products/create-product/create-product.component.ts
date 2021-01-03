import {Component, OnInit} from '@angular/core';
import {Product, ProductType} from "../../models/Product";
import {Router} from "@angular/router";
import {ProductService} from "../product.service";
import {ProductTypeService} from "../../product-types/product-type.service";

@Component({
  selector: 'app-create-product',
  templateUrl: './create-product.component.html',
})
export class CreateProductComponent implements OnInit {
  product: Product;
  selectedProductType: ProductType;
  productTypes: ProductType[];


  constructor(private router: Router,
              private productService: ProductService,
              private productTypeService: ProductTypeService) {
  }

  ngOnInit() {
    this.product = new Product();
    this.productTypeService.getAll().subscribe(results => this.productTypes = results);
  }

  onCreate() {
    return this.productService.create(this.product).subscribe(_ =>
      this.router.navigateByUrl('view-products').then()
    )
  }

  onSelectProductType(productType: ProductType) {
    this.selectedProductType = productType;
    this.product.productType = productType
  }
}
