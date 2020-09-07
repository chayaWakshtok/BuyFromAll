import { Component, OnInit, AfterViewInit } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, FormArray, Validators } from '@angular/forms';
import { EmbryoService } from '../../../Services/Embryo.service';
import { Router, NavigationEnd } from '@angular/router';
import { IPayPalConfig, ICreateOrderRequest } from 'ngx-paypal';
import { Order } from 'src/app/Modals/order';
import { Payment } from 'src/app/Modals/payment';
import { OrderItem } from 'src/app/Modals/orderItem';
import { OrderService } from 'src/app/Services/order.service';

@Component({
   selector: 'app-Payment',
   templateUrl: './Payment.component.html',
   styleUrls: ['./Payment.component.scss']
})
export class PaymentComponent implements OnInit, AfterViewInit {

   public payPalConfig?: IPayPalConfig;
   step = 0;
   isDisabledPaymentStepTwo = true;
   isDisabledPaymentStepThree = false;
   emailPattern: any = /\S+@\S+\.\S+/;
   offerCards: any = [
      {
         id: 1,
         name: "Debit Card",
         content: "Visa Mega Shopping Offer"
      },
      {
         id: 2,
         name: "Credit Card",
         content: "American Express 20% Flat"
      },
      {
         id: 3,
         name: "Debit Card",
         content: "BOA Buy 1 Get One Offer"
      },
      {
         id: 4,
         name: "Master Card",
         content: "Mastercard Elite Card"
      },
      {
         id: 5,
         name: "Debit Card",
         content: "Visa Mega Shopping Offer"
      }
   ]

   bankCardsImages: any = [
      {
         id: 1,
         image: "assets/images/client-logo-1.png"
      },
      {
         id: 2,
         image: "assets/images/client-logo-2.png"
      },
      {
         id: 3,
         image: "assets/images/client-logo-3.png"
      },
      {
         id: 4,
         image: "assets/images/client-logo-4.png"
      },
      {
         id: 5,
         image: "assets/images/client-logo-5.png"
      }
   ]

   paymentFormOne: FormGroup;

   constructor(public embryoService: EmbryoService,
      private formGroup: FormBuilder,
      public router: Router,
      public orderService: OrderService) {

      this.embryoService.removeBuyProducts();
   }

   ngOnInit() {
      this.initConfig();
      this.embryoService.calculateLocalCartProdCounts();


      this.paymentFormOne = this.formGroup.group({
         user_details: this.formGroup.group({
            first_name: ['', [Validators.required]],
            last_name: ['', [Validators.required]],
            street_name_number: ['', [Validators.required]],
            apt: ['', [Validators.required]],
            zip_code: ['', [Validators.required]],
            city_state: ['', [Validators.required]],
            country: ['', [Validators.required]],
            mobile: ['', [Validators.required]],
            email: ['', [Validators.required, Validators.pattern(this.emailPattern)]],
            share_email: ['', [Validators.pattern(this.emailPattern)]],
         }),
         offers: this.formGroup.group({
            discount_code: [''],
            card_type: [1],
            card_type_offer_name: [null]
         }),
         // payment: this.formGroup.group({
         //    card_number: ['', [Validators.required]],
         //    user_card_name: ['', [Validators.required]],
         //    cvv: ['', [Validators.required]],
         //    expiry_date: ['', [Validators.required]],
         //    card_id: [1],
         //    bank_card_value: [null]
         // })
      });
   }

   private initConfig(): void {
      this.payPalConfig = {
         currency: 'EUR',
         clientId: 'sb',
         createOrderOnClient: (data) => <ICreateOrderRequest>{
            intent: 'CAPTURE',
            purchase_units: [{
               amount: {
                  currency_code: 'EUR',
                  value: '9.99',
                  breakdown: {
                     item_total: {
                        currency_code: 'EUR',
                        value: '9.99'
                     }
                  }
               },
               items: [{
                  name: 'Enterprise Subscription',
                  quantity: '1',
                  category: 'DIGITAL_GOODS',
                  unit_amount: {
                     currency_code: 'EUR',
                     value: '9.99',
                  },
               }]
            }]
         },
         advanced: {
            commit: 'true'
         },
         style: {
            label: 'paypal',
            layout: 'vertical'
         },
         onApprove: (data, actions) => {
            console.log('onApprove - transaction was approved, but not authorized', data, actions);
            actions.order.get().then(details => {
               console.log('onApprove - you can get full order details inside onApprove: ', details);
            });

         },
         onClientAuthorization: (data) => {
            console.log('onClientAuthorization - you should probably inform your server about completed transaction at this point', data);
            //this.showSuccess = true;
         },
         onCancel: (data, actions) => {
            console.log('OnCancel', data, actions);
            // this.showCancel = true;

         },
         onError: err => {
            console.log('OnError', err);
            // this.showError = true;
         },
         onClick: (data, actions) => {
            console.log('onClick', data, actions);
            //this.resetStatus();
         }
      };
   }

