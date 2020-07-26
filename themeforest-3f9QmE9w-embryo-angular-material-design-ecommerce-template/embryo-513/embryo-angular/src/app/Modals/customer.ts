import { Item } from "./item";
import { Site } from "./site";

export class Customer {
    id: number;
    name: string;
    email: string;
    phone: string;
    fax: string;
    image: string;
    description: string;
    status: boolean;
    starts: number;
    creationDate: Date;
    userName: string;
    password: string;
    items:Item[]=[];
    sites:Site[]=[];
}