import { Component, Input, OnInit, TemplateRef, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { Employee } from 'src/app/models/Employee';
import { EmployeeService } from 'src/app/services/employee.service';
import { CreateComponent } from '../create/create.component';
import { DeleteComponent } from '../delete/delete.component';

@Component({
  selector: 'app-read',
  templateUrl: './read.component.html',
  styleUrls: ['./read.component.css']
})
export class ReadComponent implements OnInit {
  @Input()
  id?: number;
  reads: any;

  constructor(private employeeService: EmployeeService, private router: Router) { }

  ngOnInit(): void {
    this.retrieveEmployee();
  }

  retrieveEmployee(): void {
    this.employeeService.getAll()
      .subscribe(
        data => {
          this.reads = data;
        },
        error => {
          console.log(error);
        });
  }

  delete(id: number): void {
    let deleteComponent = new DeleteComponent(this.employeeService, this.router);
    deleteComponent.delete(id);
  }

  create(): void {
    this.router.navigate(['/create']);
  }

  data = false;
  edit(id:number) {
    this.id = id;
    this.data = true;
    this.router.navigate(['/update', id]);
  }

}
