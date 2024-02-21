import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Pages/Home/Home.component';
import { ProjectListComponent } from './Pages/Projects/ProjectList/ProjectList.component';
import { ProjectDetailComponent } from './Pages/Projects/Project-Detail/Project-Detail.component';
import { ProfileComponent } from './Pages/Profile/Profile.component';
import { ContactComponent } from './Pages/Contact/Contact.component';

const routes: Routes = [
  { path: "", component: HomeComponent },
  {
    path: "projects",
    children: [
      { path: "", component: ProjectListComponent },
      { path: ":id", component: ProjectDetailComponent}
    ]
  },
  { path: "profile", component: ProfileComponent },
  { path: "contact", component: ContactComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FrontofficeRoutingModule { }

