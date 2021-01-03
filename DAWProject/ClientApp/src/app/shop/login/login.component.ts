import {Component, OnInit} from '@angular/core';
import {Router} from "@angular/router";
import {AuthService} from "../../auth.service";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  username: string;
  password: string;

  constructor(private router: Router, private authenticationService: AuthService) { }

  ngOnInit() {
    this.username = '';
    this.password = '';
  }

  onLogin() {
    console.log(this.username, this.password)
    this.authenticationService.login(this.username, this.password)
      .subscribe(_ => this.router.navigateByUrl("/").then());
  }
}
