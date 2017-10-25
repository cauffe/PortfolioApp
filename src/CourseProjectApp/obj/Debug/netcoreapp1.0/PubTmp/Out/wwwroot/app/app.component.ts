import { Component } from '@angular/core';
import { Http, Headers, RequestOptions } from '@angular/http';
import { Router } from '@angular/router';
import { Login } from './model/login';
import { FormsModule } from '@angular/forms';
import { LoginAuthenticationService } from './services/login.service';


@Component({
    selector: 'core-app',
    templateUrl: "app/login/login.component.html"
})

export class AppComponent implements OnInit {


    constructor(private http: Http, private dataService: LoginAuthenticationService) {
        var model = new Login("", "");
        console.log("Form Component Start");
    }

    authentication(username: any, password:any):any {
       
        this.dataService.authentication(username,password);
      
    }


}

