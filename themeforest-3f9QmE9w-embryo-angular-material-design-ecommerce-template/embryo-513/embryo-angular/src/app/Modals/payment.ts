import { Order } from "./order";

export class Payment{
    id:number;
    transactionId:number;
    orderId:number;
    date:Date;
    type:number;
    order:Order=new Order();
}