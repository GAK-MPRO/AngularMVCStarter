import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { FormsModule   } from '@angular/forms';

import { AppComponent } from './app-component';
import { routing } from './app-routing';
import { LoginComponent } from './Public/Login/login-component';

@NgModule({
    imports: [
        BrowserModule,
        HttpClientModule,
        FormsModule,
        
        routing

    ],
    declarations: [AppComponent,
        LoginComponent

    ],
    bootstrap: [AppComponent]
   
})
export class AppModule { }
