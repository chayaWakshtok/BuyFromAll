import { Component, OnInit } from '@angular/core';
import { EmbryoService } from '../../../Services/Embryo.service';

@Component({
   selector: 'app-HomeTwo',
   templateUrl: './HomeTwo.component.html',
   styleUrls: ['./HomeTwo.component.scss']
})
export class HomeTwoComponent implements OnInit {

   topProducts: any;
   lighteningDealsProducts: any;

   constructor(public embryoService: EmbryoService) { }

   ngOnInit() {
      this.lighteningDeals();
      this.getProducts();
   }

   public lighteningDeals() {
      this.embryoService.getProducts()
         .subscribe(res => this.getLighteningDealsResponse(res));
   }

   public getLighteningDealsResponse(res) {
      let productsArray: any = [];
      this.lighteningDealsProducts = null;
      productsArray.push(this.last(res, 1));
      productsArray.push(this.last(res, 2));
      productsArray.push(this.last(res, 3));
      productsArray.push(this.last(res, 4));

      this.lighteningDealsProducts = productsArray;
   }

   last(array, num) {
      if (array.length > num)
         num = num;
      else num = 1;
      return array[array.length - num];
   }

   public getProducts() {
      this.embryoService.getProducts()
         .subscribe(res => this.getProductsResponse(res));
   }

   public getProductsResponse(res) {
      this.topProducts = null;
      let products = res;
      this.topProducts = products;
   }

   public addToCart(value) {
      this.embryoService.addToCart(value);
   }

}
