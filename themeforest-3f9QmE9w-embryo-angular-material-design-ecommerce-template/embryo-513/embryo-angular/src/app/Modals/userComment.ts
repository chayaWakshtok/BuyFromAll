import { ItemChild } from "./itemChild";
import { User } from "./user";

export class UserComment{
    id:number;
    comment:string;
    date:Date;
    rate:number;
    userId:number;
    itemChildId:number;
    items_child:ItemChild=new ItemChild();
    user:User=new User();
}