var colors = null;
var loadColors = function () {
    var request = new XMLHttpRequest();
    request.open("GET", "/Color/");
    request.onload = function () {
        if (this.status >= 200 && this.status < 400) {
            colors = JSON.parse(this.response)
            displayColors();
        } else {
            console.log("Error on GET");
        }
    };
    request.onerror = function () {
        console.log("Comm error");
    }
    request.send();
}

var displayColors = function () {
    for (var i in colors) {
        document.getElementById("colors").innerHTML += displayColor(i);
    }
}

var displayColor = function (index) {
    return '<div class="col-md-4 col-lg-3 col-sm-6" style="background-color:' + colors[index].Value + '"><button class="btn btn-default" onclick="setColor(' + index + ')">' + colors[index].Name + '</button></div>';
}

var setColor = function (index) {
    var colorSpan = document.getElementById("favorite-color");
    colorSpan.innerText = colors[index].Name;
    colorSpan.style.color = colors[index].Value;
}

loadColors();