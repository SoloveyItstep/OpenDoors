"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var component_1 = require("./component");
var http_1 = require("@angular/http");
var CarouselList_1 = require("./CarouselList");
var volunteer_images_1 = require("./volunteer-images");
//import './rxjs-operators';
var AppModule = (function () {
    function AppModule() {
    }
    return AppModule;
}());
AppModule = __decorate([
    core_1.NgModule({
        imports: [platform_browser_1.BrowserModule, http_1.HttpModule],
        declarations: [component_1.AppComponent, volunteer_images_1.Volunteer],
        bootstrap: [component_1.AppComponent, volunteer_images_1.Volunteer],
        providers: [CarouselList_1.CarouselList]
    })
], AppModule);
exports.AppModule = AppModule;
//# sourceMappingURL=module.js.map