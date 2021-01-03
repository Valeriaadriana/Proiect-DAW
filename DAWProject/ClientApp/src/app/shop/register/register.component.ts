import {Component, OnInit} from '@angular/core';
import {Router} from "@angular/router";
import {User} from "../models/User";
import {UserService} from "../user.service";

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  user: User

  constructor(private router: Router, private userService: UserService) { }

  ngOnInit() {
    this.user = new User()
  }

  onRegister() {
    this.userService.register(this.user).subscribe(_ => {
      this.router.navigate(["/"]);
    })
  }
}
