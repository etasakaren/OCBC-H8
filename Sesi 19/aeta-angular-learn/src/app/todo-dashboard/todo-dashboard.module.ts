import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TodoDashboardComponent } from './todo-dashboard/todo-dashboard.component';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    TodoDashboardComponent
  ],
  imports: [
    CommonModule,
    FormsModule
  ],
  exports:[
    TodoDashboardComponent
  ]
})
export class TodoDashboardModule { }
