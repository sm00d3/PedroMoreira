import { isPlatformBrowser } from '@angular/common';
import { Injectable, signal, effect,PLATFORM_ID, Inject, HostBinding } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class GeneralService {

  // DarkMode
  private darkMode = signal<boolean>(((isPlatformBrowser(this.platformId)) ? JSON.parse(this.getFromLocalStorage("DarkMode") ?? 'true') : true));

  constructor(@Inject(PLATFORM_ID) private platformId: Object) {
    effect(() => {
      if (isPlatformBrowser(this.platformId)) {
        this.setToLocalStorage("DarkMode", this.darkMode());
        document.documentElement.setAttribute("data-theme", (this.darkMode() == true) ? "pmDark" : "pmlight");
      }
    });
  }

  public setDarkMode(value: boolean): void {
    this.darkMode.set(value);
  }

  public getDarkMode(): boolean {
    return this.darkMode();
  }

  public setToLocalStorage(key:string, item: any): void {
    localStorage.setItem(key, JSON.stringify(item));
  }

  public getFromLocalStorage(key: string): string|null
  {
    return window.localStorage.getItem(key);
  }
}
