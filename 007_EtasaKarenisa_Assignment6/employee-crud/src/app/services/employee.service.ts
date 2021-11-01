import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { EventEmitter, Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  endpoint: string =
    'http://localhost:4000';

  constructor(private http: HttpClient) { }

  invokeDeleteFunction = new EventEmitter();

  getAll(): Observable<any> {
    const api = `${this.endpoint}/users`;
    return this.http.get(api).pipe(catchError(this.handleError));
  }

  delete(id: number): Observable<any> {
    const api = `${this.endpoint}/users`;
    return this.http.delete(`${api}/${id}`).pipe(catchError(this.handleError));
  }

  create(data: any): Observable<any> {
    const api = `${this.endpoint}/users`;
    return this.http.post(api, data).pipe(catchError(this.handleError));
  }

  update(id: number, data: any): Observable<any> {
    const api = `${this.endpoint}/users`;
    return this.http.put(`${api}/${id}`, data).pipe(catchError(this.handleError));
  }

  handleError(error: HttpErrorResponse) {
    console.log(error);
    let msg = '';
    if (error.error instanceof ErrorEvent) {
      msg = error.error.message;
    } else {
      msg = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    return throwError(msg);
  }
}
