import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { Item } from 'src/app/Modals/item';
import { Brand } from 'src/app/Modals/brand';
import { Category } from 'src/app/Modals/category';
import { ItemService } from 'src/app/Services/item.service';
import { Router } from '@angular/router';

@Component({
   selector: 'app-add-product',
   templateUrl: './AddProduct.component.html',
   styleUrls: ['./AddProduct.component.scss']
})

export class AddProductComponent implements OnInit {

   form: FormGroup;
   mainImgPath: string;
   // colorsArray: string[] = ["Red", "Blue", "Yellow", "Green"];
   // sizeArray: number[] = [36, 38, 40, 42, 44, 46, 48];
   // quantityArray: number[] = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
   public imagePath;
   product: Item = new Item();

   "data": any = [
      {
         "image": "https://via.placeholder.com/625x800",
         "image_gallery": [
            "https://via.placeholder.com/625x800",
            "https://via.placeholder.com/625x800",
            "https://via.placeholder.com/625x800",
            "https://via.placeholder.com/625x800",
            "https://via.placeholder.com/625x800"
         ]
      }
   ]

   constructor(public formBuilder: FormBuilder,
      public itemService: ItemService,
      public router: Router) { }

   ngOnInit() {

      this.mainImgPath = this.data[0].image;
      this.form = this.formBuilder.group({
         name: [],
         price: [],
         availablity: [],
         product_code: [],
         description: [],
         tags: [],
         features: [],
         quantity: 0,
         category: [],
         categoryType: [],
         brand: [],
         discountPrice: [],
         site: [],
         type: [],
      });
   }

   /**
    * getImagePath is used to change the image path on click event. 
    */
   public getImagePath(imgPath: string, index: number) {
      document.querySelector('.border-active').classList.remove('border-active');
      this.mainImgPath = imgPath;
      document.getElementById(index + '_img').className += " border-active";
   }

   add() {
      debugger;
      this.product = new Item();
      this.product.productCode = this.form.value['product_code'];
      this.product.customerId = 1;
      this.product.siteId = 2;
      this.product.brand = new Brand();
      this.product.brand.name = this.form.value['brand'];
      this.product.availablity = true;
      this.product.category = new Category();
      this.product.category1 = new Category();
      this.product.category.name = this.form.value['category'];
      this.product.category1 = this.form.value['categoryType'];
      this.product.description = this.form.value['description'];
      this.product.discountPrice = this.form.value['discountPrice'];
      this.product.name = this.form.value['name'];
      this.product.popular = true;
      this.product.price = this.form.value['price'];
      this.product.quantity = this.form.value['quantity'];
      this.product.rating = 0;
      this.product.status = true;
      this.product.type = this.form.value['type'];
      this.itemService.addProduct(this.product).subscribe(res => {
         this.router.navigate(["products"]);
      })

   }
}
