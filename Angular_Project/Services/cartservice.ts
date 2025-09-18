import { Injectable } from '@angular/core';
import { CartItem } from '../Models/cart-item';
import { BehaviorSubject } from 'rxjs';
import { Dish } from '../Models/dish';

@Injectable({
  providedIn: 'root'
})
export class Cartservice {
    
private cartItems: CartItem[] = [];
  private cartSubject = new BehaviorSubject<CartItem[]>([]);

  cart$ = this.cartSubject.asObservable();

  addToCart(dish: Dish): void {
    const existingItem = this.cartItems.find(item => item.dish.id === dish.id);
    if (existingItem) {
      existingItem.quantity += 1;
    } else {
      this.cartItems.push({ dish, quantity: 1 });
    }
    this.cartSubject.next(this.cartItems);
  }

  removeFromCart(dishId: number): void {
    this.cartItems = this.cartItems.filter(item => item.dish.id !== dishId);
    this.cartSubject.next(this.cartItems);
  }

  updateQuantity(dishId: number, quantity: number): void {
    const item = this.cartItems.find(item => item.dish.id === dishId);
    if (item) {
      item.quantity = quantity;
      this.cartSubject.next(this.cartItems);
    }
  }

  clearCart(): void {
    this.cartItems = [];
    this.cartSubject.next(this.cartItems);
  }

  getCartItems(): CartItem[] {
    return [...this.cartItems];
  }

  getTotalAmount(): number {
    return this.cartItems.reduce((total, item) => total + item.dish.price * item.quantity, 0);
  }

}
