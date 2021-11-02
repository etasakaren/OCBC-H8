import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeService } from 'src/app/services/employee.service';
import { Location } from '@angular/common';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Employee } from 'src/app/models/Employee';

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit {
  // @Output() newEmployeeEvent = new EventEmitter<Employee>();
  constructor(private employeeService: EmployeeService, private router: Router, private route: ActivatedRoute, private location: Location,) { }

  reads: any;

  ngOnInit(): void {
    this.id = this.route.snapshot.params['id'];
    this.retrieveEmployee();
  }

  id!: number

  form = {
    inputData: new FormGroup({
      title: new FormControl('', [Validators.required, Validators.minLength(5)]),
      firstName: new FormControl('', [Validators.required, Validators.minLength(5)]),
      lastName: new FormControl('', [Validators.required, Validators.minLength(5)]),
      role: new FormControl('', [Validators.required, Validators.minLength(4)]),
      password: new FormControl('', [Validators.required, Validators.minLength(6)]),
      email: new FormControl('', [Validators.required, Validators.email]),
      confirmPassword: new FormControl('', [Validators.required, Validators.minLength(6)]),
    })
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

  get title(){
    return this.form.inputData.get('title')
  }
  get firstName(){
    return this.form.inputData.get('firstName')
  }
  get lastName(){
    return this.form.inputData.get('lastName')
  }
  get role(){
    return this.form.inputData.get('role')
  }
  get email(){
    return this.form.inputData.get('email')
  }
  get password(){
    return this.form.inputData.get('password')
  }
  get confirmPassword(){
    return this.form.inputData.get('confirmPassword')
  }

  update(id:number){
    this.employeeService.update(this.form.inputData.value,id)
    .subscribe((res) =>{
      if(res){
        this.form.inputData.reset();
        alert("Successfully edited.");
        this.router.navigate(['/read'])
      }
    })
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
