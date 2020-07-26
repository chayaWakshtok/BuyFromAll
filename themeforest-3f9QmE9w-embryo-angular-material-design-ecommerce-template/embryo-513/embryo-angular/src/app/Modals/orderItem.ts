import { ItemChild } from "./itemChild";
import { Order } from "./order";

export class OrderItem{
    id:number;
    itemChildId:number;
    count:number;
    price:number;
    status:number;
    orderId:number;
    items_child:ItemChild=new ItemChild();
    order:Order=new Order();
}