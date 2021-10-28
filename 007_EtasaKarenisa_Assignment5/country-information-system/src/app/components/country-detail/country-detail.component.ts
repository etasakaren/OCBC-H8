import { Component} from '@angular/core';
import { CountryFilled } from 'src/app/models/CountryFilled';

@Component({
  selector: 'app-country-detail',
  templateUrl: './country-detail.component.html',
  styleUrls: ['./country-detail.component.css']
})
export class CountryDetailComponent extends CountryFilled {

}
