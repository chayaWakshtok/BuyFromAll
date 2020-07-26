import { User } from "./user";
import { Feature } from "./feature";

export class Search{
    id:number;
    dateSearch:Date;
    userId:number;
    user:User=new User();
    features:Feature[]=[];
}