
import { Order } from "./order";
import { Item } from "./item";

export class OrderItem {
    id: number;
    itemId: number;
    count: number;
    price: number;
    status: number;
    orderId: number;
    order: Order = new Order();
    item: Item;
}