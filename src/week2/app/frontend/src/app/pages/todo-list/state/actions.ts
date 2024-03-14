import { createActionGroup, emptyProps, props } from '@ngrx/store';
import { TodoEntity } from '../types';

export const TodoCommands = createActionGroup({
  source: 'Todo Commands',
  events: {
    'Load Todos': emptyProps(),
  },
});

export const TodoEvents = createActionGroup({
  source: 'Todo Events',
  events: { 'Todo Item Added': props<{ playload: string }>() },
});

export const TodoDocuments = createActionGroup({
  source: 'Todo Documents',
  events: {
    Todos: props<{ payload: TodoEntity[] }>(),
  },
});
