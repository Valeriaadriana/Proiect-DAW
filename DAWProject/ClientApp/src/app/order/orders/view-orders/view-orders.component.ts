import {Component, OnInit} from '@angular/core';
import {Order} from "../../models/Order";
import {OrderService} from "../order.service";
import {AuthService} from "../../../auth.service";

@Component({
  selector: 'app-view-orders',
  templateUrl: './view-orders.component.html',
  styleUrls: ['./view-orders.component.css']
})
export class ViewOrdersComponent implements OnInit {
  orders: Order[];

  constructor(private orderService: OrderService,
              private authService: AuthService) { }

  ngOnInit() {
    this.loadOrders()
  }

  deleteOrder(order: Order) {
    this.orderService.delete(order).subscribe(_ => {
      this.loadOrders()
    })
  }

  loadOrders() {
    let userId = this.authService.getUserSession().id
    this.orderService.getByUserId(userId).subscribe(results => this.orders = results)
  }

  getProducts(order: Order) {
    return order.products.map(value => value.name).join(',')
  }
}
