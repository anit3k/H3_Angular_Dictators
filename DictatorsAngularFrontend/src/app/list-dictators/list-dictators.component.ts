import { HttpClientModule } from '@angular/common/http';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { DictatorApiService } from '../services/dictator-api.service';
import { IDictatorModel } from '../Models/dictatorModel';

@Component({
  selector: 'dic-list-dictators',
  templateUrl: './list-dictators.component.html',
  styleUrls: ['./list-dictators.component.css']
})
export class ListDictatorsComponent implements OnInit, OnDestroy {

  sub!: Subscription;

  list: IDictatorModel[] = [];
  
  dictatorForm = this.fb.group({
    firstName:['', [Validators.required], Validators.minLength(80)],
    lastName:['', [Validators.required], Validators.minLength(80)],
    birth: [''],
    death: [''],
    description: ['',[Validators.required]]
  })

  constructor(private dicSer: DictatorApiService, private fb: FormBuilder) { }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }



  ngOnInit(): void {
    this.sub = this.dicSer.getDictators().subscribe((list: IDictatorModel[]) => {
      next: this.list = list;      
    })
  }

}
