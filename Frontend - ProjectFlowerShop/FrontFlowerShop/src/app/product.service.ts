import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Product } from './interfaces/product';
import { PRODUCTS } from './mock-products';
import { catchError, map, tap } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private productsUrl = 'https://localhost:44362/api/Product';  // URL to web api

  constructor(private http: HttpClient) { }

  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.productsUrl + '/Get_All_Products')
    .pipe(
      catchError(this.handleError<Product[]>('getProducts', []))
    );
  }

  getProduct(id: number): Observable<Product> {
    // For now, assume that a product with the specified `id` always exists.
    // Error handling will be added in the next step of the tutorial.
    const product = PRODUCTS.find(h => h.id === id)!;
    return of(product);
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
  
      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead
  
      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
}
