import { Item } from "./item";

export class Brand{
    id:number;
    name:string;
    description:string;
    imageUrl:string;
    items:Item[]=[];
}