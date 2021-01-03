import {Inject, Injectable} from '@angular/core';
import {Observable, Subject} from "rxjs";
import {HttpClient} from "@angular/common/http";
import {map} from "rxjs/operators";


class UserSession {
  id: string;
  firstName: string;
  lastName: string;
  username: string;
  token: string;
}

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  public userSubject = new Subject<UserSession>()

  constructor(private http: HttpClient,
              @Inject('BASE_URL') readonly baseUrl: string) {
  }

  getUserSession(): UserSession {
    return JSON.parse(localStorage.getItem('currentUser'))
  }

  isUserLoggedIn() {
    return this.getUserSession() != null && this.getUserSession() != undefined
  }

  login(username: string, password: string) {
    return this.http.post<UserSession>(`${this.baseUrl}api/users/authenticate`, { username: username, password: password} )
      .pipe(map(user => {
        // store user details and jwt token in local storage to keep user logged in between page refreshes
        localStorage.setItem('currentUser', JSON.stringify(user));
        this.userSubject.next(user)
        return user;
      }));
  }

  logout() {
    // remove user from local storage to log user out
    return new Observable<any>(observer => {
      localStorage.removeItem('currentUser');
      this.userSubject.next(null)
      observer.next(this.isUserLoggedIn())
    });
  }
}
