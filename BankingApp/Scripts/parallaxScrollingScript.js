/*parallaxScrollingScript*/

var topDiv = document.getElementById("wrapper");
var topDiv2 = document.getElementById("wrapper2");
var speed = 3.5;

window.onscroll = function () {
    var yOffset = window.pageYOffset;
    topDiv.style.backgroundPosition = "0px " + (yOffset / speed) + "px";
    topDiv2.style.backgroundPosition = "0px " + (yOffset / speed) + "px";
}