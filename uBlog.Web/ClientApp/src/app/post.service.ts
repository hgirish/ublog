import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { tap, catchError } from 'rxjs/operators'
import { MessageService } from './message.service';
import { Observable, of } from 'rxjs';
import { Post } from './post';

@Injectable({
  providedIn: 'root'
})
export class PostService {
  postsUrl = '../api/posts'


  constructor(private http: HttpClient, private messageService: MessageService) { }

  getPosts(): Observable<Post[]> {
    return this.http.get<Post[]>(this.postsUrl)
      .pipe(
      tap(heroes => this.log(`fetched posts`)),
        catchError(this.handleError('getPosts', []))
      )
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error)
      this.log(`${operation} failed: ${error.message}`)
      return of(result as T);
    }
  }

  private log(message: string) {
    this.messageService.add('PostsService: ' + message)
  }
}
