import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { FrontofficeModule } from './FrontOffice/frontoffice.module';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, FrontofficeModule, RouterOutlet],
  template: "<router-outlet></router-outlet>"
})
export class AppComponent {}
