import { Component, OnDestroy, OnInit } from '@angular/core';
import { Product } from '../interfaces/product';
import { ProductService } from '../product.service';
import { Location } from '@angular/common';

@Component({
  selector: 'app-bonsai',
  templateUrl: './bonsai.component.html',
  styleUrls: ['./bonsai.component.css']
})
export class BonsaiComponent implements OnInit, OnDestroy{
  constructor(private productService: ProductService,
    private location: Location) {}

  ngOnInit(): void {
    this.getProducts();
  }

  selectedProduct?: Product;
  products : Product[] = []

  getProducts(): void{
    this.productService.getProductsType('bonsai').subscribe(products => {
      this.products = products;
    });
  }

  onSelect(product: Product): void {
    this.selectedProduct = product;
  }

  goBack(): void {
    this.location.back();
  }

  ngOnDestroy(): void {

  }
}
