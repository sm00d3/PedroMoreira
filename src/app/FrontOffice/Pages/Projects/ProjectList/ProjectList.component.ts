import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, OnInit, signal } from '@angular/core';
import { ProjectService } from '../../../Services/Project.service';
import { FormControl, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Project } from '../../../Data/Project';

@Component({
  selector: 'app-project-list',
  standalone: true,
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule
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
        allValues().map((v) => v.Name?.includes(value!) ?? v.Name);
      } else {
        this.projects = allValues;
      }
    });
  }

}
