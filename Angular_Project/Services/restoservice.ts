import { Injectable } from '@angular/core';
import { Restuarant } from '../Models/restuarant';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class Restoservice {
  
private apiUrl = 'http://localhost:3000/restaurants';

  constructor(private http: HttpClient) {}

  getRestaurants(): Observable<Restuarant[]> {
    return this.http.get<Restuarant[]>(this.apiUrl);
  }

  getRestaurantById(id: number): Observable<Restuarant> {
   return this.http.get<Restuarant>(`${this.apiUrl}/${id}`);
  }

}
