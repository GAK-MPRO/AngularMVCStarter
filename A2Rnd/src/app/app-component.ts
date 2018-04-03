//root component , this becomes the parent and other components will basically become child
import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
  template: '<h1>Hello {{name}}</h1>',
})
export class AppComponent  { name = 'Angular'; }
