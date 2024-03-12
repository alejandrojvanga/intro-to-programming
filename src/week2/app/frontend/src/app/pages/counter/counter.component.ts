import { Component } from '@angular/core';
import { Store } from '@ngrx/store';
import { counterFeature } from './state';
import { CounterAction } from './state/actions';

@Component({
  selector: 'app-counter',
  standalone: true,
  imports: [],
  template: `
    <div>
      <button (click)="decrement()" class="btn btn-primary">-</button>
      <span>{{ current() }}</span>
      <button (click)="increment()" class="btn btn-primary">+</button>
    </div>
    <div>
      <button
        [disabled]="current() === 0"
        (click)="counterReset()"
        class="btn btn-primary"
      >
        Reset
      </button>
    </div>
  `,
  styles: ``,
})
export class CounterComponent {
  constructor(private store: Store) {}
  current = this.store.selectSignal(counterFeature.selectCurrent);

  increment() {
    this.store.dispatch(CounterAction.incrementedTheCount());
  }

  decrement() {
    this.store.dispatch(CounterAction.decrementedTheCount());
  }

  counterReset() {
    this.store.dispatch(CounterAction.countReset());
  }
}
