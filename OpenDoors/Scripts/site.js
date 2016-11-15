$(document).ready(function () {
    document.addEventListener("scroll", runOnScroll);
    var scrollTop1 = document.documentElement.scrollTop;
    var scrollTop2 = document.body.scrollTop;
    if (scrollTop1 > 0 || scrollTop2 > 0) {
        hideMenu();
    }
    document.querySelector("#spinner-form2").addEventListener("change", gamburgerMenu);
    //document.querySelector(".left-menu-drpdown").addEventListener("mouseover", showDropDown);
    //document.querySelector(".left-menu-drpdown").addEventListener("mouseleave", hideDropDown);
});

var bodyClickEventLestener;

function ShowDropDown() {
    var element = $(".drop-down-content-left").first();
    var opacity = element.css("opacity");
    var content = document.getElementsByClassName("drop-down-content-left")[0];
    var dropdownHeight = $("#indent-menu-for-dropdown");
    var arrow = document.getElementById("dropdown-arrow-left");

    if (opacity == 0) {
        content.classList.remove("dropup-height");
        content.classList.add("dropdown-height");
        dropdownHeight.height(220);
        arrow.classList.add("rotate-arrow");

        if (bodyClickEventLestener === undefined) {
            bodyClickEventLestener = $("body").click(Event);
            //console.log('event - 3');
        }
        else {
            bodyClickEventLestener.on("click",Event);
            //console.log('event - 4');
        }
    }
    else {
        content.classList.remove("dropdown-height");
        content.classList.add("dropup-height");
        dropdownHeight.height(50);
        arrow.classList.remove("rotate-arrow");
        // console.log("event - 5");
    }
    
}

function Event(event){
    var className = event.target.classList[0];
    var opacity = $(".drop-down-content-left").first().css("opacity");
    
    //console.log(opacity);
    //console.log(className);
    //console.log(event.target.classList[0] === "drop-down-text-left");
    if (className !== "drop-down-text-left" && opacity == 1) {
        
        bodyClickEventLestener.off();
        
        ShowDropDown();
        //console.log('event - 1');
    }
    else if (className !== "drop-down-text-left" && opacity < 1) {
        //console.log('event - 2');
        bodyClickEventLestener.off();
        
    }
}
//function showDropDown(){
//    var element = document.getElementsByClassName("drpdown-left-menu")[0];
//    if (!element.classList.contains("dropdown-animation")) {
//        element.classList.remove("dropup-animation");
//        element.classList.add("dropdown-animation");
//        var links = document.getElementsByClassName("drpdown-link-left");
//        for (var i = 0; i < links.length; ++i) {
//            links[i].classList.add("show-dropdown-menu-text");
//        }
//    }
//}
//function hideDropDown() {
//    var element = document.getElementsByClassName("drpdown-left-menu")[0];
//    if (!element.classList.contains("dropup-animation")) {
//        element.classList.remove("dropdown-animation");
//        element.classList.add("dropup-animation");
//        var links = document.getElementsByClassName("drpdown-link-left");
//        for (var i = 0; i < links.length; ++i) {
//            links[i].classList.remove("show-dropdown-menu-text");
//        }
//    }
//}
function gamburgerMenu(event){
    var checked = event.path[0].checked;

    if (checked)
        showLeftMenu();
    else if (!checked)
        hideLeftMenu();
}
function showLeftMenu() {
    var leftPanel = document.getElementsByClassName("left-panel")[0];
    var closeBody = document.getElementById("close-body");

    leftPanel.classList.contains("hide-menu") ? leftPanel.classList.remove("hide-menu") : "";
    leftPanel.classList.add("show-menu");
    closeBody.classList.contains("open-body") ? closeBody.classList.remove("open-body") : "";
    closeBody.classList.add("close-body");
}
function hideLeftMenu() {
    var leftPanel = document.getElementsByClassName("left-panel")[0];
    var closeBody = document.getElementById("close-body");

    leftPanel.classList.contains("show-menu") ? leftPanel.classList.remove("show-menu") : "";
    leftPanel.classList.add("hide-menu");    
    closeBody.classList.contains("close-body") ? closeBody.classList.remove("close-body") : "";
    closeBody.classList.add("open-body");
    
    var scrollTop1 = document.documentElement.scrollTop;
    var scrollTop2 = document.body.scrollTop;
    if (scrollTop1 > 0 || scrollTop2 > 0)
        scrollZeroKey = true;
    else
        scrollZeroKey = false;
    
    if (!scrollZeroKey) {
        showMenu();
    }
}
function closeBodyClicked() {
    var checked = document.getElementById("spinner-form2");
    checked.checked = !checked.checked;
    hideLeftMenu();
}
var scrollZeroKey = true;

var runOnScroll = function (event) {
    var scrollPosition = 0.0;
    var left = $(".left-panel").css("left");
    
    if (event.path == undefined) {
        scrollPosition = window.pageYOffset;
    }
    else {
        scrollPosition = event.path[1].scrollY;
    }
    if (scrollPosition > 0 && scrollZeroKey)
    {
        hideMenu();
    }
    else if(scrollPosition === 0 && !scrollZeroKey){
        showMenu();
    }

    if (left === "0px" && scrollPosition === 0) {
        hideMenu();
    }
    
};

function showMenu() {
    scrollZeroKey = true;
    var header = document.getElementsByClassName("header")[0];
    var gamburger = document.getElementsByClassName("spinner")[0];

    if (header.classList.contains("fadeOutUp")) {
        header.classList.remove("fadeOutUp");
        gamburger.classList.remove("show-gamburger");
    }
    gamburger.classList.add("hide-gamburger");
    header.classList.add("fadeInDown");
}

function hideMenu() {
    scrollZeroKey = false;
    var topFooter = document.getElementsByClassName("header")[0];
    var gamburger = document.getElementsByClassName("spinner")[0];

    if (topFooter.classList.contains("fadeInDown")) {
        topFooter.classList.remove("fadeInDown");        
    }
    gamburger.classList.remove("hide-gamburger");
    //gamburger.classList.add("hide-gamburger");
    topFooter.classList.add("fadeOutUp");
    gamburger.classList.add("show-gamburger");

}

function DropDownMenu() {
    //var btn = document.getElementsByClassName("drpdown-menu")[0];
    var menu = document.getElementsByClassName("drpdown-menu")[0];
    var links = document.getElementsByClassName("drpdown-link");
    var count = links.length;

    if (menu.classList.contains("dropdown-animation")) {
        menu.classList.remove("dropdown-animation");
        menu.classList.add("dropup-animation");
        for (var i = 0; i < count; ++i) {
            links[i].classList.add("hide-links");
        }
    }
    else {
        for (var i = 0; i < count; ++i) {
            links[i].classList.remove("hide-links");
        }
        menu.classList.add("dropdown-animation");
        menu.classList.remove("dropup-animation");
    }
}