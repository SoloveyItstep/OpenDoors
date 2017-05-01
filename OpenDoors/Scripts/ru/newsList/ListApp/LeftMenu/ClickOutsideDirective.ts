import { Directive, Output, EventEmitter, ElementRef, HostListener } from "@angular/core";

@Directive({
    selector: "[clickOutside]"
})
export class ClickOutsideDirective {
    constructor(private elem: ElementRef) { }
    @Output()
    public clickOutside = new EventEmitter();

    @HostListener("document:click", ["$event.target"])
    public OnClick(target) {
        const clickInside = this.elem.nativeElement.contains(target);
        let drp = document.getElementById("dropdown");
        let down = document.getElementById("down");
        let arrow = document.getElementById("dropdown-arrow");

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
    }
}