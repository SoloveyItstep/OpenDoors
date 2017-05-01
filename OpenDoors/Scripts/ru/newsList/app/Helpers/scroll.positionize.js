"use strict";
var ScrollPositionize = (function () {
    function ScrollPositionize(doc) {
        this.key = false;
        this.top = 0;
        this.onLoadY = 0;
        this.done = false;
        this.document = doc;
        this.onLoadY = document.body.scrollTop;
    }
    ScrollPositionize.prototype.onscroll = function (event) {
        var body = this.document.body;
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
    };
    ScrollPositionize.prototype.scrollDown = function () {
        if (!this.obj) {
            this.obj = new Object();
            console.log(this.document.body.scrollTop);
            this.top = this.GetData(this.document.body.scrollTop);
            this.scrollTo(this.document.body, this.top, 500);
        }
    };
    ScrollPositionize.prototype.scrollUp = function () {
        if (!this.obj) {
            this.obj = new Object();
            this.top -= 200;
            this.top = this.top < 0 ? 0 : this.top;
            this.scrollTo(this.document.body, this.top, 500);
        }
    };
    ScrollPositionize.prototype.GetData = function (num) {
        var tmp = window.scrollY;
        if (tmp >= num)
            num += 200;
        else if (tmp < 1)
            return 200;
        else
            num -= 200;
        num = parseInt(((num / 200)).toString()) * 200;
        return num > 0 ? num : 0;
    };
    ScrollPositionize.prototype.scrollTo = function (element, to, duration) {
        var _this = this;
        this.key = true;
        var start = element.scrollTop, change = to - start, currentTime = 0, increment = 20;
        var animateScroll = function () {
            currentTime += increment;
            var val = _this.Method(currentTime, start, change, duration);
            element.scrollTop = val;
            if (currentTime < duration)
                setTimeout(animateScroll, increment);
            else {
                _this.key = false;
                _this.done = true;
                _this.obj = null;
            }
        };
        animateScroll();
    };
    ScrollPositionize.prototype.Method = function (t, b, c, d) {
        t /= d / 2;
        if (t < 1)
            return c / 2 * t * t + b;
        t--;
        return -c / 2 * (t * (t - 2) - 1) + b;
    };
    return ScrollPositionize;
}());
exports.ScrollPositionize = ScrollPositionize;
//# sourceMappingURL=scroll.positionize.js.map