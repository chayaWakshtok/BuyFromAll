import { Brand } from "./brand";
import { Customer } from "./customer";
import { ItemFeature } from "./itemFeature";
import { Manufacturer } from "./manufacturer";
import { ItemChild } from "./itemChild";
import { Site } from "./site";

export class Item {
    id: number;
    barcode: string;
    customerId: number;
    siteId: number;
    brandId: number;
    manufacturerId: number;
    brand: Brand;
    customer: Customer;
    item_features:ItemFeature[]=[];
    manufacturer:Manufacturer=new Manufacturer();
    items_child:ItemChild[]=[];
    site:Site=new Site();
}