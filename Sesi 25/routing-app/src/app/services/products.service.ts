import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { PRODUCTS } from '../models/mock-products';
import { Products } from '../models/Products';
import { ProductsComponent } from '../products/products.component';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  constructor() { }

  products = of(PRODUCTS);
  getProducts(): Observable<Products[]> {
    const products = of(PRODUCTS);
    return products;
  }


  getOneProduct(id: string): Observable<Products> {
    return this.products.pipe(map(products => products.filter(product => product.id == id)[0]))

  }

}
