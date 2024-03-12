import { Component } from '@angular/core';
import { PageHeaderComponent } from './components/page-header/page-header.component';
import { DemoComponent } from './components/demo/demo.component';
import { RouterOutlet } from '@angular/router';
import { NavBarComponent } from './components/nav-bar/nav-bar.component';
import { ApplicationActions } from './state/actions';
import { Store } from '@ngrx/store';

@Component({
  selector: 'app-root',
  standalone: true,
  template: `
    <div class="container mx-auto">
      <app-page-header />
      <nav>
        <app-nav-bar />
        <main>
          <router-outlet />
        </main>
      </nav>
    </div>
  `,
  styles: [],
  imports: [PageHeaderComponent, RouterOutlet, NavBarComponent],
})
export class AppComponent {
  constructor(store: Store) {
    store.dispatch(ApplicationActions.applicationStarted());
  }
}
