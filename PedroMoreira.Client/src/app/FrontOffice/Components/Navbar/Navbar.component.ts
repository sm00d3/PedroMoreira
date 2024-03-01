import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, ElementRef, ViewChild, signal } from '@angular/core';
import { GeneralService } from '../../../Global/General.service';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [
    CommonModule,
    RouterModule
  ],
  templateUrl: './Navbar.component.html',
  styleUrl: './Navbar.component.scss',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class NavbarComponent {

  public nvm = signal<boolean>(false);

  constructor(public globalServ: GeneralService) { }

}
