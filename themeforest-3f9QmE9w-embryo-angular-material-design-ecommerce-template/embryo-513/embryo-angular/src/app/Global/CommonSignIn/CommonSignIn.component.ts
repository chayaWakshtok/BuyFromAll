import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/Modals/user';
import { Router } from '@angular/router';
import { UserService } from 'src/app/Services/user.service';
import { ToastaService, ToastOptions } from 'ngx-toasta';

@Component({
  selector: 'embryo-SignIn',
  templateUrl: './CommonSignIn.component.html',
  styleUrls: ['./CommonSignIn.component.scss']
})
export class CommonSignInComponent implements OnInit {

  toastOption  : ToastOptions = {
    title     : "Login Information",
    msg       : "Login Fail check Your username and password!",
    showClose : true,
    timeout   : 3000,
    theme     : "material"
 };
  user: User = new User();
  constructor(public router: Router,
     public userService: UserService,
     private toastyService: ToastaService) { }

  ngOnInit() {
  }

  login() {
    this.userService.loginUser(this.user).subscribe(res => {
      if (res != null) {
        localStorage.setItem("user", JSON.stringify(res));
        this.userService.subjectLogin.next(true);
        this.router.navigate([""]);
      }
      else {
        this.toastyService.error(this.toastOption);
      }
    })

  }

}
