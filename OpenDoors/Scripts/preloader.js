document.onreadystatechange = function (e) {
    if (document.readyState == "interactive") {
        var all = document.getElementsByTagName("*");
        for (var i = 0, max = all.length; i < max; i++) {
            check_element(all[i]);
        }
    }
}
var loadDataComplete = false;

function check_element(ele) {
    var all = document.getElementsByTagName("*");
    var percantage = 100 / all.length;

    if ($(ele).on()) {
        var prog_width = percantage + Number(document.getElementById("progress_width").value);
        if (prog_width > 100.1) {
            prog_width -= 100;
        }
        document.getElementById("progress_width").value = prog_width;
        $("#bar1").animate({ width: prog_width + "%" }, 10, function () {
            //var persentages = Math.round(parseInt(document.getElementById("bar1").style.width));
            if (Math.round(prog_width) == "100") {
                //console.log("100%");
                LoadComplete();
            }
            else {

                //console.log(Math.round(prog_width));
            }
        });
    }

    else {
        set_ele(ele);
    }
}
function LoadComplete() {
    if (loadDataComplete) {
        $(".progress-preload").fadeOut("slow");
        var prog = $("#prog");

        setTimeout(function () {
            //prog.css({ 'display': 'none' });
            prog.addClass("preloadFadeOut");
            setTimeout(function () {
                prog.addClass("hidden");
                //prog.css({ 'display': 'none' });
            }, 500);
        }, 1500);
    }
    else {
        setTimeout(LoadComplete, 250);
        console.log(loadDataComplete);
    }
}