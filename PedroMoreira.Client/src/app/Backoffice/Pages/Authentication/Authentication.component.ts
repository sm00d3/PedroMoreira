import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, type OnInit } from '@angular/core';

@Component({
  selector: 'app-authentication',
  standalone: true,
  imports: [
    CommonModule,
  ],
  templateUrl: './Authentication.component.html',
  styleUrl: './Authentication.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class AuthenticationComponent implements OnInit {

  ngOnInit(): void { }

}
