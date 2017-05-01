import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { AppComponent } from "./app.component";
import { LeftMenuComponent } from "./LeftMenu/left.menu.component";
import { ClickOutsideDirective } from "./LeftMenu/ClickOutsideDirective";
import { HeaderComponent } from "./Header/header.component";

@NgModule({
    imports: [BrowserModule],
    declarations: [AppComponent, LeftMenuComponent, ClickOutsideDirective, HeaderComponent],
    bootstrap: [AppComponent],
})
export class AppModule {}



