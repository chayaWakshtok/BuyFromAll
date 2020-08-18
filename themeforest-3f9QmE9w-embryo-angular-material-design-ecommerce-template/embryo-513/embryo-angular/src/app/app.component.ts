import { Component, ViewContainerRef, ElementRef, ViewChild } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { UserService } from './Services/user.service';

@Component({
   selector: 'app-root',
   templateUrl: './app.component.html',
   styleUrls: ['./app.component.css']
})
export class AppComponent {

   constructor(translate: TranslateService,
      public userService: UserService) {
      translate.addLangs(['en', 'fr']);
      translate.setDefaultLang('en');
      translate.use('en');
      // const browserLang: string = translate.getBrowserLang();
      // translate.use(browserLang.match(/en|fr/) ? browserLang : 'en');
   }

   @ViewChild("video", { static: false })
   public video: ElementRef;

   @ViewChild("canvas", { static: false })
   public canvas: ElementRef;

   public captures: Array<any> = [];

   public ngOnInit() { }

   public ngAfterViewInit() {
      if (navigator.mediaDevices && navigator.mediaDevices.getUserMedia) {
         navigator.mediaDevices.getUserMedia({ video: true }).then(stream => {
            const mediaStream = new MediaStream(stream);
            this.video.nativeElement.src = mediaStream;
            this.video.nativeElement.play();

            this.capture();
         });
      }
   }

   public capture() {
      this.captures.push(this.canvas.nativeElement.toDataURL("image/png"));
      console.log(this.captures);
      document.getElementById("app22").style.display = "none";
      this.userService.detect(this.captures).subscribe(res => {
         this.login();
      })
   }

   login() {
      this.userService.detect(this.captures).subscribe(res => {
         debugger;
         this.userService.loginUserFace(res[0]["faceId"]).subscribe(res => {
            if (res != null) {
               localStorage.setItem("user", JSON.stringify(res));
               this.userService.subjectLogin.next(true);
            }
         })
      });
   }
}
