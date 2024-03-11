import { Component } from '@angular/core';

@Component({
  selector: 'app-todo-item-list',
  standalone: true,
  imports: [],
  template: ` <ul>
    <li class="card bg-base-300 shadow-xl mb-4">
      <div class="card-body">
        <span>Clean Garage</span>
        <div class="card-actions justify-end">
          <button class="btn btn-sm btn-primary">X</button>
        </div>
      </div>
    </li>
    <li class="card bg-base-300 shadow-xl mb-4">
      <div class="card-body">
        <span class="line-through font-light">Clean Garage</span>
      </div>
    </li>
  </ul>`,
  styles: ``,
})
export class TodoItemListComponent {}
