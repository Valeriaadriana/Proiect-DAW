import {Inject, Injectable} from '@angular/core';
import {BaseService} from "../../base/base.service";
import {HttpClient} from "@angular/common/http";
import {Order} from "../models/Order";

@Injectable({
  providedIn: 'root'
})
export class OrderService extends BaseService<Order> {
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl, "orders");
  }

  getByUserId(userId: string) {
    return this.http.get<Array<Order>>(`${this.endpoint}/user/${userId}`)
  }
}
