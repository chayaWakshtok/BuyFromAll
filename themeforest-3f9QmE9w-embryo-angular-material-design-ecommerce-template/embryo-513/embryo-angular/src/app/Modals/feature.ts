import { Category } from "./category";
import { ItemFeature } from "./itemFeature";
import { Search } from "./search";

export class Feature
{
    id:number;
    name:string;
    item_features:ItemFeature[]=[];
    searches:Search[]=[];
    categories:Category[]=[];
}