import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Product } from './interfaces/product';
import { PRODUCTS } from './mock-products';


@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor() { }

  getProducts(): Observable<Product[]>{
    return of(PRODUCTS);
  }
}
