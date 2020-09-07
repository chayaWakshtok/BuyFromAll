import { Component, OnInit, Input, Output, EventEmitter} from '@angular/core';
import { Item } from 'src/app/Modals/item';

@Component({
  selector: 'embryo-TopProducts',
  templateUrl: './TopProducts.component.html',
  styleUrls: ['./TopProducts.component.scss']
})
export class TopProductsComponent implements OnInit {

   @Input() products : Item[];

   @Input() currency : any;

   @Output() addToCart : EventEmitter<any> = new EventEmitter();

   gridLength = 4;
   randomSortProducts : Item[]=[];

   constructor() { }

   ngOnInit() {
      if(this.products){
         this.randomSortProducts = this.products.sort( () => Math.random() - 0.5);
      }
   }

   public addToCartProduct(value:any) {
      value.status = 1;
      this.addToCart.emit(value);
   }

   public extendGridStructure(status) {
      if(status){
         if(this.gridLength != 12){
            this.gridLength += 4;
         }
      } else {
         if(this.gridLength != 4){
            this.gridLength -= 4;
         }
      }
   }

}