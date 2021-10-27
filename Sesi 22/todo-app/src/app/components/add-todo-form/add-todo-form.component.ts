import { Component, EventEmitter, Output } from '@angular/core';
import { Todo } from 'src/app/models/todo';

@Component({
  selector: 'app-add-todo-form',
  templateUrl: './add-todo-form.component.html',
  styleUrls: ['./add-todo-form.component.css']
})
export class AddTodoFormComponent {
  @Output() newTodoEvent = new EventEmitter<Todo>();

  inputTodo: string = "";

  constructor() { }

  addTodo() {
    const todo: Todo = {
      content: this.inputTodo,
      completed: false,
      edit: false
    };

    if (this.inputTodo != "") {
      this.newTodoEvent.emit(todo);
      this.inputTodo = "";
    }else{
      alert("Fill in todo content!");
    };
  }

}
