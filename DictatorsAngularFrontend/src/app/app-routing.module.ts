import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CommonModule } from '@angular/common';
import { AddDictatorComponent } from './add-dictator/add-dictator.component';
import { ListDictatorsComponent } from './list-dictators/list-dictators.component';

const routes: Routes = [
  { path: 'add-dictator', component: AddDictatorComponent},
  { path: 'list-dictators', component: ListDictatorsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
