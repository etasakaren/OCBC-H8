import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-link',
  templateUrl: './link.component.html',
  styleUrls: ['./link.component.css']
})
export class LinkComponent implements OnInit {

  // linkType - jenis link
  // jika internal -> akan menggunakan routerLink
  // jika external -> akan menggunakan href
  // selebihnya tidak akan menampilkan apa-apa
  @Input() linkType = 'internal';
  @Input() linkTo: string[] = [];
  @Input() linkName = '';

  link = '';

  constructor() { }

  ngOnInit(): void {
    this.link = `${this.linkTo.join('/')}`
  }

}
