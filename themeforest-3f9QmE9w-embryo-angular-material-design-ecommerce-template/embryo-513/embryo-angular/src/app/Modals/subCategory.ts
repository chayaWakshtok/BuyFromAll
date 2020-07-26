import { Category } from "./category";
import { Item } from "./item";

export class SubCategory{
    id:number;
    name:string;
    description:string;
    categoryId:number;
    category:Category=new Category();
    items:Item[]=[];
}