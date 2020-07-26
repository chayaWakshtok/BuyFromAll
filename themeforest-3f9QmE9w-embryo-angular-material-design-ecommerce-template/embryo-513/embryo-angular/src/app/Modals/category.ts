import { SubCategory } from "./subCategory";
import { Feature } from "./feature";

export class Category {
    id: number;
    name: string;
    description: string;
    sub_categories:SubCategory[]=[];
    features:Feature[]=[];
}