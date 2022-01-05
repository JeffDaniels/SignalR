import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MarketPlaceComponent } from './components/market-place/market-place.component';
import { OrderingComponent } from './components/ordering/ordering.component';

@NgModule({
  declarations: [
    AppComponent,
    MarketPlaceComponent,
    OrderingComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
