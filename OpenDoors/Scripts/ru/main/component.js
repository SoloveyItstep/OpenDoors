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
var http_1 = require("@angular/http");
var compiler_1 = require("@angular/compiler");
var AppComponent = (function () {
    function AppComponent(http) {
        var _this = this;
        this.http = http;
        this.count = 0;
        this.classes = [true, false, false, false];
        this.http.get("/ru/home/getsliderjson")
            .subscribe(function (data) {
            _this.Carousel = data.json(),
                _this.Slide();
        });
    }
    AppComponent.prototype.Path = function (path) {
        var resolver = new compiler_1.UrlResolver();
        return resolver.resolve(module.id, "/../../" + path);
    };
    AppComponent.prototype.Slide = function () {
        var _this = this;
        setInterval(function () {
            _this.classes[_this.count] = !_this.classes[_this.count];
            ++_this.count;
            if (_this.count > 3)
                _this.count = 0;
            _this.classes[_this.count] = !_this.classes[_this.count];
        }, 5000);
    };
    AppComponent = __decorate([
        core_1.Component({
            selector: "app-carousel",
            moduleId: module.id,
            //encapsulation: ViewEncapsulation.None,
            //template: `<div *ngFor="let c from CarouselList"><img src="{{c.Photo.Path}}"/></div>`
            template: "<div class='carousel'>\n<div *ngFor='let car of Carousel; let i = index' id='index{{i}}' class=\"animated image\" \n    [style.background-image]=\"['url('+Path(car.Photo.Path)+')']\" \n    [class.fadeInRight]=\"classes[i]\" [class.fadeOutLeft]=\"!classes[i]\">\n</div>\n</div>",
            styleUrls: ['./component.css'],
            //    styles: [`
            //    .aaa{
            //        color: red;
            //    }
            //`],
            animations: []
        }), 
        __metadata('design:paramtypes', [http_1.Http])
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;
//# sourceMappingURL=component.js.map