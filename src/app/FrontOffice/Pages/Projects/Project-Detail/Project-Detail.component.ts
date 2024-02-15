import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component } from '@angular/core';

@Component({
  selector: 'app-project-detail',
  standalone: true,
  imports: [
    CommonModule,
  ],
  templateUrl: './Project-Detail.component.html',
  styleUrl: './Project-Detail.component.scss',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ProjectDetailComponent {

}
