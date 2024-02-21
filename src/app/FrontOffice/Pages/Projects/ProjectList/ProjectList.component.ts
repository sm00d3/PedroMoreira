import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, OnInit, signal } from '@angular/core';
import { ProjectService } from '../../../Services/Project.service';
import { FormControl, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-project-list',
  standalone: true,
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    RouterLink
  ],
  templateUrl: './ProjectList.component.html',
  styleUrl: './ProjectList.component.scss',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ProjectListComponent implements OnInit {

  projects = this.projectService.getProjects()
  search = new FormControl("");

  constructor(private projectService: ProjectService) { }

  public ngOnInit(): void {
    this.search.valueChanges.subscribe((value) => {
      var allValues = this.projectService.getProjects();

      if (value != "") {
        allValues.set(allValues().filter((proj) => proj.Name?.toLowerCase().includes(value!.toLowerCase())));
      }

      this.projects.set(allValues());
    });
  }

}
