import { City } from "./city";
import { Order } from "./order";
import { Search } from "./search";
import { UserComment } from "./userComment";

export class User {
    id: number;
    userName: string;
    email: string;
    firstName: string;
    lastName: string;
    phone: string;
    tell: string;
    password: string;
    street: string;
    houseNumber: string;
    flat: number;
    code: string;
    fax: string;
    cityId: number;
    city: City = new City();
    orders: Order[] = [];
    searches: Search[] = [];
    user_Comment: UserComment[] = [];
    image: string;
    faceId: string;
    glasses: boolean;
    age:number;
    gender:string;
}