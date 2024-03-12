import { createFeature, createReducer, on } from '@ngrx/store';
import { CountByValues, CounterAction } from './actions';

export interface CounterState {
  current: number;
  by: CountByValues;
}

const initialState: CounterState = {
  current: 0,
  by: 1,
};

export const counterFeature = createFeature({
  name: 'counter',
  reducer: createReducer(
    initialState,
    on(CounterAction.incrementedTheCount, (state) => ({
      ...state,
      current: state.current + state.by,
    })),
    on(CounterAction.decrementedTheCount, (state) => ({
      ...state,
      current: state.current - state.by,
    })),
    on(CounterAction.countReset, () => initialState),
    on(CounterAction.countByChanged, (state, action) => ({
      ...state,
      by: action.payload,
    }))
  ),
});
