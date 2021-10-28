import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { CountryDetailComponent } from './components/country-detail/country-detail.component';
import { AllCountriesComponent } from './components/all-countries/all-countries.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'country-detail/:id', component: CountryDetailComponent },
  { path: 'all-countries', component: AllCountriesComponent },
  { path: '', redirectTo: 'home', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
