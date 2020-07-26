import { ItemChild } from "./itemChild";
import { User } from "./user";

export class WishList{
    id:number;
    itemChildId:number;
    userId:number;
    items_child:ItemChild=new ItemChild();
    user:User=new User();

}