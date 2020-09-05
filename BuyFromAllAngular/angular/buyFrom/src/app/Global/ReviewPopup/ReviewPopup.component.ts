import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material';
import { UserComment } from 'src/app/Modals/userComment';
import { Item } from 'src/app/Modals/item';

@Component({
  selector: 'app-ReviewPopup',
  templateUrl: './ReviewPopup.component.html',
  styleUrls: ['./ReviewPopup.component.scss']
})
export class ReviewPopupComponent implements OnInit {

   singleProductDetails : Item=new Item();
   reviews : UserComment[]=[];

   constructor(public dialogRef: MatDialogRef<ReviewPopupComponent>) { }

   ngOnInit() {
   }

}
