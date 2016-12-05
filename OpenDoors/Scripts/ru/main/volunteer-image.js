var scrollZero = true;
function OnPageLoaded() {
    var scrolled = window.pageYOffset || document.documentElement.scrollTop;
    if (scrolled > 0)
        ShowVolunteerImage();
}

window.onscroll = function () {
    var scrolled = window.pageYOffset || document.documentElement.scrollTop;
    if (scrolled > 0 && scrollZero)
        ShowVolunteerImage();
    else if (scrolled === 0)
        HideVolunteerImage();
}
function VolunteerPage() {
    console.log("To Do Link");
}
function ShowVolunteerImage() {
    var block = document.getElementsByClassName("volunteer-info")[0];
    var image = document.getElementsByClassName("volunteer-image")[0];
    scrollZero = false;
    setTimeout(function () {
        block.classList.remove("hide-info-block");
        block.classList.add("show-info-block");
        image.classList.remove("hide-block");
        image.classList.add("show-block");
    }, 300);
}
function HideVolunteerImage() {
    var block = document.getElementsByClassName("volunteer-info")[0];
    var image = document.getElementsByClassName("volunteer-image")[0];
    scrollZero = true;

    block.classList.remove("show-info-block");
    block.classList.add("hide-info-block");
    image.classList.remove("show-block");
    image.classList.add("hide-block");
}