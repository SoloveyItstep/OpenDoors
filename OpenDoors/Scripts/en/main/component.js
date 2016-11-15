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
        this.carouselLink = "#";
        this.imageClasses = [true, false, false, false];
        this.textClasses = [{ title: false, text: false, name: false }, { title: false, text: false, name: false },
            { title: false, text: false, name: false }, { title: false, text: false, name: false }];
        this.moreButtons = [false, false, false, false];
        this.http.get("/en/home/getsliderjson")
            .subscribe(function (data) {
            _this.Carousel = data.json();
            setTimeout(_this.Slide(true), 2000);
        });
    }
    AppComponent.prototype.Path = function (path) {
        var resolver = new compiler_1.UrlResolver();
        return resolver.resolve(module.id, "/../../" + path);
    };
    AppComponent.prototype.Slide = function (start) {
        this.ShowText(-1);
        this.StartInterval(start);
    };
    AppComponent.prototype.StartInterval = function (start) {
        var _this = this;
        this.interval = setInterval(function () {
            _this.imageClasses[_this.count] = !_this.imageClasses[_this.count];
            var previous = _this.count;
            ++_this.count;
            if (_this.count > 3)
                _this.count = 0;
            _this.imageClasses[_this.count] = !_this.imageClasses[_this.count];
            if (start === true)
                _this.ShowText(-1);
            else
                _this.ShowText(previous);
            _this.carouselLink = "/ru" + _this.Carousel[_this.count].Url;
            start = false;
        }, 12000);
    };
    AppComponent.prototype.Active = function (index) {
        if (index === this.count)
            return "yellow";
        return "white";
    };
    AppComponent.prototype.ShowText = function (previous) {
        var _this = this;
        if (previous === -1 && this.count === 1)
            previous = 0;
        this.titleTimeout = setTimeout(function () {
            if (previous != -1) {
                _this.textClasses[previous].title = false;
            }
            _this.textClasses[_this.count].title = true;
        }, 2000);
        this.descriptionTimeout = setTimeout(function () {
            if (previous != -1) {
                _this.textClasses[previous].text = false;
            }
            _this.textClasses[_this.count].text = true;
        }, 2200);
        this.nameTimeout = setTimeout(function () {
            if (previous != -1) {
                _this.textClasses[previous].name = false;
            }
            _this.textClasses[_this.count].name = true;
        }, 2800);
        this.moreButtonTimeout = setTimeout(function () {
            if (previous != -1) {
                _this.moreButtons[previous] = false;
            }
            _this.moreButtons[_this.count] = true;
        }, 3000);
    };
    AppComponent.prototype.SliderArrow = function (button) {
        clearInterval(this.interval);
        var previous = this.count;
        this.hideAllTexts();
        if (button === "left") {
            this.count = --this.count;
            if (this.count < 0)
                this.count = 3;
        }
        else {
            this.count = ++this.count;
            if (this.count > 3)
                this.count = 0;
        }
        this.SelectItem(previous);
        this.StartInterval(false);
    };
    AppComponent.prototype.ShowMoreButton = function (currentButton) {
        for (var i = 0; i < 4; ++i) {
            this.moreButtons[i] = false;
            if (currentButton === i) {
                this.moreButtons[i] = true;
            }
        }
    };
    AppComponent.prototype.hideAllTexts = function () {
        clearTimeout(this.titleTimeout);
        clearTimeout(this.descriptionTimeout);
        clearTimeout(this.nameTimeout);
        clearTimeout(this.moreButtonTimeout);
        for (var i = 0; i < 4; ++i) {
            this.textClasses[i].title = false;
            this.textClasses[i].text = false;
            this.textClasses[i].name = false;
        }
        this.moreButtons = [false, false, false, false];
    };
    AppComponent.prototype.SliderNumber = function (item) {
        clearInterval(this.interval);
        this.hideAllTexts();
        this.SelectItem(item);
        this.count = item;
        this.StartInterval(false);
    };
    AppComponent.prototype.SelectItem = function (itemNumber) {
        this.imageClasses[this.count] = !this.imageClasses[this.count];
        this.imageClasses[itemNumber] = !this.imageClasses[itemNumber];
        this.ShowText(itemNumber);
    };
    AppComponent = __decorate([
        core_1.Component({
            selector: "app-carousel",
            moduleId: module.id,
            templateUrl: "./component.html",
            styleUrls: ['./component.css'],
            animations: []
        }), 
        __metadata('design:paramtypes', [http_1.Http])
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;
//# sourceMappingURL=component.js.map