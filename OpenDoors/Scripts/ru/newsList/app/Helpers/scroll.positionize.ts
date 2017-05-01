import { DOCUMENT } from '@angular/platform-browser';

export class ScrollPositionize {
    private document: Document;
    private key: Boolean = false;
    private top: number = 0;
    private onLoadY: number = 0;
    public done: Boolean = false;
    private obj: any;

    constructor(doc: Document) {
        this.document = doc;
        this.onLoadY = document.body.scrollTop;
    }

    onscroll(event:any) {
        let body = this.document.body;
        //if (!this.key && this.top < this.document.body.scrollTop) {
        //    this.key = !this.key;
        //    this.done = false;
        //    this.onLoadY = 0;
        //    this.top = this.GetData(body.scrollTop);
        //    this.scrollTo(body, this.top, 500);
        //    //if (this.top === window.pageYOffset)
        //    //{
        //    //    this.top = 0;
        //    //    this.key = !this.key;
        //    //}
        //}
        //else if (!this.key && this.top > this.document.body.scrollTop) {
        //    this.key = !this.key;
        //    this.done = false;
        //    this.top -= 200;
        //    this.top = this.top < 0 ? 0 : this.top;
        //    this.scrollTo(body, this.top, 500);
        //    //if (this.top === window.pageYOffset) {
        //    //    this.top = 0;
        //    //    this.key = !this.key;
        //    //}
        //}
    }

    scrollDown() {
        if (!this.obj) {
            this.obj = new Object();
            console.log(this.document.body.scrollTop);
            this.top = this.GetData(this.document.body.scrollTop);
            this.scrollTo(this.document.body, this.top, 500);
        }
    }

    scrollUp() {
        if (!this.obj) {
            this.obj = new Object();
            this.top -= 200;
            this.top = this.top < 0 ? 0 : this.top;
            this.scrollTo(this.document.body, this.top, 500);
        }
    }


    private GetData(num: number): number {
        let tmp: number = window.scrollY;
        if(tmp >= num)
            num += 200;
        else if (tmp < 1)
            return 200;
        else
            num -= 200;
        num = parseInt(((num / 200)).toString()) * 200;
        return num > 0 ? num : 0;
    }

    private scrollTo(element, to, duration) {
        this.key = true;
        var start = element.scrollTop,
            change = to - start,
            currentTime = 0,
            increment = 20;

        var animateScroll = () => {
            currentTime += increment;
            var val = this.Method(currentTime, start, change, duration);

            element.scrollTop = val;
            if (currentTime < duration)
                setTimeout(animateScroll, increment);
            else {
                this.key = false;
                this.done = true;
                this.obj = null;
                //console.log(this.top + " - " + this.document.body.scrollTop);
            }                
        };
        animateScroll();
    }

    private Method(t, b, c, d) {
        t /= d / 2;
        if (t < 1)
            return c / 2 * t * t + b;
        t--;
        return -c / 2 * (t * (t - 2) - 1) + b;        
    }
    
}