import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { ButtonComponent } from './button/button.component';
import { AsideComponent } from './aside/aside.component';
import { FileSizePipe } from './file-size/file-size.pipe';
import { TodoDashboardModule } from './todo-dashboard/todo-dashboard.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    ButtonComponent,
    AsideComponent,
    FileSizePipe
  ],
  imports: [
    BrowserModule,
    TodoDashboardModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
