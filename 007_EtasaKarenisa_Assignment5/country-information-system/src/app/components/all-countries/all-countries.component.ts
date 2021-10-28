import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CountryFilled } from 'src/app/models/CountryFilled';
import { Location } from '@angular/common';

@Component({
  selector: 'app-all-countries',
  templateUrl: './all-countries.component.html',
  styleUrls: ['./all-countries.component.css']
})
export class AllCountriesComponent extends CountryFilled {
  constructor(
    private route: ActivatedRoute,
    private location: Location,
  ) {
    super();
  }

  goBack(): void {
    this.location.back();
  }

}
