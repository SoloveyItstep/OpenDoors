$(document).ready(function () {
    try{
        $conf['image_allow_insecure_derivatives'] = true;
    }
    catch (ex) {
        console.log(ex.message);
    }
    document.addEventListener("scroll", runOnScroll);
    var scrollTop1 = document.documentElement.scrollTop;
    var scrollTop2 = document.body.scrollTop;
    if (scrollTop1 > 0 || scrollTop2 > 0)
        hideMenu();
    document.querySelector("#spinner-form2").addEventListener("change", gamburgerMenu);
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

        if (bodyClickEventLestener === undefined)
            bodyClickEventLestener = $("body").click(Event);
        else
            bodyClickEventLestener.on("click",Event);
    }
    else {
        content.classList.remove("dropdown-height");
        content.classList.add("dropup-height");
        dropdownHeight.height(50);
        arrow.classList.remove("rotate-arrow");
    }
    
}

function Event(event){
    var className = event.target.classList[0];
    var opacity = $(".drop-down-content-left").first().css("opacity");
    if (className !== "drop-down-text-left" && opacity == 1) {
        bodyClickEventLestener.off();
        ShowDropDown();
    }
    else if (className !== "drop-down-text-left" && opacity < 1)
        bodyClickEventLestener.off();
}
function gamburgerMenu(event) {
    var checked;
    if (event.path != undefined)
        checked = event.path[0].checked;
    else
        checked = event.target.checked;
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
    if (!scrollZeroKey)
        showMenu();
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
    
    if (event.path == undefined)
        scrollPosition = window.pageYOffset;
    else
        scrollPosition = event.path[1].scrollY;
    if (scrollPosition > 0 && scrollZeroKey)
        hideMenu();
    else if(scrollPosition === 0 && !scrollZeroKey)
        showMenu();
    if (left === "0px" && scrollPosition === 0)
        hideMenu();
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
    if (topFooter.classList.contains("fadeInDown"))
        topFooter.classList.remove("fadeInDown");        
    gamburger.classList.remove("hide-gamburger");
    topFooter.classList.add("fadeOutUp");
    gamburger.classList.add("show-gamburger");
}

function DropDownMenu() {
    var menu = document.getElementsByClassName("drpdown-menu")[0];
    var links = document.getElementsByClassName("drpdown-link");
    var count = links.length;
    if (menu.classList.contains("dropdown-animation")) {
        menu.classList.remove("dropdown-animation");
        menu.classList.add("dropup-animation");
        for (var i = 0; i < count; ++i)
            links[i].classList.add("hide-links");
    }
    else {
        for (var i = 0; i < count; ++i)
            links[i].classList.remove("hide-links");
        menu.classList.add("dropdown-animation");
        menu.classList.remove("dropup-animation");
    }
}