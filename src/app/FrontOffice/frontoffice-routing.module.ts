import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Pages/Home/Home.component';
import { DefaultLayoutComponent } from '../Shared/layout/DefaultLayout/DefaultLayout.component';

const routes: Routes = [
  {
    path: "",
    component: HomeComponent
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FrontofficeRoutingModule { }
