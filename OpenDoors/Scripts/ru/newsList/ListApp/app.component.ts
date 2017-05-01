import { Component } from "@angular/core";
import { LeftMenuComponent } from "./LeftMenu/left.menu.component";
import { HeaderComponent } from "./Header/header.component";

@Component({
    moduleId: module.id,
    selector: "ng-body",
    templateUrl: "AppMain.html",
    providers: [LeftMenuComponent, HeaderComponent],
    styleUrls: [`app.component.style.min.css`]
})
export class AppComponent {

}