import { Component } from '@angular/core';
 import { DataserviceService } from './service/dataservice.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'API call And Angular_Routing';
  
  users:any;
  constructor(private DataService:DataserviceService )
  {
   // console.warn(DataService.users())
    this.DataService.users().subscribe((data)=>{
      //console.warn("data",data);
      this.users=data;
    });
  }
}
