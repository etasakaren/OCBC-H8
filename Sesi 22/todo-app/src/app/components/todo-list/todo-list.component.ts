import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Todo } from 'src/app/models/Todo';


@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {
  todos: Todo[] = [];
  inputTodo: string = '';
  inputDeadline: string = '';
  @Output() newTodoEvent = new EventEmitter<Todo>();
  constructor() { }

  ngOnInit(): void {
    this.todos = [
      {
        content: 'First todo',
        completed: false,
        edit: false,
        deadline: "2021-12-21"
      },
      {
        content: 'Second todo',
        completed: false,
        edit: false,
        deadline: "2022-12-12"
      }
    ]
  }

  toggleDone(id: number) {
    this.todos.map((v, i) => {
      if (i == id) v.completed = !v.completed;
      console.log(v);
      return v;
    });
  }

  deleteTodo(id: number) {
    this.todos = this.todos.filter((v, i) => i !== id);
  }

  editTodo(todo: Todo) {
    todo.edit = true;
  }

  editSaveTodo(todo: Todo) {
    if (todo.content != null) {
      todo.content = this.inputTodo;
      todo.completed = false;
      todo.edit = false;
      todo.deadline = this.inputDeadline;

      alert("You have updated your todo.");
      this.inputTodo = '';
    }else{
      alert("Your todo is empty.");
    }
  }

  addTodo(todo: Todo) {
    this.todos.push(todo);
  }

  
  
}
