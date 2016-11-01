import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { AppComponent } from "./component";
import { HttpModule } from "@angular/http";
import { CarouselList } from "./CarouselList";
import { UrlResolver } from "@angular/compiler";

//import './rxjs-operators';

@NgModule({
    imports: [BrowserModule, HttpModule],
    declarations: [AppComponent],
    bootstrap: [AppComponent],
    providers: [CarouselList]
})
export class AppModule { }