import { Component, OnInit } from '@angular/core';
 import { DataserviceService } from '../service/dataservice.service';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  //constructor() { }
  users:any;
  constructor(private DataService:DataserviceService )
  {
   // console.warn(DataService.users())
    this.DataService.users().subscribe((data)=>{
      //console.warn("data",data);
      this.users=data;
      console.warn("data",data);
    });
  }

  // users:any;
  // constructor(private DataService:DataserviceService )
  // {
  //   console.warn(DataService.users())
  //   this.users =DataService.users();
  // }

  ngOnInit(): void {
  }

}
