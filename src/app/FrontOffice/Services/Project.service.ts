import { Injectable, WritableSignal, signal } from '@angular/core';
import { Project } from '../Data/Project';

  const projectData: Project[] = [
    {
      Id: 1,
      Name: "My Rangel",
      Image: "https://www.rangel.com/fotos/gca/my_rangel_imagem_1_1628765514656de96d69937.png",
      ProjectUrl: "https://www.rangel.com/"
    },
    {
      Id: 2,
      Name: "Square Hub",
      Image: "http://localhost:4200/assets/img/img_not_found.png",
      ProjectUrl: "https://itsquare.pt/"
    },
    {
      Id: 3,
      Name: "Weasy",
      Image: "http://localhost:4200/assets/img/Weasy-dashboard.png",
      ProjectUrl: "https://weasy.io/"
    },
  ];

@Injectable({
  providedIn: 'root'
})
export class ProjectService {

  constructor() { }

  public getProjects(): WritableSignal<Project[]> {

    return signal<Project[]>(projectData);
  }

}
