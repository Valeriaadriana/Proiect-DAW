import {DeliveryType} from "./DeliveryType";
import {Product} from "../../shop/models/Product";

export class Order {
  id: string;
  total: number;
  deliveryDate: Date
  deliveryType: DeliveryType;
  userId: string;
  products: Product[];
}
