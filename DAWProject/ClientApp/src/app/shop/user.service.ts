import {Inject, Injectable} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {User} from "./models/User";

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private readonly baseUrl: string) {
  }

  register(user: User) {
    return this.http.post( `${this.baseUrl}api/users/register`, user);
  }
}
