import { User } from "./user";
import { OrderItem } from "./orderItem";
import { Payment } from "./payment";
import {  Shipping } from "./shipping";

export class Order{

    //     public virtual ICollection<order_items> order_items { get; set; }
    //     public virtual ICollection<payment> payments { get; set; }
    //     public virtual shipping shipping { get; set; }
    id:number;
    shippingId:number;
    userId:number;
    totalPrice:number;
    status:number;
    paid:boolean;
    user:User=new User();
    order_items:OrderItem[]=[];
    payments:Payment[]=[];
    shipping:Shipping=new Shipping();
    
}