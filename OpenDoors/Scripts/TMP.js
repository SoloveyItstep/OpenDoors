var key = false;
document.onreadystatechange = function (e) {
    if (document.readyState == "interactive") {
        var all = document.getElementsByTagName("*");
        for (var i = 0, max = all.length; i < max; i++) {
            check_element(all[i]);
        }
    }
}
var loadWidth = 0;
var loadComplete = false;
function check_element(ele) {
    var all = document.getElementsByTagName("*");
    var percantage = 100 / all.length;
    var progress = document.getElementById("progress_width");
    //===============================
    var prog_width = percantage + Number(progress.value);
    if (prog_width > 100.1)
        prog_width -= 100;
    progress.value = prog_width;

    document.getElementById("bar1").style.width = prog_width + "%";
    if (Math.round(prog_width) == "100")
        LoadComplete();
}
function LoadComplete() {
    var prog = document.getElementById("prog");
    setTimeout(function () {
        prog.classList.add("preloadFadeOut");
        document.getElementsByTagName("body")[0].classList.remove("hide-scroll");
        prog.classList.add("hidden");
        if (typeof CarouselOnLoad === 'function' && !key) {
            CarouselOnLoad();
            OnPageLoaded();
            key = true;
        }
    }, 1000);
}