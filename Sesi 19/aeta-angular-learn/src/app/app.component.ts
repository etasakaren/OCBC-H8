import { Component } from '@angular/core';
import { FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { Task } from './models/Task';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  tasks: Task[] = [];
  title = 'aeta-angular-learn';
  counter = 0;

  people: any[] = [
    {
      "name": "Kitty",
      "home": "Uruguay"
    },
    {
      "name": "Doraemon",
      "home": "Japan"
    },
    {
      "name": "Harry",
      "home": "UK"
    },
    {
      "name": "Richie",
      "home": "USA"
    }
  ];

  onSubmit(form: NgForm) {
    const { taskName, category } = form.value;
    this.tasks = [...this.tasks, new Task(taskName, '', category)]
    form.reset();
  }

  addCounter() {
    this.counter++;
  }

  minCounter() {
    if (this.counter > 0) {
      this.counter--;
    } else {
      this.counter = 0;
    }
  }

  resetCounter() {
    this.counter = 0;
  }

  isSubmitted = false;

  loginData = new FormGroup({
    username: new FormControl('', [
      Validators.required,
      Validators.minLength(5)
    ]),
    password: new FormControl('',[
      Validators.required
    ])
  })

  handleLoginForm() {
    this.isSubmitted = true;
    console.log(this.loginData.get('username'))
    console.log(this.loginData.get('password'))
  }

  handleLoginFormState() {
    if (this.isSubmitted == true)
      this.isSubmitted = false;
    // console.log(this.loginData.get('username'))
    // console.log(this.loginData.get('password'))
  }

  errors=[];


  get username() {
    return this.loginData.get('username')
  }

  get password() {
    return this.loginData.get('password')
  }
  categories: string[] = [
    'Shopping',
    'Work',
    'Education',
    'Financing'
  ];

  // Event Handlers
  handleFormOnSubmit(form: NgForm) {
    const { taskName, category } = form.value

    this.tasks.push(new Task(taskName, "incomplete", category))

    form.reset()
  }
}
