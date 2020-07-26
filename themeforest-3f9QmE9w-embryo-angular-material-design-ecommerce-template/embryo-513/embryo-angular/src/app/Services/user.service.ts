import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable, Subject } from 'rxjs';
import { User } from '../Modals/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  subjectLogin = new Subject();
  url: string;
  constructor(public httpClient: HttpClient) {
    this.url = environment.baseUrl + "Users";
  }

  loginUser(user: User): Observable<User> {
    return this.httpClient.post<User>(this.url + "/login", user);
  }

  signUp(user: User): Observable<User> {
    return this.httpClient.post<User>(this.url, user);
  }

  getAll(): Observable<User[]> {
    return this.httpClient.get<User[]>(this.url);
  }
}
