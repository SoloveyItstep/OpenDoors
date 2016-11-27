import { Component, Input, ViewEncapsulation, OpaqueToken } from "@angular/core";
import { CarouselList } from "./CarouselList";
import { ICarousel } from "./ICarousel";
import { Http } from "@angular/http";
import { UrlResolver } from "@angular/compiler";
import { DomSanitizer, SafeResourceUrl, SafeUrl} from '@angular/platform-browser';


declare const module: any;

@Component({
    selector: "app-carousel",
    moduleId: module.id,
    templateUrl: "./component.html",
    styleUrls: ['./component.min.css'],
    animations: []
})
export class AppComponent {
    Carousel: ICarousel[];
    private interval: any;
    count: number = 0;
    private titleTimeout: any;
    private descriptionTimeout: any;
    private nameTimeout: any;
    private moreButtonTimeout: any;
    carouselLink = "#";
    
    imageClasses = [true, false, false, false];
    textClasses = [{ title: false, text: false, name: false }, { title: false, text: false, name: false },
        { title: false, text: false, name: false }, { title: false, text: false, name: false }];

    public moreButtons = [false, false, false, false];

    constructor(private http: Http) {
        this.http.get("/ru/home/getsliderjson")
            .subscribe(
            (data) => {                
                this.Carousel = data.json();
                setTimeout(this.Slide(true), 2000);
            }
        );
        
    }

    public Path(path: string): SafeResourceUrl {
        var resolver = new UrlResolver();
        return resolver.resolve(module.id, "/../../"+path);
    }

    public Slide(start: boolean) {
        this.ShowText(-1);
        this.StartInterval(start);
    }

    private StartInterval(start: boolean) {
        this.interval = setInterval(() => {
            this.imageClasses[this.count] = !this.imageClasses[this.count];
            var previous = this.count;
            ++this.count;
            if (this.count > 3)
                this.count = 0;
            this.imageClasses[this.count] = !this.imageClasses[this.count];            
            if (start === true)
                this.ShowText(-1);
            else
                this.ShowText(previous);
            this.carouselLink = "/ru"+this.Carousel[this.count].Url;
            start = false;

        }, 12000);
    }

    public Active(index: number): string {
        if (index === this.count)
            return "yellow";
        return "white";
    }

    public ShowText(previous: number) {
        if (previous === -1 && this.count === 1)
            previous = 0;

        this.titleTimeout = setTimeout(() => {
            if (previous != -1) {
                this.textClasses[previous].title = false;
            }
            this.textClasses[this.count].title = true;
        }, 2000);
        this.descriptionTimeout = setTimeout(() => {
            if (previous != -1) {
                this.textClasses[previous].text = false;
            }
            this.textClasses[this.count].text = true;
        }, 2200);
        this.nameTimeout = setTimeout(() => {
            if (previous != -1) {
                this.textClasses[previous].name = false;
            }
            this.textClasses[this.count].name = true;
        }, 2800);
        this.moreButtonTimeout = setTimeout(() => {
            if (previous != -1) {
                this.moreButtons[previous] = false;
            }
            this.moreButtons[this.count] = true;
        }, 3000);
    }

    public SliderArrow(button: string) {
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
    }

    private ShowMoreButton(currentButton: number) {
        for (var i = 0; i < 4; ++i) {
            this.moreButtons[i] = false;
            if (currentButton === i) {
                this.moreButtons[i] = true;
            }
        }
    }

    private hideAllTexts() {
        clearTimeout(this.titleTimeout);
        clearTimeout(this.descriptionTimeout);
        clearTimeout(this.nameTimeout);
        clearTimeout(this.moreButtonTimeout);

        for (var i = 0; i < 4; ++i) {
            this.textClasses[i].title = false;
            this.textClasses[i].text = false;
            this.textClasses[i].name = false;
        }
        this.moreButtons = [false, false, false,false];
    }

    public SliderNumber(item: number) {
        clearInterval(this.interval);
        this.hideAllTexts();
        this.SelectItem(item);
        this.count = item;
        this.StartInterval(false);
    }

    private SelectItem(itemNumber: number) {
        this.imageClasses[this.count] = !this.imageClasses[this.count];
        this.imageClasses[itemNumber] = !this.imageClasses[itemNumber];
        this.ShowText(itemNumber);
    }
}