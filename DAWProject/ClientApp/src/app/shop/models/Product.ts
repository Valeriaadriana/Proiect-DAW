import {BaseEntity} from "../../base/BaseEntity";

export class Product extends BaseEntity {
  name: string;
  productType: ProductType;
  price: number;
}

export class ProductType extends BaseEntity {
  name: string;
  perishable: boolean
}
