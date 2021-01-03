import {Inject, Injectable} from '@angular/core';
import {ProductType} from "../models/Product";
import {HttpClient} from "@angular/common/http";
import {BaseService} from "../../base/base.service";

@Injectable({
  providedIn: 'root'
})
export class ProductTypeService extends BaseService<ProductType> {
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl, "productTypes");
  }
}
