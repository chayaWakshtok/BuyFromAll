import { Item } from "./item";
import { Customer } from "./customer";

export class Site{
    id:number;
    name:string;
    description:string;
    website:string;
    items:Item[]=[];
    customers:Customer[]=[]
}