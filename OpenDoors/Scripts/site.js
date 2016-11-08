$(document).ready(function () {
    document.addEventListener("scroll", runOnScroll);
    var scrollTop1 = document.documentElement.scrollTop;
    var scrollTop2 = document.body.scrollTop;
    if (scrollTop1 > 0 || scrollTop2 > 0) {
        hideMenu();
    }
    document.querySelector("#spinner-form2").addEventListener("change", gamburgerMenu);
});

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
}
function closeBodyClicked() {
    var checked = document.getElementById("spinner-form2");
    checked.checked = !checked.checked;
    hideLeftMenu();
}
var scrollZeroKey = true;

var runOnScroll = function (event) {
    var scrollPosition = 0.0;
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
    
};

function showMenu() {
    scrollZeroKey = true;
    var header = document.getElementsByClassName("header")[0];
    var gamburger = document.getElementsByClassName("spinner")[0];

    if (header.classList.contains("fadeOutUp")) {
        header.classList.remove("fadeOutUp");
        gamburger.classList.remove("fadeIn");
    }
    gamburger.classList.add("fadeOut");
    header.classList.add("fadeInDown");
}

function hideMenu() {
    scrollZeroKey = false;
    var topFooter = document.getElementsByClassName("header")[0];
    var gamburger = document.getElementsByClassName("spinner")[0];

    if (topFooter.classList.contains("fadeInDown")) {
        topFooter.classList.remove("fadeInDown");        
    }
    gamburger.classList.remove("fadeOut");
    topFooter.classList.add("fadeOutUp");
    gamburger.classList.add("fadeIn");

}
