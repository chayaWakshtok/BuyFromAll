import { Component, OnInit, Input } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from 'src/app/Services/user.service';

@Component({
  selector: 'embryo-HeaderUserProfileDropdown',
  templateUrl: './HeaderUserProfileDropdown.component.html',
  styleUrls: ['./HeaderUserProfileDropdown.component.scss']
})
export class HeaderUserProfileDropdownComponent implements OnInit {

  @Input() isLogin: boolean = false;

  constructor(public router: Router,
    public userService: UserService) { }

  ngOnInit() {
    var user = JSON.parse(localStorage.getItem("user"));
    if (user)
      this.isLogin = true;

    this.userService.subjectLogin.subscribe(res => {
      debugger
      this.isLogin = true;
    })
  }

  login() {
    this.router.navigate(["session/signin"])
  }

  logOut()
  {
    localStorage.removeItem("user");
    this.isLogin=false;
    this.router.navigate(["session/signin"])
  }

}
