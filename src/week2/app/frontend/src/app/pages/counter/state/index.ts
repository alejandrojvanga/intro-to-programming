import { createFeature, createReducer, on } from '@ngrx/store';
import { CounterAtction } from './actions';

export interface CounterState {
  current: number;
}

const initialState: CounterState = {
  current: 0,
};

export const counterFeature = createFeature({
  name: 'counter',
  reducer: createReducer(
    initialState,
    on(CounterAtction.incrementedTheCount, (state, action) => ({
      current: state.current + 1,
    })),
    on(CounterAtction.decrementedTheCount, (state, action) => ({
      current: state.current - 1,
    }))
  ),
});
