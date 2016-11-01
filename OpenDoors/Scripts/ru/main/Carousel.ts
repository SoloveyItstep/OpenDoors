import { ICarousel } from "./ICarousel";
import { IPhoto } from "./IPhoto";

export class Carousel implements ICarousel {
    SliderId: number;
    Title: string;
    Description: string;
    FullName: string;
    Photo: IPhoto;
}

