var elements = [false, false, false, false];
var imageInterval;
var titles, descriptions, names, buttons;
var images;

function CarouselOnLoad() {
    images = document.getElementsByClassName("image");
    titles = document.getElementsByClassName("title");
    descriptions = document.getElementsByClassName("description");
    names = document.getElementsByClassName("name");
    buttons = document.getElementsByClassName("readmore-button");

    images[0].classList.remove("hidden-image");
    images[0].classList.add("show-animated");
    elements[0] = true;
    ShowText();

    for (var i = 0; i < images.length; ++i) {
        images[i].style.top = "-"+(i*100)+"%";
    }
    LoadCycle();
}

function LoadCycle() {
    imageInterval = setInterval(function () {
        for (var i = 0; i < 4; ++i) {
            if (elements[i]) {
                HideImage(images[i]);
                var j = i + 1;
                if (j > 3)
                    j = 0;
                ShowImage(images[j]);                
                elements[i] = false;
                elements[j] = true;
                ShowText();
                HideText(i);
                break;
            }
        }
    },12000);
}

function ShowImage(element) {
    if (element.classList.contains("hidden-image"))
        element.classList.remove("hidden-image");
    if (element.classList.contains("hide-animated"))
        element.classList.remove("hide-animated");
    element.classList.add("show-animated");
}
function HideImage(element) {
    element.classList.remove("show-animated");
    element.classList.add("hide-animated");
}

function ShowText() {
    var index = GetIndex();
    setTimeout(function () {
        titles[index].classList.remove("hideText");
        titles[index].classList.add("showText");
    },500);
    setTimeout(function () {
        descriptions[index].classList.remove("hideText");
        descriptions[index].classList.add("showText");
    }, 800);
    setTimeout(function () {
        names[index].classList.remove("hideText");
        names[index].classList.add("showText");
    }, 1100);
    setTimeout(function () {
        buttons[index].classList.remove("hideMore");
        buttons[index].classList.add("showText");
    }, 1300);
}
function HideText(index) {
    setTimeout(function () {
        titles[index].classList.remove("showText");
        titles[index].classList.add("hideText");
        descriptions[index].classList.remove("showText");
        descriptions[index].classList.add("hideText");        
        names[index].classList.remove("showText");
        names[index].classList.add("hideText");        
        buttons[index].classList.remove("showText");
        buttons[index].classList.add("hideMore");
    }, 500);

}
function GetIndex() {
    var index = -1;
    for (var i = 0; i < 4; ++i)
        if (elements[i])
            index = i;
    return index;
}

function SliderArrow(side) {
    clearInterval(imageInterval);

    var index = GetIndex();
    var previous = index;
    if (side === 'left') {
        --index;
        if (index < 0)
            index = 3;
    }
    else if(side === 'right') {
        index++;
        if (index > 3)
            index = 0;
    }
    Slide(index, previous);
    LoadCycle();
}

function Slide(next, previous) {
    elements[next] = true;
    elements[previous] = false;
    HideImage(images[previous]);
    ShowImage(images[next]);

    HideText(previous);
    ShowText();
}

function SlideToNumber(index) {
    clearInterval(imageInterval);
    var previous = GetIndex();
    Slide(index,previous);
    LoadCycle();
}
