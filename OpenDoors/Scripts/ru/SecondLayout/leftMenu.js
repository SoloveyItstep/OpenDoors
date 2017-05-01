var body, dropdownKey = false, language, showLang = false;
window.onload = function () {
    document.querySelector("#spinner-form2").addEventListener("change", ShowHideMenu);
}

function ShowHideMenu(event) {
    var gamburger = document.getElementsByClassName("spinner-master2")[0];
    var checkbox = document.getElementById("spinner-form2");
    var pall = document.getElementById("close-menu-pall");
    var leftMenu = document.getElementById("left-menu");
    
    if (event.target == pall) {
        checkbox.checked = false;
        leftMenu.classList.remove("left-menu-show");
        leftMenu.classList.add("left-menu-hide");
        pall.classList.remove("show-close-menu-pall");
        pall.classList.add("hide-close-menu-pall");
    }
    else if (event.target == checkbox) {
        if (leftMenu.classList.contains("left-menu-onload"))
            leftMenu.classList.remove("left-menu-onload");
        if (pall.classList.contains("move-close-menu-pall"))
            pall.classList.remove("move-close-menu-pall");

        if (checkbox.checked) {
            leftMenu.classList.remove("left-menu-hide");
            leftMenu.classList.add("left-menu-show");
            pall.classList.remove("hide-close-menu-pall");
            pall.classList.add("show-close-menu-pall");
        }
        else {
            leftMenu.classList.remove("left-menu-show");
            leftMenu.classList.add("left-menu-hide");
            pall.classList.remove("show-close-menu-pall");
            pall.classList.add("hide-close-menu-pall");            
        }
    }
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
    }
    else if (area.classList.contains("hide-dropdown")) {
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
        if (!event.path.includes(dropdown))
            ShowHideDropDown();
    }
    dropdownKey = false;
}

function ShowHideLanguage() {
    if (language == undefined)
        language = document.getElementById("language-item");
    if (body == undefined)
        body = document.getElementsByTagName("body")[0];
    
    if (language.classList.contains("delete-language") || language.classList.contains("hide-language")) {
        showLang = true;
        
        if (language.classList.contains("delete-language"))
            language.classList.remove("delete-language");
        language.classList.remove("hide-language");
        language.classList.add("show-language");
        body.addEventListener('click', languageEvent);
    }
    else if (language.classList.contains("show-language")) {
        language.classList.add("hide-language");
        language.classList.remove("show-language");
        body.removeEventListener('click', languageEvent);
    }
}

function languageEvent(event) {
    if (showLang == true) {
        console.log(event.path);
        showLang = false;
        language.removeEventListener('click', languageEvent);
        var main = document.getElementById("lang-container");
        if (!event.path.includes(main))
            ShowHideLanguage();
    }
    showLang = true;
}