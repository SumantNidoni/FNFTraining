import { CartItem } from "./cart-item";

export interface Order {
    
 id?: number;
  customerName: string;
  address: string;
  items: CartItem[];
  totalAmount: number;

}
