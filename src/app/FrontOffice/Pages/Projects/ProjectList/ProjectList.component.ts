import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component } from '@angular/core';
import { ProjectService } from '../../../Services/Project.service';

@Component({
  selector: 'app-project-list',
  standalone: true,
  imports: [
    CommonModule,
  ],
  templateUrl: './ProjectList.component.html',
  styleUrl: './ProjectList.component.scss',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ProjectListComponent {

  projects = this.projectService.getProjects();

  constructor(private projectService: ProjectService) {}

}
