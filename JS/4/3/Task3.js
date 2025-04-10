function execute(number){
    const images = ["images/1.jpg", "images/2.jpg", "images/3.jpg", "images/4.jpg"];
    var x = document.getElementById("sliderImage").getAttribute("src"); 
    var idx = images.indexOf(x);
    var lene = images.length;
    // ((a % b) + b) % b;
    var len = images.length;
    idx+=Number(number);
    var nextIdx = ((idx%len)+len)%len ;
    document.getElementById("sliderImage").setAttribute("src",images[nextIdx]) ;
}