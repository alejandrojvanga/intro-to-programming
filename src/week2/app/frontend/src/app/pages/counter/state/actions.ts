import { createActionGroup, emptyProps } from '@ngrx/store';

export const CounterAtction = createActionGroup({
  source: 'Counter Component Events',
  events: {
    'Incremented The Count': emptyProps(),
    'Decremented The Count': emptyProps(),
  },
});
