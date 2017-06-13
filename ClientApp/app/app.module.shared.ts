import { VehicleFormComponent } from './components/vehicle-form/vihicle-form.component';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';


export const sharedConfig: NgModule = {
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,      
        HomeComponent,
        VehicleFormComponent
    ],
    imports: [
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            {  path: 'vehicles/new', component : VehicleFormComponent  },
            { path: '**', redirectTo: 'home' }
        ],
        FormsModule)
    ]
};
