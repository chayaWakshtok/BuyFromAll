import { Item } from "./item";


export class Category {
    id: number;
    name: string;
    description: string;
    items:Item[]=[];
    items1:Item[]=[];
}