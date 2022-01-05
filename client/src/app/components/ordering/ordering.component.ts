import { Component, OnInit } from '@angular/core';
import { SaleItem } from 'src/app/models/sale-item';

@Component({
  selector: 'app-ordering',
  templateUrl: './ordering.component.html',
  styleUrls: ['./ordering.component.scss']
})
export class OrderingComponent implements OnInit {

  items: SaleItem[] = [];
  shoppers: number = 0;

  constructor() { }

  ngOnInit() {
  }

  
}
