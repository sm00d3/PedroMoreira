import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Pages/Home/Home.component';
import { ProjectListComponent } from './Pages/Projects/ProjectList/ProjectList.component';
import { ProfileComponent } from './Pages/Profile/Profile.component';

const routes: Routes = [
  { path: "", component: HomeComponent },
  {
    path: "projects",
    children: [
      { path: "", component: ProjectListComponent }
    ]
  },
  {
    path: "profile",
    children: [
      {path: "", component: ProfileComponent, pathMatch: 'full' }
    ]
  },
  { path: "contact", component: HomeComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FrontofficeRoutingModule { }

