
var state = 0;
var span = document.getElementById("state");
function cahngeStates() {
    red.classList.remove("red");
    yellow.classList.remove("yellow");
    green.classList.remove("green");

    if (state === 0) 
     {
        red.classList.add("red");
        yellow.classList.add("gray");
        green.classList.add("gray");
        span.innerText ="ready"; 
     }
     else if (state === 1) 
     {
        yellow.classList.add("yellow");
        red.classList.add("gray");
        green.classList.add("gray");
        span.innerText ="Steady"; 

     }
     else 
      {

        green.classList.add("green");
        yellow.classList.add("gray");
        red.classList.add("gray");
        span.innerText ="Go"; 

      }
    


      state = (state + 1) % 3;  
      console.log(state);
  }




setInterval(cahngeStates,500);
