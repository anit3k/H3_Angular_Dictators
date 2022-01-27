import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { DictatorApiService } from '../services/dictator-api.service';

@Component({
  selector: 'dic-add-dictator',
  templateUrl: './add-dictator.component.html',
  styleUrls: ['./add-dictator.component.css']
})
export class AddDictatorComponent implements OnInit {

  dictatorForm = this.fb.group({
    firstName:['', [Validators.required], Validators.maxLength(5)],
    lastName:['', [Validators.required], Validators.maxLength(80)],
    birth: [''],
    death: [''],
    description: ['',[Validators.required]]
  })

  constructor(private fb: FormBuilder, private dicSer: DictatorApiService) { }

  ngOnInit(): void {
  }

  submitDictator(){
    this.dicSer.postDictator(this.dictatorForm.value)
      .subscribe(dic => this.dictatorForm.value);
  }

}
