import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Restoservice } from '../../Services/restoservice';
import { Cartservice } from '../../Services/cartservice';
import { Restuarant } from '../../Models/restuarant';

@Component({
  selector: 'app-restodetailcomponent',
  standalone: false,
  templateUrl: './restodetailcomponent.html',
  styleUrl: './restodetailcomponent.css'
})
export class Restodetailcomponent {
  
 restaurant: Restuarant | undefined;

  constructor(
    private route: ActivatedRoute,
    private restaurantService: Restoservice,
    private cartService: Cartservice
  ) {}

  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.restaurantService.getRestaurantById(id).subscribe(data => {
      this.restaurant = data;
    });
  }

}
