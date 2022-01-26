import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListDictatorsComponent } from './list-dictators.component';

describe('ListDictatorsComponent', () => {
  let component: ListDictatorsComponent;
  let fixture: ComponentFixture<ListDictatorsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListDictatorsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ListDictatorsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
