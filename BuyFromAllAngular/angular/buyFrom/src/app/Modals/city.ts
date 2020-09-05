import { User } from "./user";

export class City {
    id: number;
    cityName: string;
    country: string;
    users:User[]=[];

}