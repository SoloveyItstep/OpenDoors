

(function () {
    //document.addEventListener('mousewheel DOMMouseScroll', wheel, false);
    var key = false;
    var top = 0;
    var onLoadY = 0;
    var done = false;
    var obj;



    if (document.addEventListener) {
        // IE9, Chrome, Safari, Opera
        document.addEventListener("mousewheel", wheel, false);
        // Firefox
        document.addEventListener("DOMMouseScroll", wheel, false);
    }
        // IE 6/7/8
    else
        document.attachEvent("onmousewheel", wheel);

    function wheel(event) {
        //console.log(event.screenY);
        //if (event.deltaY > 0)
        //    scrollDown();
        //else if (event.deltaY < 0)
        //    scrollUp();
    }

    function scrollDown() {
        if (!obj) {
            obj = new Object();
            //console.log(document.body.scrollTop);
            top = GetData(document.body.scrollTop);
            scrollTo(document.body, top, 500);
        }
    }

    function scrollUp() {
        if (!obj) {
            obj = new Object();
            top -= 160;
            top = top < 0 ? 0 : top;
            scrollTo(document.body, top, 500);
        }
    }


    function GetData(num) {
        var tmp = window.scrollY;
        if (tmp >= num)
            num += 160;
        else if (tmp < 1)
            return 160;
        else
            num -= 160;
        num = parseInt(((num / 160)).toString()) * 160;
        return num > 0 ? num : 0;
    }

    function scrollTo(element, to, duration) {
        key = true;
        var start = element.scrollTop,
            change = to - start,
            currentTime = 0,
            increment = 20;

        var animateScroll = () => {
            currentTime += increment;
            var val = Method(currentTime, start, change, duration);

            element.scrollTop = val;
            if (currentTime < duration)
                setTimeout(animateScroll, increment);
            else {
                key = false;
                done = true;
                obj = null;
                //console.log(this.top + " - " + this.document.body.scrollTop);
            }
        };
        animateScroll();
    }

    function Method(t, b, c, d) {
        t /= d / 2;
        if (t < 1)
            return c / 2 * t * t + b;
        t--;
        return -c / 2 * (t * (t - 2) - 1) + b;
    }


})();



