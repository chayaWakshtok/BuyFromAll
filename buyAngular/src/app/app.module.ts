import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './component/user/login/login.component';
import { RegisterComponent } from './component/user/register/register.component';
import { ForgetPasswordComponent } from './component/user/forget-password/forget-password.component';
import { ConfirmPasswordComponent } from './component/user/confirm-password/confirm-password.component';
import { BasketComponent } from './component/user/basket/basket.component';
import { WishlistComponent } from './component/user/wishlist/wishlist.component';
import { ItemlistComponent } from './component/item/itemlist/itemlist.component';
import { ItemDetailsComponent } from './component/item/item-details/item-details.component';
import { OrderComponent } from './component/user/order/order.component';
import { CheckoutComponent } from './component/user/checkout/checkout.component';
import { PaymentComponent } from './component/user/payment/payment.component';
import { AddItemComponent } from './component/customer/add-item/add-item.component';
import { SearchComponent } from './component/user/search/search.component';
import { NavbarComponent } from './component/navbar/navbar.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { ItemTemplateComponent } from './component/item/item-template/item-template.component';
import { CartComponent } from './component/item/cart/cart.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    ForgetPasswordComponent,
    ConfirmPasswordComponent,
    BasketComponent,
    WishlistComponent,
    ItemlistComponent,
    ItemDetailsComponent,
    OrderComponent,
    CheckoutComponent,
    PaymentComponent,
    AddItemComponent,
    SearchComponent,
    NavbarComponent,
    ItemTemplateComponent,
    CartComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FontAwesomeModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
