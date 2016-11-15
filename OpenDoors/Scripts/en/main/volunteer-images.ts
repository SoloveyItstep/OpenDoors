import { Component, ViewChild, ElementRef, AfterViewInit, HostListener } from "@angular/core";

declare const module: any;

@Component({
    selector: "volunteer",
    moduleId: module.id,
    styleUrls: ['./volunteer-images.css'],
    templateUrl: "./volunteer.html"
})
export class Volunteer implements AfterViewInit {
    
    @ViewChild("element") element: ElementRef
    public showBlock: boolean;
    constructor() {
        this.showBlock = false;
        this.ngAfterViewInit();
    }

    ngAfterViewInit() {
        let position = document.body.scrollTop;
        if (position > 0)
            this.showBlock = true;
        else
            this.showBlock = false;
    }

    @HostListener("window:scroll", ['$event'])
    OnScrollEvent(event: any) {
        let position = document.body.scrollTop;
        if (position > 0)
            this.showBlock = true;
        else
            this.showBlock = false;
    }
}