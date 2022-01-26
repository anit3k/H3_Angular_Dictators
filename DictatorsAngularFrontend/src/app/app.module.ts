import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AddDictatorComponent } from './add-dictator/add-dictator.component';
import { ListDictatorsComponent } from './list-dictators/list-dictators.component';

@NgModule({
  declarations: [
    AppComponent,
    AddDictatorComponent,
    ListDictatorsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
