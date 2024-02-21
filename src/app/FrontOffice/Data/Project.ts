import { SlideInterface } from './Slide/SlideInterface';
export class Project {

  public Id: number = 0;
  public Name?: string;
  public Image?: string;
  public ProjectUrl: string = "";
  public Images: SlideInterface[] = [];

  constructor() {
    this.Id = 1
  }

}
