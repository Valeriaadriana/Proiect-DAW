import {Inject, Injectable} from '@angular/core';
import {Product} from "../models/Product";
import {HttpClient} from "@angular/common/http";
import {BaseService} from "../../base/base.service";

@Injectable({
  providedIn: 'root'
})
export class ProductService extends BaseService<Product>{
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl, "products");
  }
}
