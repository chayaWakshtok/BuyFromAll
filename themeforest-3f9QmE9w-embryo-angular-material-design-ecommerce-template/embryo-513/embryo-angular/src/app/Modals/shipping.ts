import { Order } from "./order";

export class Shipping{
    id:number;
    description:string;
    status:number;
    shippingDate:Date;
    creationDate:Date;
    orders:Order[]=[];
}