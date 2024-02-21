import { SlideInterface } from "../Slide/SlideInterface";

export interface ProjectInterface {
  Id: number;
  Name: string;
  Description: string;
  Company: string;
  StartDate: Date;
  EndDate: Date;
  Image?: string;
  ProjectUrl: string;
  Images: SlideInterface[];
  Stack: string[];
}
