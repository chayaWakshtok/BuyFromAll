import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { EmbryoService } from '../../../Services/Embryo.service';
import { UserService } from 'src/app/Services/user.service';

@Component({
   selector: 'HeaderTwo',
   templateUrl: './HeaderTwo.component.html',
   styleUrls: ['./HeaderTwo.component.scss']
})
export class HeaderTwoComponent implements OnInit {

   popupResponse: any;
   isLogin: boolean = false;

   constructor(public embryoService: EmbryoService,
      public userService: UserService,
      private cdRef: ChangeDetectorRef) { }

   ngOnInit() {
      this.isLOginUpdate();
    
   }

   isLOginUpdate() {
      debugger;
      var user = JSON.parse(localStorage.getItem("user"));
      if (user)
         this.isLogin = true;
      this.cdRef.detectChanges()

   }

   public toggleSearch() {
      document.querySelector('app-main').classList.toggle('form-open');
   }

   public toggleSidebar() {
      this.embryoService.sidenavOpen = !this.embryoService.sidenavOpen;
   }

   public openConfirmationPopup(value: any) {
      let message = "Are you sure you want to delete this product?";
      this.embryoService.confirmationPopup(message).
         subscribe(res => { this.popupResponse = res },
            err => console.log(err),
            () => this.getPopupResponse(this.popupResponse, value, 'cart')
         );
   }

   public getPopupResponse(response: any, value: any, type) {
      if (response) {
         if (type == 'cart') {
            this.embryoService.removeLocalCartProduct(value);
         } else {
            this.embryoService.removeLocalWishlistProduct(value);
         }
      }
   }

   public addAllWishlistToCart(values: any) {
      this.embryoService.addAllWishListToCart(values);
   }

   public openWishlistConfirmationPopup(value: any) {
      let message = "Are you sure you want to add all products?";
      this.embryoService.confirmationPopup(message).
         subscribe(res => { this.popupResponse = res },
            err => console.log(err),
            () => this.getPopupResponse(this.popupResponse, value, 'wishlist')
         );
   }

   public selectedCurrency(value) {
      this.embryoService.currency = value;
   }

   public selectedLanguage(value) {
      this.embryoService.language = value;
   }

   public addToCart(value) {
      this.embryoService.addToCart(value, 'wishlist');
   }

}
