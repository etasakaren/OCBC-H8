import { Component, EventEmitter, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Todo } from 'src/app/models/Todo';

@Component({
  selector: 'app-add-todo-form',
  templateUrl: './add-todo-form.component.html',
  styleUrls: ['./add-todo-form.component.css']
})
export class AddTodoFormComponent {
  @Output() newTodoEvent = new EventEmitter<Todo>();

  inputTodo: string = "";

  inputDeadline: string = "";

  constructor() { }
  isSubmitted = false;

  isValidDate = (c: FormControl) => {
    const DATE_REGEXP = /^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$/;
    return DATE_REGEXP.test(c.value) || c.value === '' ? null : {
      validateEmail: {
        valid: false
      }
    };
  }

  todoData = new FormGroup({
    content: new FormControl('', [
      Validators.required,
    ]),
    deadline: new FormControl('', [
      Validators.required,
      this.isValidDate
    ]),
  })



  handleTodoForm() {
    this.isSubmitted = true;
        const todo: Todo = {
      content: this.inputTodo,
      completed: false,
      edit: false,
      deadline: this.inputDeadline
    };

    if (this.inputTodo != "" && this.inputDeadline != "") {
      this.newTodoEvent.emit(todo);
      this.inputTodo = "";
      this.inputDeadline="";
    }else if(this.inputTodo != ""){
      alert("Fill in todo content!");
    }else if(this.inputDeadline != ""){
      alert("Choose deadline!");
    }else{
      alert("Content and Deadline are empty!");
    };
    console.log(this.todoData.get('content'))
    console.log(this.todoData.get('deadline'))
  }

  get content() {
    return this.todoData.get('content')
  }

  get deadline() {
    return this.todoData.get('deadline')
  }
}
