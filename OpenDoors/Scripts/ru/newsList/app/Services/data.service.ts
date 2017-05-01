import * as imp from "./data.service.index";
import "rxjs/add/operator/map";
import 'rxjs/add/operator/catch';

@imp.Injectable()
export class NewsService {
    private newsUrl = "/api/news/";
    constructor(public http: imp.Http) { }
   
    getData(current: number, count: number): imp.Observable<imp.News[]> {
        let url = this.newsUrl + current + "/" + count + "/ru"; 
        return this.http.get(url)
            .map(this.getNews);
    }

    private getNews(res: imp.Response) {
        let body = JSON.parse(res.json());
        return body as imp.News[] || [];
    }
}
