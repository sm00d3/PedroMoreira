import { Component, ElementRef, HostBinding, ViewChild, effect } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { FrontofficeModule } from './FrontOffice/frontoffice.module';
import { GeneralService } from './Global/General.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, FrontofficeModule, RouterOutlet],
  template: "<router-outlet></router-outlet>"
})
export class AppComponent {
  constructor() {}
}
