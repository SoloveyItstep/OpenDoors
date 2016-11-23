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
        let position = 0;
        if (document.body.scrollTop === 0 && document.documentElement.scrollTop != undefined &&
            document.documentElement.scrollTop > 0)
            position = document.documentElement.scrollTop;
        else
            position = document.body.scrollTop;
        
        if (position > 0)
            this.showBlock = true;
        else
            this.showBlock = false;
    }

    @HostListener("window:scroll", ['$event'])
    OnScrollEvent(event: any) {
        let position = document.body.scrollTop;
        let position2 = document.documentElement.scrollTop;
        if (position > 0)
            this.showBlock = true;
        else if (position === 0 && position2 != undefined && position2 > 0)
            this.showBlock = true;
        else
            this.showBlock = false;
    }
}