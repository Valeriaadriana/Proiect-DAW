import {Component, OnInit} from '@angular/core';
import {Product} from "../../../shop/models/Product";
import {Order} from "../../models/Order";
import {DeliveryType} from "../../models/DeliveryType";
import {ProductService} from "../../../shop/products/product.service";
import {DeliveryTypeService} from "../../delivery-types/delivery-type.service";
import {OrderService} from "../order.service";
import {Router} from "@angular/router";
import {AuthService} from "../../../auth.service";

@Component({
  selector: 'app-create-order',
  templateUrl: './create-order.component.html',
  styleUrls: ['./create-order.component.css']
})
export class CreateOrderComponent implements OnInit {
  products: Product[];
  total = 0
  order: Order
  deliveryTypes: DeliveryType[];
  selectedDeliveryType: DeliveryType;

  constructor(private productService: ProductService,
              private deliveryTypeService: DeliveryTypeService,
              private orderService: OrderService,
              private authService: AuthService,
              private router: Router) { }

  ngOnInit() {
    this.order = new Order()
    this.order.products = []
    this.productService.getAll().subscribe(result => this.products = result)
    this.deliveryTypeService.getAll().subscribe(result => this.deliveryTypes = result)
  }

  addToOrder(product: Product) {
    this.order.products.push(product)
    this.calculateTotal()
  }

  removeFromOrder(product: Product) {
    this.order.products = this.order.products.filter((value, index, array) => {
      return value.id === product.id
    })
    this.calculateTotal()
  }

  calculateTotal() {
    this.total = this.order.products.map((value, index, array) => {
      return value.price
    }).reduce(((previousValue, currentValue) => previousValue + currentValue))
    this.total += this.selectedDeliveryType.price
    this.order.total = this.total
  }

  onSelectDeliveryType(deliveryType: DeliveryType) {
    this.selectedDeliveryType = deliveryType
    this.order.deliveryType = deliveryType
    this.calculateTotal()
  }

  onCreateOrder() {
    this.order.userId = this.authService.getUserSession().id
    this.orderService.create(this.order).subscribe(_ => this.router.navigateByUrl('/view-orders').then())
  }
}
