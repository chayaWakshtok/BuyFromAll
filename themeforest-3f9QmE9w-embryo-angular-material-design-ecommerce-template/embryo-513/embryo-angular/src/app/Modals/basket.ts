import { ItemChild } from "./itemChild";
import { User } from "./user";

export class Basket
{
    id:number;
	itemChildId:number;
	count:number;
	userId :number;
	items_child:ItemChild=new ItemChild();
	user:User=new User();
}