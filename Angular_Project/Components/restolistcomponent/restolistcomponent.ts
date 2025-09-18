import { Component } from '@angular/core';
import { Restoservice } from '../../Services/restoservice';
import { Restuarant } from '../../Models/restuarant';

@Component({
  selector: 'app-restolistcomponent',
  standalone: false,
  templateUrl: './restolistcomponent.html',
  styleUrl: './restolistcomponent.css'
})
export class Restolistcomponent {
  
 restaurants: Restuarant[] = [];

  constructor(private restaurantService: Restoservice) {}

  ngOnInit(): void {
    this.restaurantService.getRestaurants().subscribe(data => {
      this.restaurants = data;
    });
  }

}
