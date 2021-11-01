import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EmployeeService } from 'src/app/services/employee.service';

@Component({
  selector: 'app-delete',
  templateUrl: './delete.component.html',
  styleUrls: ['./delete.component.css']
})
export class DeleteComponent implements OnInit {

  constructor(private employeeService: EmployeeService,private router: Router) { }

  ngOnInit(): void {
  }

  delete(id: number):void{
    if(confirm("Are you sure to delete data?")) {
      this.employeeService.delete(id)
      .subscribe(
        response => {
          window.location.reload();
          alert("Successfully deleted.");
          this.router.navigate(['/read']);
        },
        error => {
          console.log(error);
        });
    }
    
  }
}
