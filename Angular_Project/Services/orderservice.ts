import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Order } from '../Models/order';

@Injectable({
  providedIn: 'root'
})
export class Orderservice {
  

private apiUrl = 'http://localhost:3000/orders';

  constructor(private http: HttpClient) {}

  placeOrder(order: Order): Observable<Order> {
    return this.http.post<Order>(this.apiUrl, order);
  }

  getOrders(): Observable<Order[]> {
    return this.http.get<Order[]>(this.apiUrl);
  }


}
