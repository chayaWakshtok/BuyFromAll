import { Basket } from "./basket";
import { Color } from "./color";
import { Item } from "./item";
import { WishList } from "./wishList";
import { Image } from "./image";
import { OrderItem } from "./orderItem";
import { Size } from "./size";
import { Vat } from "./vat";
import { UserComment } from "./userComment";

export class ItemChild {
    id: number;
    name: string;
    description: string;
    stars: number;
    vatId: number; 
    price: number;
    presentLess: number;
    colorId:number;
    count:number;
    barcode:string;
    parentItemId:number;
    shippingPrice:number;
    status:boolean;
    shippingDescription:string;
    returnDescription:string;
    timeShipping:string;
    creationDate:Date;
    unitsStock:number;
    sizeId:number;
    baskets:Basket[]=[];
    color:Color=new Color();
    item:Item=new Item();
    wishList:WishList=new WishList();
    images:Image[]=[];
    order_items:OrderItem[]=[];
    size:Size=new Size();
    vat:Vat=new Vat();
    user_Comment:UserComment[]=[];
}