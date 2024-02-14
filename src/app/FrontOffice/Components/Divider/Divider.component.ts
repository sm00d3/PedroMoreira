import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component } from '@angular/core';

@Component({
  selector: 'app-divider',
  standalone: true,
  imports: [
    CommonModule,
  ],
  template: `<div class="relative flex py-5 items-center">
    <div class="flex-grow border-t border-gray-400"></div>
    <span class="flex-shrink mx-4 text-gray-400">Content</span>
    <div class="flex-grow border-t border-gray-400"></div>
</div>`,
  styleUrl: './Divider.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class DividerComponent {

}
