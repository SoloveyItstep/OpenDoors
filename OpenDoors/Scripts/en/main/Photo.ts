import { IPhoto } from "./IPhoto";

export class Photo implements IPhoto {
    PhotoId: number;
    Path: string;
}

//export interface IPhoto {
//    PhotoId: number;
//    Path: string;
//}