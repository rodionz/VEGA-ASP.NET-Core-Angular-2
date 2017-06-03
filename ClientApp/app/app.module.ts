import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { ServerModule } from '@angular/platform-server';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { VihicleFormComponent } from './components/vihicle-form/vihicle-form.component';


 @NgModule  ({
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent,
         ServerModule,
        BrowserModule,
        FormsModule,
        HttpModule,
        VihicleFormComponent
       
    ],
    imports: [
        RouterModule.forRoot([
            {path: 'vehicles/new', component: VihicleFormComponent},
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },         
            { path: '**', redirectTo: 'home' }
        ])
    ],

    providers: [
        { provide: 'ORIGIN_URL', useValue: location.origin }
    ]
})



export class AppModule {
}