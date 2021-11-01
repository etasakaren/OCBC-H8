import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AuthService } from 'src/app/shared/auth.service';

@Component({
  selector: 'app-studios',
  templateUrl: './studios.component.html',
  styleUrls: ['./studios.component.css']
})
export class StudiosComponent implements OnInit {

  currentUser: {
    name: string,
    email: string,
    _id: string
  } = { name: '', email: '', _id: '' }

  constructor(public authService: AuthService, private actRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.setCurrentUser();
  }

  setCurrentUser() {
    let id = this.actRoute.snapshot.paramMap.get('id');
    if (!this.authService.currentUser._id) {
      this.authService.getStudios().subscribe(res => {
        this.currentUser = res.msg;
      })
    } else {
      const { name, email, _id } = this.authService.currentUser;
      this.currentUser = { name, email, _id }
    }
  }
}
