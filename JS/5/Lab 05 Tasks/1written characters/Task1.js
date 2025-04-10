function openWindow(){

    myWind = open("Copy.html","","width=400 , height=300")

    var str ="Hello ,  this is my string :)";

    myWind.onload = function () {
        var z = myWind.document.getElementById("abcd"); 
        z.innerHTML="";
        var idx = 0;
        var interval = setInterval(function(){
            if(idx<str.length)
            z.innerHTML+=str[idx++];
        else{
            myWind.close();
        }
        },200)
         
    };
}
