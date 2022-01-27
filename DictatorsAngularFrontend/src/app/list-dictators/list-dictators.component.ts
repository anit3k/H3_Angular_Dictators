import { Component, OnDestroy, OnInit } from '@angular/core';
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
  diactators: IDictatorModel[] = [];
  dataLoaded: boolean = false;  
  deleteStatus: string = "";

  constructor(private dicSer: DictatorApiService) { }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }

  ngOnInit(): void {
    this.getAllDictators();
  }

  private getAllDictators() {
    this.sub = this.dicSer.getDictators().subscribe((list: IDictatorModel[]) => {
      next: this.diactators = list;
      complete: if (list.length > 0) {
        this.dataLoaded = true;
      }
    });
  }

  deleteDictator(id: string) {
    this.dicSer.deleteDictator(id)
    .subscribe(() => {this.deleteStatus = "Dictator is deleted from history!"});
    this.getAllDictators();
  }
}
