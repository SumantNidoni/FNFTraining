import { Dish } from "./dish";

export interface Restuarant {
    
 id: number;
  name: string;
  location: string;
  image: string;
  items: Dish[];

}
