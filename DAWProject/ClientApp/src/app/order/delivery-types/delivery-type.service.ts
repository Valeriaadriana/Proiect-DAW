import {Inject, Injectable} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {BaseService} from "../../base/base.service";
import {DeliveryType} from "../models/DeliveryType";

@Injectable({
  providedIn: 'root'
})
export class DeliveryTypeService extends BaseService<DeliveryType> {
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl, "deliveryTypes");
  }
}
