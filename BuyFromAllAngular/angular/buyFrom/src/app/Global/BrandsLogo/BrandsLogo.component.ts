import { Component, OnInit, Input, OnChanges } from '@angular/core';

import { EmbryoService } from '../../Services/Embryo.service';
import { BrandService } from 'src/app/Services/brand.service';
import { Brand } from 'src/app/Modals/brand';

@Component({
   selector: 'embryo-BrandsLogo',
   templateUrl: './BrandsLogo.component.html',
   styleUrls: ['./BrandsLogo.component.scss']
})
export class BrandslogoComponent implements OnInit, OnChanges {

   @Input() isRTL: any;

   slideConfig: any;

   brandsLogoArray: Brand[] = [ ]

   constructor(public embryoService: EmbryoService, public brandService: BrandService) { }

   ngOnInit() {
      this.brandService.getAll().subscribe(res => {
         this.brandsLogoArray = res;
      })
   }

   ngOnChanges() {
      this.slideConfig = {
         infinite: true,
         centerMode: true,
         slidesToShow: 5,
         slidesToScroll: 2,
         autoplay: true,
         autoplaySpeed: 2000,
         rtl: this.isRTL,
         responsive: [
            {
               breakpoint: 768,
               settings: {
                  centerMode: true,
                  slidesToShow: 4,
                  slidesToScroll: 2,
                  autoplay: true,
                  autoplaySpeed: 2000
               }
            },
            {
               breakpoint: 480,
               settings: {
                  centerMode: true,
                  slidesToShow: 1,
                  autoplay: true,
                  autoplaySpeed: 2000
               }
            }
         ]
      };
   }
}
