import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { Todo } from 'src/app/models/todo';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {
  todos: Todo[] = [];
  inputTodo: string = '';
  @Output() newTodoEvent = new EventEmitter<Todo>();
  constructor() { }

  ngOnInit(): void {
    this.todos = [
      {
        content: 'First todo',
        completed: false,
        edit: false,
      },
      {
        content: 'Second todo',
        completed: false,
        edit: false
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

      alert("You have updated your todo.");
      this.inputTodo = '';
    }else{
      alert("Your todo content is empty.");
    }
  }

  addTodo(todo: Todo) {
    this.todos.push(todo);
  }
}
