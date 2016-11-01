import { IPhoto } from "./IPhoto";

export interface ICarousel {
    SliderId: number;
    Title: string;
    Description: string;
    FullName: string;
    Photo: IPhoto;
}