import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/Modals/user';
import { UserService } from 'src/app/Services/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'embryo-Register',
  templateUrl: './Register.component.html',
  styleUrls: ['./Register.component.scss']
})
export class RegisterComponent implements OnInit {

  user: User = new User();

  constructor(public userService: UserService,
    public router: Router) { }

  ngOnInit() {
  }

  submit() {
    this.userService.detect(this.user.image).subscribe(res => {
      debugger;
      if (res[0]["glasses"] == "NoGlasses")
        this.user.glasses = false;
      else this.user.glasses = true;
      this.user.age = res[0]["faceAttributes"]["age"];
      this.user.gender = res[0]["faceAttributes"]["gender"];
      this.user.faceId = res[0]["faceId"];
      this.userService.signUp(this.user).subscribe(res => {
        localStorage.setItem("user", JSON.stringify(res));
        this.userService.subjectLogin.next(true);
        this.router.navigate([""]);
      })
    })

  }

}
