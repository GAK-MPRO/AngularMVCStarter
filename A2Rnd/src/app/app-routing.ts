import { Routes, RouterModule } from '@angular/router';

import { LoginComponent } from '../app/Public/Login/login-component';


const appRoutes: Routes = [
    { path: '', redirectTo: 'login', pathMatch:'full' },
    { path: 'login', component: LoginComponent },


    // otherwise redirect to home
    { path: '**', redirectTo: 'login' }
];

export const routing = RouterModule.forRoot(appRoutes);