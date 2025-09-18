import { Component } from '@angular/core';
import { Cartservice } from '../../Services/cartservice';
import { CartItem } from '../../Models/cart-item';

@Component({
  selector: 'app-cartviewcomponent',
  standalone: false,
  templateUrl: './cartviewcomponent.html',
  styleUrl: './cartviewcomponent.css'
})
export class Cartviewcomponent {
  
cartItems: CartItem[] = [];
  totalAmount: number = 0;

  constructor(private cartService: Cartservice) {}

  ngOnInit(): void {
    this.cartItems = this.cartService.getCartItems();
    this.totalAmount = this.cartService.getTotalAmount();
  }

  updateQuantity(dishId: number, quantity: number): void {
    this.cartService.updateQuantity(dishId, quantity);
    this.totalAmount = this.cartService.getTotalAmount();
  }

  removeItem(dishId: number): void {
    this.cartService.removeFromCart(dishId);
    this.cartItems = this.cartService.getCartItems();
    this.totalAmount = this.cartService.getTotalAmount();
  }


}
