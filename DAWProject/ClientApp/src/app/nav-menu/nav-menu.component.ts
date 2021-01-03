import {Component, OnInit} from '@angular/core';
import {AuthService} from "../auth.service";
import {Router} from "@angular/router";

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {
  isExpanded = false;
  private username: string;

  constructor(private authenticationService: AuthService, private router: Router) {
  }

  ngOnInit(): void {
    this.authenticationService.userSubject.subscribe(user => {
      this.username = user ? user.username: '';
    })
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  logout() {
    this.authenticationService.logout().subscribe(logout => {
      if(!logout) {
        this.router.navigateByUrl("login").then()
      }
    })
  }

  isUserLoggedIn() {
    return this.authenticationService.isUserLoggedIn()
  }
}
