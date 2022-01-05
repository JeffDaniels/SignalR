import { Component, OnInit } from '@angular/core';
import { SaleItem } from 'src/app/models/sale-item';

@Component({
  selector: 'app-market-place',
  templateUrl: './market-place.component.html',
  styleUrls: ['./market-place.component.scss']
})
export class MarketPlaceComponent implements OnInit {

  items: SaleItem[] = [];
  shoppers: number = 0;

  constructor() { }

  ngOnInit() {

  } 

}
