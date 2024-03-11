import { Component } from '@angular/core';
import { TodoEntryComponent } from './components/todo-entry/todo-entry.component';
import { TodoItemListComponent } from './components/todo-item-list/todo-item-list.component';
import { TodoListItem } from './models';

@Component({
  selector: 'app-todo-list',
  standalone: true,
  template: `
    <section>
      <h2 class="text-2xl font-bold">Your Todo List</h2>
    </section>
    <div>
      <app-todo-entry />
    </div>
    <div>
      <app-todo-item-list />
    </div>
  `,
  styles: ``,
  imports: [TodoEntryComponent, TodoItemListComponent],
})
export class TodoListComponent {
  list: TodoListItem[] = [
    { id: '1', description: 'Clean Car', completed: false },
    { id: '2', description: 'Buy Beer', completed: true },
  ];
}
