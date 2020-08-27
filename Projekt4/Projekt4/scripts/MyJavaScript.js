function lettersonly(input) {

    var regex = /[^a-z ]/gi;
    input.value = input.value.replace(regex, "");

}

function openchannel(day, elmnt) {
    var i, channelcont;
    channelcont = document.getElementsByClassName("channel-cont");
    //remove all divs by default
    for (i = 0; i < channelcont.length; i++) {
        channelcont[i].style.display = "none";
    }
    // Show the specific div content
    document.getElementById(day).style.display = "block";
}