import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
import { Injectable } from '@angular/core';


@Injectable()
export class MakeService {

  constructor(private http :Http) { }

getMakes(){

  return this.http.get('/api/makes')
      .map(res => res.json())
    
}


}
