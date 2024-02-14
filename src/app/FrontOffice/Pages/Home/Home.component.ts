import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, type OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import { DividerComponent } from '../../Components/Divider/Divider.component';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [
    CommonModule,
    RouterLink,
    DividerComponent
  ],
  templateUrl: './Home.component.html',
  styleUrl: './Home.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class HomeComponent implements OnInit {

  ngOnInit(): void {
  }
}
