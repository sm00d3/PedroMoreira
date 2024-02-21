import { Injectable, WritableSignal, signal } from '@angular/core';
import { ProjectInterface } from '../Data/Project/ProjectInterface';

  const projectData: ProjectInterface[] = [
    {
      Id: 1,
      Name: "My Rangel",
      Description: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Minus, alias dolore, sit, eum eligendi doloribus atque magni accusamus voluptas nam perspiciatis culpa. Culpa sint id quo soluta, quibusdam rerum. Quasi!",
      Company: "Rangel",
      StartDate: new Date("11/01/2019"),
      EndDate: new Date("07/01/2022"),
      Image: "https://www.rangel.com/fotos/gca/my_rangel_imagem_1_1628765514656de96d69937.png",
      ProjectUrl: "https://www.rangel.com/",
      Images: [
        { Id: 1, Url: "https://dummyimage.com/600x400/a8a8a8/000000.jpg", Title: "Example1" },
        { Id: 2, Url: "https://dummyimage.com/600x400/a8a8a8/000&text=Example2", Title: "Example2" },
        { Id: 3, Url: "https://dummyimage.com/600x400/a8a8a8/000&text=Example3", Title: "Example3" }
      ],
      Stack: [
        "Angular",
        "Angular Materials",
        "RXJS",
        "BootStrap",
        "DotNet Core",
        "SqlServer",
        "Tibco",
        "Entity Framework Core"
      ]
    },
    {
      Id: 2,
      Name: "Square Hub",
      Description: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Minus, alias dolore, sit, eum eligendi doloribus atque magni accusamus voluptas nam perspiciatis culpa. Culpa sint id quo soluta, quibusdam rerum. Quasi!",
      Company: "IT Square",
      StartDate: new Date("05/01/2022"),
      EndDate: new Date("07/01/2022"),
      Image: "http://localhost:4200/assets/img/img_not_found.png",
      ProjectUrl: "https://itsquare.pt/",
      Images: [
        { Id: 1, Url: "https://dummyimage.com/600x400/a8a8a8/000000.jpg", Title: "Example1" },
        { Id: 2, Url: "https://dummyimage.com/600x400/a8a8a8/000&text=Example2", Title: "Example2" },
        { Id: 3, Url: "https://dummyimage.com/600x400/a8a8a8/000&text=Example3", Title: "Example3" }
      ],
      Stack: [
        "React",
        "DotNet Core",
        "Entity Framework Core",
        "Mysql"
      ]
    },
    {
      Id: 3,
      Name: "Weasy",
      Description: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Minus, alias dolore, sit, eum eligendi doloribus atque magni accusamus voluptas nam perspiciatis culpa. Culpa sint id quo soluta, quibusdam rerum. Quasi!",
      Company: "Teya",
      StartDate: new Date("07/01/2022"),
      EndDate: new Date("01/01/2024"),
      Image: "http://localhost:4200/assets/img/Weasy-dashboard.png",
      ProjectUrl: "https://weasy.io/",
      Images: [
        { Id: 1, Url: "https://dummyimage.com/600x400/a8a8a8/000000.jpg", Title: "Example1" },
        { Id: 2, Url: "https://dummyimage.com/600x400/a8a8a8/000&text=Example2", Title: "Example2" },
        { Id: 3, Url: "https://dummyimage.com/600x400/a8a8a8/000&text=Example3", Title: "Example3" }
      ],
      Stack: [
        "PHP",
        "jquery",
        "Kubernets",
        "Docker",
        "Tekton",
        "ArgoCD",
        "Sql",
        "Postgres",
        "Mysql"
      ]
    },
  ];

@Injectable({
  providedIn: 'root'
})
export class ProjectService {

  constructor() { }

  public getProjects(): WritableSignal<ProjectInterface[]> {

    return signal<ProjectInterface[]>(projectData);
  }

  public getProjectById(Id: number): ProjectInterface | null {
    return projectData.find((value) => value.Id == Id)!;
  }

}
