import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, type OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NavbarComponent } from '../../../FrontOffice/Components/Navbar/Navbar.component';
import { FooterComponent } from '../../../FrontOffice/Components/Footer/Footer.component';

@Component({
  selector: 'app-default-layout',
  standalone: true,
  imports: [
    CommonModule,
    RouterOutlet,
    NavbarComponent,
    FooterComponent
  ],
  templateUrl: './DefaultLayout.component.html',
  styles: '',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class DefaultLayoutComponent implements OnInit {

  constructor() {}

  ngOnInit(): void {

  }

}
