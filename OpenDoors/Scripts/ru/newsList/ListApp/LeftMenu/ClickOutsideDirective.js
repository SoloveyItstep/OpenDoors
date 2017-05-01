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
var ClickOutsideDirective = (function () {
    function ClickOutsideDirective(elem) {
        this.elem = elem;
        this.clickOutside = new core_1.EventEmitter();
    }
    ClickOutsideDirective.prototype.OnClick = function (target) {
        var clickInside = this.elem.nativeElement.contains(target);
        var drp = document.getElementById("dropdown");
        var down = document.getElementById("down");
        var arrow = document.getElementById("dropdown-arrow");
        if (!clickInside) {
            this.clickOutside.emit(null);
            if (drp.classList.contains("show-dropdown")) {
                drp.classList.remove("show-dropdown");
                drp.classList.add("hide-dropdown");
                down.classList.remove("up");
                arrow.classList.remove("arrow-rotate");
                arrow.classList.add("arrow-default");
            }
        }
        else {
            if (drp.classList.contains("hide-element") || drp.classList.contains("hide-dropdown")) {
                drp.classList.remove("hide-element");
                drp.classList.remove("hide-dropdown");
                drp.classList.add("show-dropdown");
                down.classList.add("up");
                arrow.classList.remove("arrow-default");
                arrow.classList.add("arrow-rotate");
            }
            else if (drp.classList.contains("show-dropdown")) {
                drp.classList.remove("show-dropdown");
                drp.classList.add("hide-dropdown");
                down.classList.remove("up");
                arrow.classList.remove("arrow-rotate");
                arrow.classList.add("arrow-default");
            }
        }
    };
    return ClickOutsideDirective;
}());
__decorate([
    core_1.Output(),
    __metadata("design:type", Object)
], ClickOutsideDirective.prototype, "clickOutside", void 0);
__decorate([
    core_1.HostListener("document:click", ["$event.target"]),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", [Object]),
    __metadata("design:returntype", void 0)
], ClickOutsideDirective.prototype, "OnClick", null);
ClickOutsideDirective = __decorate([
    core_1.Directive({
        selector: "[clickOutside]"
    }),
    __metadata("design:paramtypes", [core_1.ElementRef])
], ClickOutsideDirective);
exports.ClickOutsideDirective = ClickOutsideDirective;
//# sourceMappingURL=ClickOutsideDirective.js.map