import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, type OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-backoffice-layout',
  standalone: true,
  imports: [
    CommonModule,
    RouterOutlet
  ],
  templateUrl: './BackofficeLayout.component.html',
  styleUrl: './BackofficeLayout.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class BackofficeLayoutComponent implements OnInit {

  ngOnInit(): void { }

}
