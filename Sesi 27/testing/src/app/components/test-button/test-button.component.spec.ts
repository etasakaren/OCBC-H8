import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TestButtonComponent } from './test-button.component';

describe('TestButtonComponent', () => {
  let component: TestButtonComponent;
  let fixture: ComponentFixture<TestButtonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TestButtonComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TestButtonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it(`should have a title 'click me'`, (()=>{
    fixture = TestBed.createComponent(TestButtonComponent);
    component = fixture.debugElement.componentInstance;
    expect(component.name).toEqual('click me');
  }));

  it('should render title', ()=>{
    const fixture = TestBed.createComponent(TestButtonComponent);
    fixture.detectChanges();
    const compiled = fixture.nativeElement as HTMLElement;
    expect(compiled.querySelector('h1.name')?.textContent).toContain('click me');
  })
});
