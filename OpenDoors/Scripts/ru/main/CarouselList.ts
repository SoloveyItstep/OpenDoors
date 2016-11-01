import { Injectable } from "@angular/core";
import { IPhoto } from "./IPhoto";
import { Photo } from "./Photo";
import { ICarousel } from "./ICarousel";
import { Carousel } from "./Carousel";

//import { Headers, RequestOptions } from '@angular/http';
import { Http, Response  } from "@angular/http";
//import { Observable }     from 'rxjs/Observable';


@Injectable()
export class CarouselList {
    carousel: any;
    key: boolean;
    constructor(public http: Http) {
        //this.http.get("ru/home/getsliderjson", null)
        //    //.map(res => res.json)
        //    .subscribe(
        //    //(data) => this.carousel = data

        //);

        
        //.json()
        this.key = false;
    }


    getData() {
        this.http.get("/ru/home/getsliderjson")
            .subscribe(
            (data) =>
                this.datapush(data.json()),
            err => console.error(err),
            () => console.log("ok")
            );

        //console.log(this.carousel);
    }

    datapush(data: any) {
        console.log(data);
        this.key = true;
        this.carousel = data;
    }
}