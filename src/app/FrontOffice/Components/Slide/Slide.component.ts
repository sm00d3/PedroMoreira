import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, Input, WritableSignal, signal } from '@angular/core';
import { SlideInterface } from '../../Data/Slide/SlideInterface';

@Component({
  selector: 'app-slide',
  standalone: true,
  imports: [
    CommonModule,
  ],
  templateUrl: './Slide.component.html',
  styles: '',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class SlideComponent {
  @Input() slides: SlideInterface[] = []

  currentIndex: WritableSignal<number> = signal<number>(0);
  totalSlides: number = 0;

  ngOnInit() {}


  public getCurrentSlideUrl(): string {
    return this.slides[this.currentIndex()].Url;
  }

  public goToPrevious(): void {
    let isFirstSlide = this.currentIndex() == 0;
    let newIndex = isFirstSlide ? (this.slides.length - 1) : (this.currentIndex() - 1);

    this.currentIndex.set(newIndex);
  }

  public goToNext(): void {
    let isLastSlide = this.currentIndex() === (this.slides.length - 1);
    let newIndex = isLastSlide ? 0 : (this.currentIndex() + 1);

    this.currentIndex.set(newIndex);
  }
}
