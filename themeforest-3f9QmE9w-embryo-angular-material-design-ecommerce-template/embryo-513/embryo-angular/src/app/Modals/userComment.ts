import { User } from "./user";
import { Item } from "./item";

export class UserComment{
    id:number;
    comment:string;
    date:Date;
    rate:number;
    userId:number;
    itemId:number;
    user:User=new User();
    item:Item;
}