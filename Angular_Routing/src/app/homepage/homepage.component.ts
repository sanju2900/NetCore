import { Component, OnInit } from '@angular/core';
import { DataserviceService } from '../service/dataservice.service';

@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent implements OnInit {

 
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
