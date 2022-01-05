import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MarketPlaceComponent } from './components/market-place/market-place.component';
import { OrderingComponent } from './components/ordering/ordering.component';


const routes: Routes = [
  {
    path: 'MarketPlace',
    component: MarketPlaceComponent
  },
  {
    path: 'Ordering',
    component: OrderingComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
