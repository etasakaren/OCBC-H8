import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { User } from '../models/User';
import { catchError, map } from 'rxjs/operators';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  endpoint: string =
    'http://localhost:3000';
  headers = new HttpHeaders().set('Content-Type', 'application/json');
  currentUser: { name: string, email: string, _id: string } = { name: '', email: '', _id: '' }

  constructor(private http: HttpClient, private router: Router) { }

  signUp(user: User): Observable<any> {
    let api = `${this.endpoint}/register`;
    return this.http.post(api, user).pipe(catchError(this.handleError))
  }

  signIn(user: User) {
    const api = `${this.endpoint}/login`;
    return this.http.post<any>(api, user).subscribe((res: any) => {
      localStorage.setItem('access_token', res.token)
      this.getStudios().subscribe((res: any) => {
        this.currentUser = res;
        this.router.navigate(['movies']);
      })
    })
  }

  getStudios() {
    const api = `${this.endpoint}/movies`;
    return this.http.get(api, { headers: this.headers }).pipe(map((res: any) => {
      return res || {};
    }), catchError(this.handleError));
  }

  getToken() {
    return localStorage.getItem('access_token');
  }

  get isLoggedIn(): boolean {
    let authToken = localStorage.getItem('access_token');
    return (authToken != null) ? true : false;
  }

  handleError(error: HttpErrorResponse) {
    let msg = '';
    if (error.error instanceof ErrorEvent) {
      msg = error.error.message;
    } else {
      msg = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    return throwError(msg);
  }

}
