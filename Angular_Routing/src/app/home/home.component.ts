import { Component, OnInit } from '@angular/core';
import { DataserviceService } from '../service/dataservice.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

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

  ngOnInit(): void {
  }

}
