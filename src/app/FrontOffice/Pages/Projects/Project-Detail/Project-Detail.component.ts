import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component } from '@angular/core';
import { SlideComponent } from '../../../Components/Slide/Slide.component';
import { SlideInterface } from '../../../Data/Slide/SlideInterface';

@Component({
  selector: 'app-project-detail',
  standalone: true,
  imports: [
    CommonModule,
    SlideComponent
  ],
  templateUrl: './Project-Detail.component.html',
  styleUrl: './Project-Detail.component.scss',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ProjectDetailComponent {

  slides: SlideInterface[] = [
    // { Id: 1, Url: "https://dummyimage.com/600x500/000/fff", Title: "Example1" },
    { Id: 1, Url: "https://dummyimage.com/600x400/a8a8a8/000000.jpg", Title: "Example1" },
    { Id: 2, Url: "https://dummyimage.com/600x400/a8a8a8/000&text=Example2", Title: "Example2" },
    { Id: 3, Url: "https://dummyimage.com/600x400/a8a8a8/000&text=Example3", Title: "Example3" },
    { Id: 4, Url: "https://dummyimage.com/600x400/a8a8a8/000&text=Example4", Title: "Example4" },
    { Id: 5, Url: "https://dummyimage.com/600x400/a8a8a8/000&text=Example5", Title: "Example5" },
    { Id: 6, Url: "https://dummyimage.com/600x400/a8a8a8/000&text=Example6", Title: "Example6" },
    { Id: 7, Url: "https://dummyimage.com/600x400/a8a8a8/000&text=Example7", Title: "Example7" },
    { Id: 8, Url: "https://dummyimage.com/600x400/a8a8a8/000&text=Example8", Title: "Example8" }
  ];

}
