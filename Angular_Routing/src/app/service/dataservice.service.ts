import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DataserviceService {

url ="https://reqres.in/api/users";

  constructor(private http:HttpClient) { }
  users()
  {
    return this.http.get(this.url);
    // return [
    //     {name:'Sanjana',age:20,email:'sk@gmail.com' },
    //     {name:'Raj',age:22,email:'skgh@gmail.com' },
    //     {name:'Krishu',age:24,email:'ssdfk@gmail.com' },
    //     {name:'Peter',age:25,email:'rtyusk@gmail.com' },

    // ]
  }
}
