import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddDictatorComponent } from './add-dictator.component';

describe('AddDictatorComponent', () => {
  let component: AddDictatorComponent;
  let fixture: ComponentFixture<AddDictatorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddDictatorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddDictatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
