const images = ["images/1.jpg", "images/2.jpg", "images/3.jpg", "images/4.jpg"];
function execute(number){
    var x = document.getElementById("sliderImage").getAttribute("src"); 
    var idx = images.indexOf(x);
    // ((a % b) + b) % b;
    var len = images.length;
    idx+=Number(number);
    var nextIdx = ((idx%len)+len)%len ;
    document.getElementById("sliderImage").setAttribute("src",images[nextIdx]) ;
}

var interval;
function start(){
    interval = setInterval(function(){
        
        var x = document.getElementById("sliderImage").getAttribute("src"); 
        var idx = images.indexOf(x);
        // ((a % b) + b) % b;
        var len = images.length;
        idx+=1;
        var nextIdx = ((idx%len)+len)%len ;
    document.getElementById("sliderImage").setAttribute("src",images[nextIdx]) ;
    }
        
        ,200)
}


function stop(){

    clearInterval(interval);
}
