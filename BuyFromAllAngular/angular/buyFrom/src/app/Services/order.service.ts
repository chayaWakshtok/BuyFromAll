import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  url:string;
  constructor(public httpClient:HttpClient) { 
    this.url=environment.baseUrl+"Orders";
  }

  addOrder(order)
  {
    return this.httpClient.post(this.url,order);
  }
}
