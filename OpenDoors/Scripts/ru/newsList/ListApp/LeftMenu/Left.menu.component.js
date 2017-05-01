"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require("@angular/core");
var LeftMenuComponent = (function () {
    function LeftMenuComponent(render, element) {
        this.render = render;
        this.element = element;
        this.showMenuClassName = "left-menu-onload";
        this.showPallClassName = "move-close-menu-pall";
        this.languageClassName = "delete-language";
        this.language = "/en/home/news";
        this.dropDownMenuClassName = "hide-element";
        this.up = false;
        this.arrow = "arrow-default";
        this.bodyClick = false;
    }
    //@HostListener("body:click")
    //onClickBody(event: MouseEvent) {
    //    if (!this.bodyClick)
    //        this.ShowHideDropDown();
    //}
    LeftMenuComponent.prototype.ShowHideLanguage = function () {
        if (this.languageClassName == "delete-language" ||
            this.languageClassName == "hide-language")
            this.languageClassName = "show-language";
        else
            this.languageClassName = "hide-language";
        //this.languageClassName =
        //    (this.languageClassName == "delete-language" || this.languageClassName == "hide-language") ?
        //        "show-language" : "hide-language";
    };
    LeftMenuComponent.prototype.ShowHideDropDown = function () {
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
    };
    LeftMenuComponent.prototype.ShowHideMenu = function (checked) {
        if (checked) {
            this.showMenuClassName = "left-menu-show";
            this.showPallClassName = "show-close-menu-pall";
        }
        else {
            this.showMenuClassName = "left-menu-hide";
            this.showPallClassName = "hide-close-menu-pall";
        }
    };
    LeftMenuComponent.prototype.closeMenuPallClick = function () {
        document.getElementById("spinner-form2").click();
    };
    LeftMenuComponent.prototype.onBodyClick = function (event) {
        console.log("event");
        //console.log(event);
        //console.log(event.target);
        var element = event.target;
        var cont = element.classList.contains("drop-down-text");
        //document.body.removeEventListener(event.type, this.onBodyClick, false);        
        this.listener();
    };
    LeftMenuComponent.prototype.close = function () {
        console.log("close function");
    };
    return LeftMenuComponent;
}());
LeftMenuComponent = __decorate([
    core_1.Component({
        moduleId: module.id,
        selector: "menu",
        templateUrl: "left.menu.html",
        styleUrls: ["LeftMenuStyle.min.css"],
    }),
    __metadata("design:paramtypes", [core_1.Renderer, core_1.ElementRef])
], LeftMenuComponent);
exports.LeftMenuComponent = LeftMenuComponent;
//# sourceMappingURL=left.menu.component.js.map