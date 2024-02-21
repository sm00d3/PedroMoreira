import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, Input, input } from '@angular/core';

@Component({
  selector: 'app-divider',
  standalone: true,
  imports: [
    CommonModule,
  ],
  template: `
  <div class="relative flex py-5 items-center">
      @if (lineStart == true) {
        <div class="flex-grow border-t border-gray-400"></div>
      }
      <span class="flex-shrink mx-4 text-gray-400">{{ content }}</span>
      @if (lineEnd == true) {
        <div class="flex-grow border-t border-gray-400"></div>
      }
  </div>`,
  styleUrl: './Divider.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class DividerComponent {

  @Input() lineStart: boolean = true;
  @Input() lineEnd: boolean  = true;
  @Input() content: string  = "";

}
