"use strict";

var body = undefined,
    dropdownKey = false,
    language = undefined,
    showLang = false;
document.addEventListener("DOMContentLoaded", ready);

function ready() {
    document.getElementsByClassName("spinner-master2")[0].addEventListener("click", ShowHideMenu);
}

function logoClick(lang) {
    window.location.replace("/" + lang + "/home/main");
}

function ShowHideMenu(event) {
    var gamburger = document.getElementsByClassName("spinner-master2")[0];
    var checkbox = document.getElementById("spinner-form2");
    var pall = document.getElementById("close-menu-pall");
    var menu = document.getElementById("menu");
    var gamb = document.getElementById("gamburger");

    if (event.target == pall) {
        checkbox.checked = false;
        menu.classList.remove("show-menu");
        menu.classList.add("hide-menu");
        pall.classList.remove("show-close-menu-pall");
        pall.classList.add("hide-close-menu-pall");
        gamb.classList.remove("show-gamb");
        gamb.classList.add("hide-gamb");
    } else if (event.target == checkbox) {
        if (menu.classList.contains("delete-menu")) menu.classList.remove("delete-menu");
        if (pall.classList.contains("move-close-menu-pall")) pall.classList.remove("move-close-menu-pall");
        if (gamb.classList.contains("delete-gamb")) gamb.classList.remove("delete-gamb");

        if (checkbox.checked) {
            menu.classList.remove("hide-menu");
            menu.classList.add("show-menu");
            pall.classList.remove("hide-close-menu-pall");
            pall.classList.add("show-close-menu-pall");
            gamb.classList.add("show-gamb");
            gamb.classList.remove("hide-gamb");
        } else {
            menu.classList.remove("show-menu");
            menu.classList.add("hide-menu");
            pall.classList.remove("show-close-menu-pall");
            pall.classList.add("hide-close-menu-pall");
            gamb.classList.remove("show-gamb");
            gamb.classList.add("hide-gamb");
        }
    }
}

function ShowHideLanguage() {
    if (language == undefined) language = document.getElementById("language-item");
    if (body == undefined) body = document.getElementsByTagName("body")[0];

    if (language.classList.contains("delete-language") || language.classList.contains("hide-language")) {
        showLang = true;

        if (language.classList.contains("delete-language")) language.classList.remove("delete-language");
        language.classList.remove("hide-language");
        language.classList.add("show-language");
        body.addEventListener('click', languageEvent);
    } else if (language.classList.contains("show-language")) {
        language.classList.add("hide-language");
        language.classList.remove("show-language");
        body.removeEventListener('click', languageEvent);
    }
}

function languageEvent(event) {
    if (showLang == true) {
        showLang = false;
        language.removeEventListener('click', languageEvent);
        var main = document.getElementById("lang-container");
        if (!event.path.includes(main)) ShowHideLanguage();
    }
    showLang = true;
}
function ShowHideDropDown() {
    var area = document.getElementsByClassName("dropdown-area")[0];
    var drop = document.getElementsByClassName("drop-down-left")[0];
    body = document.getElementsByTagName("body")[0];
    var arrow = document.getElementById("dropdown-arrow");

    if (area.classList.contains("hide-element") == 1) {
        area.classList.remove("hide-element");
        area.classList.add("show-dropdown");
        drop.classList.add("up");
        dropdownKey = true;
        body.addEventListener("click", DropDownEvent);
        arrow.classList.add("arrow-rotate");
        return;
    }
    if (area.classList.contains("show-dropdown")) {
        area.classList.remove("show-dropdown");
        area.classList.add("hide-dropdown");
        drop.classList.remove("up");
        arrow.classList.remove("arrow-rotate");
    } else if (area.classList.contains("hide-dropdown")) {
        area.classList.remove("hide-dropdown");
        area.classList.add("show-dropdown");
        drop.classList.add("up");
        dropdownKey = true;
        body.addEventListener("click", DropDownEvent);
        arrow.classList.add("arrow-rotate");
    }
}

function DropDownEvent(event) {
    var element = event.path[0];
    var dropdown = document.getElementsByClassName("drop-down-left")[0];
    if (!dropdownKey) {
        body.removeEventListener("click", DropDownEvent);
        if (!event.path.includes(dropdown)) ShowHideDropDown();
    }
    dropdownKey = false;
}

