import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute, Params }   from '@angular/router';
import { EmbryoService } from '../../../Services/Embryo.service';
import { Item } from 'src/app/Modals/item';

@Component({
  selector: 'app-DetailPage',
  templateUrl: './DetailPage.component.html',
  styleUrls: ['./DetailPage.component.scss']
})
export class DetailPageComponent implements OnInit {

   id                : any;
   type              : any;
   apiResponse       : any;
   singleProductData : Item=new Item();
   productsList      : Item[]=[];

   constructor(private route: ActivatedRoute,
              private router: Router,
              public embryoService: EmbryoService) {
      
   }

   ngOnInit() {
      this.route.params.subscribe(res => {
         this.id = res.id;
         //this.type = res.type;
         this.getData();
      })
   }

   public getData() {
      this.embryoService.getProductById(this.id).subscribe(res => this.checkResponse(res));
   }

   public checkResponse(response) {
     this.singleProductData=response;
   }

   public addToCart(value) {
      this.embryoService.addToCart(value);
   }

   public addToWishList(value) {
      this.embryoService.addToWishlist(value);
   }

}
