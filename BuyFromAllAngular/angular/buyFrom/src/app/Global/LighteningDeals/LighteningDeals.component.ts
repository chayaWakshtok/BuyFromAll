import { Component, OnInit, Input } from '@angular/core';
import { Item } from 'src/app/Modals/item';

@Component({
  selector: 'embryo-LighteningDeals',
  templateUrl: './LighteningDeals.component.html',
  styleUrls: ['./LighteningDeals.component.scss']
})
export class LighteningDealsComponent implements OnInit {

   @Input() lighteningDeals : Item[];
   @Input() currency:string= 'ILS';

   constructor() { }

   ngOnInit() {
   }

}
