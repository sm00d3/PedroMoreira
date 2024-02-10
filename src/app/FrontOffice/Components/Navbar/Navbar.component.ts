import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { GeneralService } from '../../../Global/General.service';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [
    CommonModule,
  ],
  templateUrl: './Navbar.component.html',
  styleUrl: './Navbar.component.scss',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class NavbarComponent implements OnInit {

  @ViewChild("menuItens", { static: false })
  private menuRef!: ElementRef;

  @ViewChild("menubtn", { static: false })
  private menuBtnRef!: ElementRef;

  constructor(public globalServ: GeneralService) { }

  ngOnInit(): void {
    console.log("menuBtnRef: ", this.menuBtnRef);
    console.log("menuItens: ", this.menuRef);
  }
}
