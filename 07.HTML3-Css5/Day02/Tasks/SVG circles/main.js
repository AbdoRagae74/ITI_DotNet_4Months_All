canvas = document.querySelector("canvas");
//Context
ctxt = canvas.getContext("2d");
ctxt.strokeStyle="#ff0000";
ctxt.beginPath();
ctxt.arc(95, 50, 20, 0, 2 * Math.PI);
ctxt.stroke();
var colorPicker = document.getElementById("color");

function getRandomIntInRange(max) {
    return Math.floor(Math.random() * (max + 1)) ;
}

var previousColor = ctxt.strokeStyle; 

function draw(){
   
    if(previousColor != colorPicker.value)
        {
            ctxt.clearRect(0, 0, canvas.width, canvas.height);            
            previousColor = colorPicker.value
            ctxt.strokeStyle = colorPicker.value;
        }
    for(var i = 0 ; i<20;i++){
    var a = getRandomIntInRange(700);
    var b = getRandomIntInRange(400);
    ctxt.beginPath();
    ctxt.arc(a, b, 20, 0, 2 * Math.PI);
    ctxt.stroke();
    }


}