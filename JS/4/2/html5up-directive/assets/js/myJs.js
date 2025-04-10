var night = false;
var firstTime = true;
var colors = []
var elements = [];
function changeMode(){
    if(firstTime)
    {
        var body =  document.getElementsByTagName("body")[0];
        var txt = document.getElementsByTagName("textarea")[0]
        var inputText =  document.querySelectorAll('input[type="text"]')[0];
        var inputEmail =  document.querySelectorAll('input[type="email"]')[0];
        var footer = document.getElementById("footer");
        var cont = document.getElementsByClassName("container");

        elements.push(body,txt,inputText,inputEmail,footer);
        for(var i = 0 ; i<cont.length;i++)
            elements.push(cont[i]);

        for(var i = 0 ;i<elements.length;i++)
            colors.push(elements[i].style.backgroundColor);
        
        console.log(colors.length)
        firstTime = false;
     
    }

    if(night){
        document.getElementById("pageMode").src ="images/black.png";
        for(var i = 0 ; i<elements.length;i++)
            elements[i].style.backgroundColor = colors[i];
        night = false;
    }
    else{
        document.getElementById("pageMode").src ="images/white.png";
        for(var i = 0;i<elements.length;i++)
            elements[i].style.backgroundColor="black"
        night=true;
    }
    


}