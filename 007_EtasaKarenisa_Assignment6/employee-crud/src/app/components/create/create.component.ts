import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { EmployeeService } from 'src/app/services/employee.service';
import { Location } from '@angular/common';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {

  constructor(private employeeService: EmployeeService, private router: Router, private location: Location,) { }

  createForm = new FormGroup({
    title: new FormControl('', [Validators.required, Validators.minLength(5)]),
    firstName: new FormControl('', [Validators.required, Validators.minLength(5)]),
    lastName: new FormControl('', [Validators.required, Validators.minLength(5)]),
    role: new FormControl('', [Validators.required, Validators.minLength(4)]),
    password: new FormControl('', [Validators.required, Validators.minLength(6)]),
    email: new FormControl('', [Validators.required, Validators.email]),
    confirmPassword: new FormControl('', [Validators.required, Validators.minLength(6)]),
  })
  submitted = false;

  get title() {
    return this.createForm.get('title');
  }
  get firstName() {
    return this.createForm.get('firstName');
  }
  get lastName() {
    return this.createForm.get('lastName');
  }
  get role() {
    return this.createForm.get('role');
  }

  get confirmPassword() {
    return this.createForm.get('confirmPassword');
  }

  get password() {
    return this.createForm.get('password');
  }

  get email() {
    return this.createForm.get('email');
  }

  ngOnInit(): void {
  }

  create() {
    this.employeeService.create(this.createForm.value).subscribe((res) => {
      if (res) {
        console.log(res);
        this.submitted = true;
        this.createForm.reset();
        alert("Successfully added.");
        this.router.navigate(['/read']);
      }
    })
  }

  cancel() {
    if (confirm("Are you sure you want to quit submitting?")) {
      alert("Canceled submitting.");
      this.location.back();
      this.createForm.reset();
    }else{
      alert("Ok.");
      this.createForm.reset();
      // this.router.navigate(['/read']);
    }
  }

}
