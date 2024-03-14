import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { map, switchMap } from 'rxjs';
import { environment } from '../../../../environments/environment';
import { ApplicationActions } from '../../../state/actions';
import { TodoCommands, TodoDocuments } from './actions';
import { TodoEntity } from '../types';
@Injectable()
export class TodoEffects {
  readonly baseUrl = environment.apiUrl;
  onStartup$ = createEffect(() =>
    this.actions$.pipe(
      ofType(ApplicationActions.applicationStarted),
      map(() => TodoCommands.loadTodos())
    )
  );

  loadTodos$ = createEffect(() =>
    this.actions$.pipe(
      ofType(TodoCommands.loadTodos),
      switchMap(() =>
        this.httpClient
          .get<{ list: TodoEntity[] }>(this.baseUrl + '/todos')
          .pipe(
            map((results) => results.list),
            map((payload) => TodoDocuments.todos({ payload }))
          )
      )
    )
  );
  constructor(private actions$: Actions, private httpClient: HttpClient) {}
}
