import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Brand } from '../Modals/brand';

@Injectable({
  providedIn: 'root'
})
export class ItemService {

  url:string;
  constructor(public httpClient:HttpClient) { 
    this.url=environment.baseUrl+"item";
  }

  addProduct(item)
  {
    return this.httpClient.post(this.url,item);
  }
}
