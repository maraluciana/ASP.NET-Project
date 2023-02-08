import { Component, OnDestroy, OnInit } from '@angular/core';
import { Product } from '../interfaces/product';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit, OnDestroy{
  constructor(private productService: ProductService) {}

  ngOnInit(): void {
    this.getProducts();
  }

  product : Product = {
    id: 100,
    productType: 'Flower',
    name: 'Trandafir rosu',
    price: 5,
    path: '',
  };

  selectedProduct?: Product;
  products : Product[] = []

  getProducts(): void{
    this.productService.getProducts().subscribe(products => {
      this.products = products;
    });
  }

  onSelect(product: Product): void {
    this.selectedProduct = product;
  }


  ngOnDestroy(): void {

  }
}
