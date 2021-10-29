import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Products } from '../models/Products';
import { ProductsService } from '../services/products.service';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent {

  productId: string;
  product : Products= {} as Products;
  productService: ProductsService;

  products: any[] = [
    { id: 1, code: "ABCD0902830840", name: "Dog T-Shirt", price: 100 },
    { id: 2, code: "ABCD0902830840", name: "Cat T-Shirt", price: 110 },
    { id: 3, code: "POKM2938479840", name: "Sneakers", price: 10 },
    { id: 4, code: "POKM2938479840", name: "High Heels", price: 200 },
    { id: 5, code: "GFDK9999030840", name: "Coach", price: 1000 },
  ]

  constructor(private actRoute: ActivatedRoute, productService: ProductsService) {
    this.productId = this.actRoute.snapshot.params.id;
    this.productService = productService;
  }
  
  ngOnInit(): void {
    this.getOneProduct(this.productId)
  }

  getOneProduct(id: string) {
    this.productService.getOneProduct(id).subscribe(p => this.product = p)
  }

}
