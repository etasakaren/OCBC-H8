import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.css']
})
export class ButtonComponent implements OnInit {
  @Input() name ='';
  message = '';

  @Output() clickEventHandler = new EventEmitter<string>();

  constructor() { }
  //a function to handle event
  onButtonClick(){
    this.clickEventHandler.emit()
  }
  ngOnInit(): void {
  }

}