   ngAfterViewInit() {
   }

   public setStep(index: number) {
      this.step = index;
      switch (index) {
         case 0:
            this.isDisabledPaymentStepTwo = true;
            this.isDisabledPaymentStepThree = true;
            break;
         case 1:
            this.isDisabledPaymentStepThree = false;
            break;
         default:

            break;
      }
   }

   public toggleRightSidenav() {
      this.embryoService.paymentSidenavOpen = !this.embryoService.paymentSidenavOpen;
   }

   public getCartProducts() {
      let total = 0;
      if (this.embryoService.localStorageCartProducts && this.embryoService.localStorageCartProducts.length > 0) {
         for (let product of this.embryoService.localStorageCartProducts) {
            if (!product.quantity) {
               product.quantity = 1;
            }
            total += (product.price * product.quantity);
         }
         total += (this.embryoService.shipping + this.embryoService.tax);
         return total;
      }
      return total;
   }

   public submitPayment() {
      let userDetailsGroup = <FormGroup>(this.paymentFormOne.controls['user_details']);
      if (userDetailsGroup.valid) {
         switch (this.step) {
            case 0:
               this.step = 1;
               this.isDisabledPaymentStepTwo = false;
               break;
            case 1:
               this.step = 2;
               break;

            default:
               // code...
               break;
         }
      } else {
         this.isDisabledPaymentStepTwo = true;
         this.isDisabledPaymentStepThree = true;
         for (let i in userDetailsGroup.controls) {
            userDetailsGroup.controls[i].markAsTouched();
         }
      }
   }

   // public selectedPaymentTabChange(value) {
   //    let paymentGroup = <FormGroup>(this.paymentFormOne.controls['payment']);

   //    paymentGroup.markAsUntouched();

   //    if (value && value.index == 1) {
   //       paymentGroup.controls['card_number'].clearValidators();
   //       paymentGroup.controls['user_card_name'].clearValidators();
   //       paymentGroup.controls['cvv'].clearValidators();
   //       paymentGroup.controls['expiry_date'].clearValidators();

   //       paymentGroup.controls['bank_card_value'].setValidators([Validators.required]);
   //    } else {

   //       paymentGroup.controls['card_number'].setValidators([Validators.required]);
   //       paymentGroup.controls['user_card_name'].setValidators([Validators.required]);
   //       paymentGroup.controls['cvv'].setValidators([Validators.required]);
   //       paymentGroup.controls['expiry_date'].setValidators([Validators.required]);

   //       paymentGroup.controls['bank_card_value'].clearValidators();
   //    }

   //    paymentGroup.controls['card_number'].updateValueAndValidity();
   //    paymentGroup.controls['user_card_name'].updateValueAndValidity();
   //    paymentGroup.controls['cvv'].updateValueAndValidity();
   //    paymentGroup.controls['expiry_date'].updateValueAndValidity();
   //    paymentGroup.controls['bank_card_value'].updateValueAndValidity();
   // }

   public finalStep() {
      // let paymentGroup = <FormGroup>(this.paymentFormOne.controls['payment']);
      // if (paymentGroup.valid) {
      debugger;
      this.embryoService.addBuyUserDetails(this.paymentFormOne.value);
      // order_items: OrderItem[] = []
      var order = new Order();
      order.userId = JSON.parse(localStorage.getItem("user")).id;
      order.totalPrice = this.getCartProducts();
      order.status = 1;
      order.paid = true;
      var userDetails = this.paymentFormOne.value;
      order.builingName = userDetails.user_details.first_name;
      order.zipCode = userDetails.user_details.zip_code;
      order.country = userDetails.user_details.country;
      order.city = userDetails.user_details.city_state
      order.mobile = userDetails.user_details.mobile;
      order.email = userDetails.user_details.email;
      order.payments = null;
      order.order_items = [];
      let product = JSON.parse(localStorage.getItem("cart_item"));

      product.forEach(element => {
         var p = new OrderItem();
         p.count = element.quantity;
         p.price = element.price;
         p.status = 1;
         p.itemId = element.id;
         order.order_items.push(p);
      });
      this.orderService.addOrder(order).subscribe(res => {
         this.router.navigate(['/checkout/final-receipt']);
      })

      // } else {
      //    for (let i in paymentGroup.controls) {
      //       paymentGroup.controls[i].markAsTouched();
      //    }
      // }
   }
}



