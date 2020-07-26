import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { WishList } from '../Modals/wishList';

@Injectable({
  providedIn: 'root'
})
export class WishlistService {

  url: string;
  constructor(public httpClient: HttpClient) {
    this.url = environment.baseUrl + "Brands";
  }

  getAllByUser(): Observable<WishList[]> {
    return this.httpClient.get<WishList[]>(this.url);
  }
}
