import { Injectable } from "@angular/core";
import { IPhoto } from "./IPhoto";
import { Photo } from "./Photo";
import { ICarousel } from "./ICarousel";
import { Carousel } from "./Carousel";
import { Http, Response  } from "@angular/http";

@Injectable()
export class CarouselList {
    carousel: any;
    key: boolean;
    constructor(public http: Http) {
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
    }

    datapush(data: any) {
        console.log(data);
        this.key = true;
        this.carousel = data;
    }
}