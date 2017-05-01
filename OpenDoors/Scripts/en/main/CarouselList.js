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
var CarouselList = (function () {
    function CarouselList(http) {
        this.http = http;
        this.key = false;
    }
    CarouselList.prototype.getData = function () {
        var _this = this;
        this.http.get("/ru/home/getsliderjson")
            .subscribe(function (data) {
            return _this.datapush(data.json());
        }, function (err) { return console.error(err); }, function () { return console.log("ok"); });
    };
    CarouselList.prototype.datapush = function (data) {
        console.log(data);
        this.key = true;
        this.carousel = data;
    };
    return CarouselList;
}());
CarouselList = __decorate([
    core_1.Injectable(),
    __metadata("design:paramtypes", [http_1.Http])
], CarouselList);
exports.CarouselList = CarouselList;
//# sourceMappingURL=CarouselList.js.map