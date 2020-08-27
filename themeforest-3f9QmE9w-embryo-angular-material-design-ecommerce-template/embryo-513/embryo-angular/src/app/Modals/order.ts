import { User } from "./user";
import { OrderItem } from "./orderItem";
import { Payment } from "./payment";
export class Order {

    //     public virtual ICollection<order_items> order_items { get; set; }
    //     public virtual ICollection<payment> payments { get; set; }
    //     public virtual shipping shipping { get; set; }
    id: number;
    userId: number;
    totalPrice: number;
    status: number;
    paid: boolean;
    builingName: string;
    zipCode: string;
    city: string;
    country: string;
    mobile: string;
    email: string;
    order_items: OrderItem[] = []
    payments: Payment;
    user: User;
}