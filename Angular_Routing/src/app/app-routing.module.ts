import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomepageComponent } from './homepage/homepage.component';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { UserComponent } from './user/user.component';
import { ContactComponent } from './contact/contact.component';
const routes: Routes = [
  {
    path:'',
    component:HomepageComponent
  },
  {
    path:'home',
    component:HomeComponent
  },

  {

    path:'about',
    component:AboutComponent
  },
  
  {
  
    path:'user',
  
    component:UserComponent
  
  },
  
  {
  
    path:'contact',
  
    component:ContactComponent
  
  }

  
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
