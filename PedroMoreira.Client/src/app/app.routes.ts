import { Routes } from '@angular/router';
import { DefaultLayoutComponent } from './Shared/layout/DefaultLayout/DefaultLayout.component';
import { BackofficeLayoutComponent } from './Shared/layout/BackofficeLayout/BackofficeLayout.component';

export const routes: Routes = [
  {
    path: "",
    component:  DefaultLayoutComponent,
    loadChildren: () => import('./FrontOffice/frontoffice.module').then(m => m.FrontofficeModule)
  },
  {
    path: "badm",
    component: BackofficeLayoutComponent,
    loadChildren: () => import('./Backoffice/backoffice.module').then(m => m.BackofficeModule),
  }

];
