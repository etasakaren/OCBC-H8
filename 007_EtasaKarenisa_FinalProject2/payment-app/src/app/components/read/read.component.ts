import { Component, Input, OnInit, TemplateRef, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { ItemDataService } from 'src/app/services/item-data.service';
import { CreateComponent } from '../create/create.component';
import { DeleteComponent } from '../delete/delete.component';

@Component({
  selector: 'app-read',
  templateUrl: './read.component.html',
  styleUrls: ['./read.component.css']
})
export class ReadComponent implements OnInit {
  @Input()
  id?: number;
  reads: any;

  constructor(private itemDataService: ItemDataService, private router: Router) { }

  ngOnInit(): void {
    this.retrieveEmployee();
  }

  retrieveEmployee(): void {
    this.itemDataService.getAll()
      .subscribe(
        data => {
          this.reads = data;
        },
        error => {
          console.log(error);
        });
  }

  delete(id: number): void {
    // let deleteComponent = new DeleteComponent(this.itemDataService, this.router);
    // deleteComponent.delete(id);
  }

  create(): void {
    this.router.navigate(['/create']);
  }

  data = false;
  edit(id:number) {
    this.id = id;
    this.data = true;
    this.router.navigate(['/update', id]);
  }

}
