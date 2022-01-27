import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IDictatorModel } from '../Models/dictatorModel';

@Injectable({
  providedIn: 'root'
})
export class DictatorApiService {

  baseURl: string = "http://localhost:5000/api/dictator";

  constructor(private http: HttpClient) { }

  getDictators(): Observable<IDictatorModel[]> {
    return this.http.get<IDictatorModel[]>(this.baseURl);
  }

  postDictator(dictator: IDictatorModel): Observable<IDictatorModel> {
    return this.http.post<IDictatorModel>(this.baseURl, dictator);
  }

  deleteDictator(dictator: any): Observable<any> {
    // const options = {
    //   headers: new HttpHeaders({
    //     'Content-Type': 'application/json'
    //   }),
    //   body: { dictator
    //   }
    // }
    return this.http.delete(this.baseURl, dictator);
  }
}
