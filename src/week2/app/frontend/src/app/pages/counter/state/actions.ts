import { createActionGroup, emptyProps, props } from '@ngrx/store';

export type CountByValues = 1 | 3 | 5;
export const CounterAction = createActionGroup({
  source: 'Counter Component Events',
  events: {
    'Incremented The Count': emptyProps(),
    'Decremented The Count': emptyProps(),
    'Count Reset': emptyProps(),
    'Count By Changed': props<{ payload: CountByValues }>(),
  },
});
