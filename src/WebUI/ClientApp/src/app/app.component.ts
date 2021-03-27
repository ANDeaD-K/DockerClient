import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  title = 'app';
  navigation: any[] = [
    { id: 1, text: "Containers", icon: "mediumiconslayout", path: "" },
    { id: 2, text: "Images", icon: "floppy", path: "counter" },
    { id: 3, text: "Info", icon: "info", path: "info" }
  ];
  isDrawerOpen: Boolean = true;
  buttonOptions: any = {
    icon: "menu",
    onClick: () => {
      this.isDrawerOpen = !this.isDrawerOpen;
    }
  };
}
