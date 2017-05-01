import { Component, OnInit, HostListener, Inject, Output } from "@angular/core";
import { NewsService } from "./Services/data.service";
import { Http, ConnectionBackend } from '@angular/http';
import { News } from "./Entities/News";
import { Tag } from "./Entities/Tag";
import { DOCUMENT, DomSanitizer, SafeResourceUrl, SafeUrl } from '@angular/platform-browser';
import { ScrollPositionize } from "./Helpers/scroll.positionize";
import { UrlResolver } from "@angular/compiler";

@Component({
    moduleId: module.id,
    selector: 'my-app',
    templateUrl: `app.component.html`,
    styleUrls: ['app.component.min.css'],
    providers: [NewsService]
})
export class AppComponent implements OnInit {
    private scrollEv: ScrollPositionize;
    private wheel: Boolean = false;
    private currentItem: number = -1;
    public path: SafeResourceUrl = "";

    constructor(private newsService: NewsService, @Inject(DOCUMENT) private document: Document,
        private sanitizer: DomSanitizer) {
        this.scrollEv = new ScrollPositionize(document);
    }
    news: News[] = new Array();
    private allNewsList: News[] = new Array();
    navIsFixed: Boolean = false;

    ngOnInit() {
        this.newsService.getData(0, 10)
            .subscribe(arr => {
                this.news = arr as News[];
                this.allNewsList = arr as News[];
                this.currentItem = 0;
                this.path = this.Path();
                //console.log(this.news[0].PreviewPhoto);
                //console.log(this.news[0]);
        });
        
    }

    @HostListener("window:scroll", ['$event'])
    onWindowScroll(e) {
        let position = this.document.body.scrollTop;
        let num = parseInt((position / 200).toString());
        let obj = this.document.getElementsByClassName("list")[0];
        if (obj)
            this.path = this.news[0].PreviewPhoto;
        //if (num != this.currentItem)

        //if (!this.scrollEv.done) {
        //    console.log("Go-go-go");
        //}
        //console.log("scroll");
    }

    @HostListener("wheel", ['$event'])
    onMouseWheel(event) {

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
    }

    public Path(): SafeUrl {
        var resolver = new UrlResolver();
        if (this.news.length > 0)
            //this.path = this.sanitizer.bypassSecurityTrustStyle(this.news[0].PreviewPhoto);
            return resolver.resolve(module.id, "/../../" + this.news[0].PreviewPhoto);
        return this.path;
    }

    getMoreNews(current: number, count: number) {
        this.newsService.getData(current, count)
            .subscribe(obs => {
                let arr = obs as News[];
                this.news.concat(arr);
                //TODO: необходимо добавить фильтр для this.news
                this.allNewsList.concat(arr);
        });
    }
}

