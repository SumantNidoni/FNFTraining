import { Component } from '@angular/core';
import { Order } from '../../Models/order';
import { Cartservice } from '../../Services/cartservice';
import { Orderservice } from '../../Services/orderservice';
import { Router } from '@angular/router';

@Component({
  selector: 'app-checkoutcomponent',
  standalone: false,
  templateUrl: './checkoutcomponent.html',
  styleUrl: './checkoutcomponent.css'
})
export class Checkoutcomponent {
  
customerName: string = '';
  address: string = '';

  constructor(
    private cartService: Cartservice,
    private orderService: Orderservice,
    private router: Router
  ) {}

  placeOrder(): void {
    const order: Order = {
      customerName: this.customerName,
      address: this.address,
      items: this.cartService.getCartItems(),
      totalAmount: this.cartService.getTotalAmount()
    };

    this.orderService.placeOrder(order).subscribe(() => {
      this.cartService.clearCart();
      this.router.navigate(['/confirmation']);
    });
  }

}
