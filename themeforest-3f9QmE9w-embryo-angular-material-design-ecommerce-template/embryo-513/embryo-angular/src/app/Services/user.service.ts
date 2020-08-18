import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable, Subject } from 'rxjs';
import { User } from '../Modals/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  private baseUrl = 'https://buyfromall.cognitiveservices.azure.com/face/v1.0/';
  subjectLogin = new Subject();
  url: string;
  constructor(public httpClient: HttpClient) {
    this.url = environment.baseUrl + "Users";
  }

  loginUser(user: User): Observable<User> {
    return this.httpClient.post<User>(this.url + "/login", user);
  }

  loginUserFace(user): Observable<User> {
    return this.httpClient.post<User>(this.url + "/loginFace", user);
  }

  signUp(user: User): Observable<User> {
    return this.httpClient.post<User>(this.url, user);
  }

  getAll(): Observable<User[]> {
    return this.httpClient.get<User[]>(this.url);
  }

  detect(url) {
    return this.httpClient.post<any[]>(`${this.baseUrl}/detect?returnFaceLandmarks=false&returnFaceAttributes=age,gender,smile,glasses,emotion,facialHair`, { url: url }, httpOptions);
  }
  
}
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
    'Ocp-Apim-Subscription-Key': 'eb2b6f51708d466da01dcffa62860379'
  })
};