//System.import('app').catch(function (err) { console.error(err); });
$(document).ready(function () {
    window.addEventListener("scroll", runOnScroll);
});

var scrollZeroKey = true;

var runOnScroll = function (event) {
    var scrollPosition = event.path[0].scrollY;
    
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
    var topFooter = document.getElementsByClassName("top-footer")[0];
    var gamburger = document.getElementsByClassName("spinner")[0];

    if (topFooter.classList.contains("fadeOutUp")) {
        topFooter.classList.remove("fadeOutUp");
        gamburger.classList.remove("fadeIn");
    }
    gamburger.classList.add("fadeOut");
    topFooter.classList.add("fadeInDown");


}

function hideMenu() {
    scrollZeroKey = false;
    var topFooter = document.getElementsByClassName("top-footer")[0];
    var gamburger = document.getElementsByClassName("spinner")[0];

    if (topFooter.classList.contains("fadeInDown")) {
        topFooter.classList.remove("fadeInDown");        
    }
    gamburger.classList.remove("fadeOut");
    topFooter.classList.add("fadeOutUp");
    gamburger.classList.add("fadeIn");

}
