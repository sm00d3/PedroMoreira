import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Pages/Home/Home.component';

const routes: Routes = [
  { path: "", component: HomeComponent },
  { path: "projects", component: HomeComponent },
  {
    path: "profile",
    children: [
      {path: "", component: HomeComponent, pathMatch: 'full' }
    ]
  },
  { path: "contact", component: HomeComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FrontofficeRoutingModule { }
