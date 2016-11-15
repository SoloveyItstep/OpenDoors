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
var Volunteer = (function () {
    function Volunteer() {
        this.showBlock = false;
        this.ngAfterViewInit();
    }
    Volunteer.prototype.ngAfterViewInit = function () {
        var position = document.body.scrollTop;
        if (position > 0)
            this.showBlock = true;
        else
            this.showBlock = false;
    };
    Volunteer.prototype.OnScrollEvent = function (event) {
        var position = document.body.scrollTop;
        if (position > 0)
            this.showBlock = true;
        else
            this.showBlock = false;
    };
    __decorate([
        core_1.ViewChild("element"), 
        __metadata('design:type', core_1.ElementRef)
    ], Volunteer.prototype, "element", void 0);
    __decorate([
        core_1.HostListener("window:scroll", ['$event']), 
        __metadata('design:type', Function), 
        __metadata('design:paramtypes', [Object]), 
        __metadata('design:returntype', void 0)
    ], Volunteer.prototype, "OnScrollEvent", null);
    Volunteer = __decorate([
        core_1.Component({
            selector: "volunteer",
            moduleId: module.id,
            styleUrls: ['./volunteer-images.css'],
            templateUrl: "./volunteer.html"
        }), 
        __metadata('design:paramtypes', [])
    ], Volunteer);
    return Volunteer;
}());
exports.Volunteer = Volunteer;
//# sourceMappingURL=volunteer-images.js.map