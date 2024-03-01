import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, OnInit} from '@angular/core';
import { SlideComponent } from '../../../Components/Slide/Slide.component';
import { ProjectService } from '../../../Services/Project.service';
import { ProjectInterface } from '../../../Data/Project/ProjectInterface';
import { ActivatedRoute, Route, Router } from '@angular/router';

@Component({
  selector: 'app-project-detail',
  standalone: true,
  imports: [
    CommonModule,
    SlideComponent
  ],
  templateUrl: './Project-Detail.component.html',
  styles: "",
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ProjectDetailComponent implements OnInit {

  project: ProjectInterface | null | undefined;

  constructor(
    private projectService: ProjectService,
    private activeRoute: ActivatedRoute,
    private router: Router,
  ) { }

  ngOnInit() {
    let Id = this.activeRoute.snapshot.paramMap.get("id");
    this.project = this.projectService.getProjectById(Number(Id) ?? -1) ?? null;
    if (this.project == null) {
      this.router.navigateByUrl("/projects")
    }
  }

}
