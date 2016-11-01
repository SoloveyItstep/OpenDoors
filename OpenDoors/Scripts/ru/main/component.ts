import { Component, Input, ViewEncapsulation, OnInit } from "@angular/core";
import { CarouselList } from "./CarouselList";
import { ICarousel } from "./ICarousel";
import { Http } from "@angular/http";
import { UrlResolver } from "@angular/compiler";
import { DomSanitizer, SafeResourceUrl, SafeUrl} from '@angular/platform-browser';
//import {Observable} from 'rxjs/Rx';

declare const module: any;


@Component({
    selector: "app-carousel",
    moduleId: module.id,
    //encapsulation: ViewEncapsulation.None,
    //template: `<div *ngFor="let c from CarouselList"><img src="{{c.Photo.Path}}"/></div>`
    template: `<div class='carousel'>
<div *ngFor='let car of Carousel; let i = index' id='index{{i}}' class="animated image" 
    [style.background-image]="['url('+Path(car.Photo.Path)+')']" 
    [class.fadeInRight]="classes[i]" [class.fadeOutLeft]="!classes[i]">
</div>
</div>`,
    styleUrls: ['./component.css'],
//    styles: [`
//    .aaa{
//        color: red;
//    }
//`],
    animations: []
})
export class AppComponent {
    Carousel: ICarousel[];
    private interval: any;

    count: number = 0;

    classes = [true, false, false, false];

    constructor(private http: Http) {
        this.http.get("/ru/home/getsliderjson")
            .subscribe(
            (data) => {                
                this.Carousel = data.json(),
                this.Slide()
            }
        );
    }

    public Path(path: string): SafeResourceUrl {
        var resolver = new UrlResolver();
        return resolver.resolve(module.id, "/../../"+path);
    }

    public Slide() {
        setInterval(() => {
            this.classes[this.count] = !this.classes[this.count];
            ++this.count;
            if (this.count > 3)
                this.count = 0;
            this.classes[this.count] = !this.classes[this.count];
                
        },5000);
    }

}