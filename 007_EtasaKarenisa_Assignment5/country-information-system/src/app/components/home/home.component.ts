import { Component, Input, Output, EventEmitter } from '@angular/core';
import { CountryFilled } from 'src/app/models/CountryFilled';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent extends CountryFilled {
  
  sortPopulation() {
    this.countryFilled.sort((n1, n2) => {
      if (n1.population < n2.population) {
        return 1;
      }
      if (n1.population > n2.population) {
        return -1;
      }
      return 0;
    });
  }

  sortArea() {
    this.countryFilled.sort((n1, n2) => {
      if (n1.area < n2.area) {
        return 1;
      }
      if (n1.area > n2.area) {
        return -1;
      }
      return 0;
    });
  }
}

