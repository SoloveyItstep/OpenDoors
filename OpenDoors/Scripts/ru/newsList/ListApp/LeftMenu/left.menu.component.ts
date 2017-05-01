import { Component, HostListener, Renderer, ElementRef } from "@angular/core";


@Component({
    moduleId: module.id,
    selector: "menu",
    templateUrl: "left.menu.html",
    styleUrls: ["LeftMenuStyle.min.css"],
})
export class LeftMenuComponent {
    showMenuClassName: String = "left-menu-onload";
    showPallClassName: String = "move-close-menu-pall";
    languageClassName: String = "delete-language";
    language: string = "/en/home/news";
    dropDownMenuClassName: string = "hide-element";
    up: boolean = false;
    arrow: string = "arrow-default";
    private bodyClick: Boolean = false;
    private event: Renderer
    private listener: Function;

    constructor(private render: Renderer, private element: ElementRef) { }

    //@HostListener("body:click")
    //onClickBody(event: MouseEvent) {
    //    if (!this.bodyClick)
    //        this.ShowHideDropDown();
    //}

    ShowHideLanguage() {
        if (this.languageClassName == "delete-language" ||
            this.languageClassName == "hide-language")
            this.languageClassName = "show-language";
        else
            this.languageClassName = "hide-language";
        //this.languageClassName =
        //    (this.languageClassName == "delete-language" || this.languageClassName == "hide-language") ?
        //        "show-language" : "hide-language";
    }

    ShowHideDropDown() {
        if (this.dropDownMenuClassName == "hide-element" || this.dropDownMenuClassName == "hide-dropdown") {
            //this.dropDownMenuClassName = "show-dropdown";
            //this.listener = this.render.listenGlobal('body', 'click', (event) => {
            //    this.onBodyClick(event);
            //});
            //document.body.addEventListener('click', this.onBodyClick);
            this.arrow = "arrow-rotate";
        }
        else {
            //this.dropDownMenuClassName = "hide-dropdown";
            this.arrow = "arrow-default";
        }
    }

    ShowHideMenu(checked) {
        if (checked) {
            this.showMenuClassName = "left-menu-show";
            this.showPallClassName = "show-close-menu-pall";
        }
        else {
            this.showMenuClassName = "left-menu-hide";
            this.showPallClassName = "hide-close-menu-pall";
        }
    }

    closeMenuPallClick() {
        document.getElementById("spinner-form2").click();
    }

    onBodyClick(event: MouseEvent) {
            console.log("event");
            //console.log(event);
            //console.log(event.target);
            let element = event.target as Element;
            let cont = element.classList.contains("drop-down-text");
            //document.body.removeEventListener(event.type, this.onBodyClick, false);        
            this.listener();
        
    }

    close() {
        console.log("close function");
    }
}

