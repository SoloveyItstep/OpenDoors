import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { AppComponent } from "./component";
import { HttpModule } from "@angular/http";
import { CarouselList } from "./CarouselList";
import { UrlResolver } from "@angular/compiler";
import { Volunteer } from "./volunteer-images";
///<reference path="File.js"/>
//import './rxjs-operators';

@NgModule({
    imports: [BrowserModule, HttpModule],
    declarations: [AppComponent, Volunteer],
    bootstrap: [AppComponent, Volunteer],
    providers: [CarouselList]
})
export class AppModule { }