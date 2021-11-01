import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeService } from 'src/app/services/employee.service';
import { Location } from '@angular/common';
import { FormControl } from '@angular/forms';
import { Employee } from 'src/app/models/Employee';

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit {
  @Output() newEmployeeEvent = new EventEmitter<Employee>();
  constructor(private employeeService: EmployeeService, private router: Router, private route: ActivatedRoute, private location: Location,) { }

  reads: any;

  ngOnInit(): void {
    this.id = this.route.snapshot.params['id'];
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

  id!: number;
  currentTitle = new FormControl('');
  currentFirst = new FormControl('');
  currentLast = new FormControl('');
  currentRole = new FormControl('');
  currentPassword = new FormControl('');
  currentEmail = new FormControl('');
  currentConfirm = new FormControl('');

  data = {
    title: this.currentTitle.setValue(this.currentTitle),
    firstName: this.currentFirst.setValue(this.currentFirst),
    lastName: this.currentLast.setValue(this.currentLast),
    role: this.currentRole.setValue(this.currentRole),
    password: this.currentPassword.setValue(this.currentPassword),
    email: this.currentEmail.setValue(this.currentEmail),
    confirmPassword: this.currentConfirm.setValue(this.currentConfirm),
  }

  update() {
    console.log()
    this.employeeService.update(this.id, this.data)
      .subscribe(
        response => {
          alert("Successfully edited.");
          this.router.navigate(['/read']);
        },
        error => {
          console.log(error);
        });

  }

  cancel() {
    if (confirm("Are you sure you want to quit editing?")) {
      alert("Canceled editing.");
      this.location.back();
    } else {
      alert("Ok.");
      // this.router.navigate(['/read']);
    }
  }
}
