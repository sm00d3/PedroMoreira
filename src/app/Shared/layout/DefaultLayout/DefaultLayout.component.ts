import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, HostBinding, effect, signal, type OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NavbarComponent } from '../../../FrontOffice/Components/Navbar/Navbar.component';
import { GeneralService } from '../../../Global/General.service';

@Component({
  selector: 'app-default-layout',
  standalone: true,
  imports: [
    CommonModule,
    RouterOutlet,
    NavbarComponent
  ],
  templateUrl: './DefaultLayout.component.html',
  styleUrl: './DefaultLayout.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class DefaultLayoutComponent implements OnInit {

  constructor() {}

  ngOnInit(): void {

  }

}
