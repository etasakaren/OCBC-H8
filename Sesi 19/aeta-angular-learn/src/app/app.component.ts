import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'aeta-angular-learn';
  counter = 0;

  addCounter() {
    this.counter++;
  }

  minCounter() {
    if (this.counter > 0) {
      this.counter--;
    }else{
      this.counter = 0;
    }
  }

  resetCounter(){
    this.counter = 0;
  }
}
