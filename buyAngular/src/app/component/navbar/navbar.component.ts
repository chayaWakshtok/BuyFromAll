import { Component, OnInit } from '@angular/core';
import { faSearch, faBell, faUser,faShoppingCart,faHeart } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {

  faSearch = faSearch;
  faBell = faBell;
  faUser = faUser;
  faShoppingCart=faShoppingCart;
  faHeart=faHeart;
  
  constructor() { }

  ngOnInit() {
  }

}
