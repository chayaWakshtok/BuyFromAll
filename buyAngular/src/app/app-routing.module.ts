import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ItemlistComponent } from './component/item/itemlist/itemlist.component';


const routes: Routes = [
  { path: "", component: ItemlistComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
