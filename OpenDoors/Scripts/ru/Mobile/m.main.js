var currents = [true, false, false, false];
var images = [], descriptions = [], texts = [], links = [];
var imageInterval = {};
var presPosition, key = false;


window.onload = function () {
    Function.prototype.bind = function (parent) {
        var f = this;
        var args = [];
        for (var a = 1; a < arguments.length; a++) {
            args[args.length] = arguments[a];
        }
        var temp = function () {
            return f.apply(parent, args);
        }
        return (temp);
    }
    OnLoadCycle();
    var carousel = document.getElementsByClassName("carousel")[0];
    carousel.addEventListener("touchstart", swipeStart, false);
    carousel.addEventListener("touchmove", swipeEvent, false);
    carousel.addEventListener("touchend", swipeEnd, false);
    
}
function OnLoadCycle() {
    images = document.getElementsByClassName("image");
    descriptions = document.getElementsByClassName("text-description");
    texts = document.getElementsByClassName("text-name");
    links = document.getElementsByClassName("button-link");
    onTextLoad();
    images[0].style.marginLeft = 0 + "%";
    setTimeout(function () {
        images[3].style.marginLeft = 100 + "%";

    }.bind(this), 1000);
    imageInterval = setInterval(Cycle, 3000);
}

function onTextLoad() {
    for (var i = 1; i < 4; ++i) {
        descriptions[i].style.marginLeft = "-300%";
        texts[i].style.marginLeft = "-300%";
        links[i].style.marginLeft = "-300%";
    }
    setTimeout(function () {
        for (var i = 0; i < 4; ++i) {
            descriptions[i].classList.add('text-transition-1');
            texts[i].classList.add('text-transition-2');
            links[i].classList.add('text-transition-3');
        }
    }, 20);
}

function Cycle() {
    for (var i = 0; i < 4; ++i){
        if (currents[i]) {
            var prev = i;
            var current = prev + 1;
            if (current > 3)
                current = 0;
            var next = current + 1;
            if (next < 0)
                next = 3;
            currents[prev] = false;
            currents[current] = true;
            ShowLeft(current);
            HideRight(prev);
            var obj = getCurrents();
            Unmantioned(obj.cur, obj.prev, obj.nex);
            if (images[obj.nex].style.marginLeft.replace('%') == "100") {
                images[obj.nex].classList.remove('trans');
                images[obj.nex].style.marginLeft = -100 + '%';
            }
            ShowText(obj);
            HideText(obj);
            break;
        }
    }
}
function ShowText(obj) {
    descriptions[obj.cur].style.marginLeft = "0%";
    texts[obj.cur].style.marginLeft = "0%";
    links[obj.cur].style.marginLeft = "0%";
}
function HideText(obj) {
    descriptions[obj.prev].style.marginLeft = "-300%";
    texts[obj.prev].style.marginLeft = "-300%";
    links[obj.prev].style.marginLeft = "-300%";
}
function Unmantioned(current, previous, next) {
    for (var i = 0; i < 4; ++i) {
        if (i != current && i != previous && i != next) {
            images[i].classList.remove("trans");
            images[i].style.marginLeft = -100+"%";
        }
    }
}

function HideRight(index) {
    images[index].classList.add("trans");
    images[index].style.marginLeft = 100 + "%";
}
function ShowLeft(index) {
     images[index].classList.add("trans");
     images[index].style.marginLeft = 0 + "%";
}
function SetNext(index) {
    images[index].classList.remove("trans");
    images[index].style.marginLeft = "-100%";
}
function swipeStart(event) {
    presPosition = event.touches[0].clientX;
    for (var i = 0; i < 4; ++i) {
        images[i].style.marginLeft = images[i].offsetLeft;
        images[i].classList.remove("trans");
    }
}
function swipeEvent(event) {
    if (!presPosition)
        return;   
    clearInterval(imageInterval);
    var obj = getCurrents();
    var position = event.touches[0].clientX;
    var diff = position - presPosition;
    var width = window.innerWidth || document.documentElement.clientWidth || document.body.clientWidth;
    images[obj.cur].style.marginLeft = diff + "px";
    images[obj.prev].style.marginLeft = width + diff + "px";
    images[obj.nex].style.marginLeft = -width + diff + "px";
}
function swipeEnd(event) {

    var obj = getCurrents();
    var width = window.innerWidth || document.documentElement.clientWidth || document.body.clientWidth;
    var current = images[obj.cur].style.marginLeft.replace('px', '');
    var quoter = width / 4;
    images[obj.cur].classList.add("trans");
    images[obj.prev].classList.add("trans");
    images[obj.nex].classList.add("trans");
    if (current <= quoter && current > -quoter) {
        images[obj.prev].style.marginLeft = "100%";
        images[obj.cur].style.marginLeft = "0%";
        images[obj.nex].style.marginLeft = "-100%";
        ShowText({ cur: obj.cur, prev: obj.prev, nex: 0 });
        HideText({ cur: obj.cur, prev: obj.prev, nex: 0 });
    }
    else if (current < 0 && current <= -quoter) {
        images[obj.prev].style.marginLeft = "0%";
        images[obj.cur].style.marginLeft = "-100%";
        images[obj.nex].style.marginLeft = "-100%";

        for (var i = 0; i < 4; ++i) {
            if (i == obj.prev)
                currents[i] = true;
            else
                currents[i] = false;
        }
        ShowText({ cur: obj.prev, prev: 0, nex: 0 });
        HideText({ cur: 0, prev: obj.cur, nex: 0 });
    }
    else if (current > quoter) {
        images[obj.prev].style.marginLeft = 100 + "%";
        images[obj.cur].style.marginLeft = 100 + "%";
        images[obj.nex].style.marginLeft = 0 + "%";
        for (var i = 0; i < 4; ++i) {
            if (i == obj.nex)
                currents[i] = true;
            else
                currents[i] = false;
        }
        ShowText({ cur: obj.nex, prev: 0, nex: 0 });
        HideText({ cur: 0, prev: obj.cur, nex: 0 });
    }
    //===============
    setTimeout(function () {
        var obj = getCurrents();
        Unmantioned(obj.cur, obj.prev, obj.nex);
    }, 1000);
    imageInterval = setInterval(Cycle, 3000);
}
function getCurrents() {
    var obj = { prev: 0, cur: 0, nex: 0 };
    for (var i = 0; i < 4; ++i) {
        if (currents[i]) {
            obj.cur = i;
            obj.prev = i - 1;
            if (obj.prev < 0)
                obj.prev = 3;
            obj.nex = i + 1;
            if (obj.nex > 3)
                obj.nex = 0;
            return obj;
        }
    }
}

function positionizeImages() {
    var obj = getCurrents();
    images[obj.nex].classList.remove("trans");
    images[obj.prev].classList.remove("trans");
    Unmantioned(obj.cur, obj.prev, obj.prev);
    images[obj.nex].style.marginLeft = -100 + "%";
    images[obj.prev].style.marginLeft = 100 + "%";
    setTimeout(function () {
        images[obj.nex].classList.add("trans");
        images[obj.prev].classList.add("trans");
    }, 1);
}

function folow() {

}