import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/shared/auth.service';

@Component({
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrls: ['./signin.component.css']
})
export class SigninComponent implements OnInit {

  constructor(public authService: AuthService, public router: Router) { }

  signinForm = new FormGroup({
    password: new FormControl('', [Validators.required, Validators.minLength(5)]),
    email: new FormControl('', [Validators.required, Validators.email])
  })

  get password() {
    return this.signinForm.get('password');
  }

  get email() {
    return this.signinForm.get('email');
  }

  ngOnInit(): void {
  }

  signIn() {
    this.authService.signIn(this.signinForm.value)
  }

}
