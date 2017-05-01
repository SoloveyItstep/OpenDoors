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
var __param = (this && this.__param) || function (paramIndex, decorator) {
    return function (target, key) { decorator(target, key, paramIndex); }
};
var core_1 = require("@angular/core");
var data_service_1 = require("./Services/data.service");
var platform_browser_1 = require("@angular/platform-browser");
var scroll_positionize_1 = require("./Helpers/scroll.positionize");
var compiler_1 = require("@angular/compiler");
var AppComponent = (function () {
    function AppComponent(newsService, document, sanitizer) {
        this.newsService = newsService;
        this.document = document;
        this.sanitizer = sanitizer;
        this.wheel = false;
        this.currentItem = -1;
        this.path = "";
        this.news = new Array();
        this.allNewsList = new Array();
        this.navIsFixed = false;
        this.scrollEv = new scroll_positionize_1.ScrollPositionize(document);
    }
    AppComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.newsService.getData(0, 10)
            .subscribe(function (arr) {
            _this.news = arr;
            _this.allNewsList = arr;
            _this.currentItem = 0;
            _this.path = _this.Path();
            //console.log(this.news[0].PreviewPhoto);
            //console.log(this.news[0]);
        });
    };
    AppComponent.prototype.onWindowScroll = function (e) {
        var position = this.document.body.scrollTop;
        var num = parseInt((position / 200).toString());
        var obj = this.document.getElementsByClassName("list")[0];
        if (obj)
            this.path = this.news[0].PreviewPhoto;
        //if (num != this.currentItem)
        //if (!this.scrollEv.done) {
        //    console.log("Go-go-go");
        //}
        //console.log("scroll");
    };
    AppComponent.prototype.onMouseWheel = function (event) {
        console.log(event.deltaY);
        //let item = document.getElementsByClassName("list")[0];
        //console.log(item.clientHeight);
        //console.log(item);
        //console.log("wheel");
        //console.log(event);
        //console.log(event.deltaY);
        if (event.deltaY > 0)
            this.scrollEv.scrollDown();
        else if (event.deltaY < 0)
            this.scrollEv.scrollUp();
        //this.wheel = !this.wheel;
        //this.scrollEv.onscroll(event);
        //this.wheel = !this.wheel;
    };
    AppComponent.prototype.Path = function () {
        var resolver = new compiler_1.UrlResolver();
        if (this.news.length > 0)
            //this.path = this.sanitizer.bypassSecurityTrustStyle(this.news[0].PreviewPhoto);
            return resolver.resolve(module.id, "/../../" + this.news[0].PreviewPhoto);
        return this.path;
    };
    AppComponent.prototype.getMoreNews = function (current, count) {
        var _this = this;
        this.newsService.getData(current, count)
            .subscribe(function (obs) {
            var arr = obs;
            _this.news.concat(arr);
            //TODO: необходимо добавить фильтр для this.news
            _this.allNewsList.concat(arr);
        });
    };
    return AppComponent;
}());
__decorate([
    core_1.HostListener("window:scroll", ['$event']),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", [Object]),
    __metadata("design:returntype", void 0)
], AppComponent.prototype, "onWindowScroll", null);
__decorate([
    core_1.HostListener("wheel", ['$event']),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", [Object]),
    __metadata("design:returntype", void 0)
], AppComponent.prototype, "onMouseWheel", null);
AppComponent = __decorate([
    core_1.Component({
        moduleId: module.id,
        selector: 'my-app',
        templateUrl: "app.component.html",
        styleUrls: ['app.component.min.css'],
        providers: [data_service_1.NewsService]
    }),
    __param(1, core_1.Inject(platform_browser_1.DOCUMENT)),
    __metadata("design:paramtypes", [data_service_1.NewsService, Document,
        platform_browser_1.DomSanitizer])
], AppComponent);
exports.AppComponent = AppComponent;
//# sourceMappingURL=app.component.js.map