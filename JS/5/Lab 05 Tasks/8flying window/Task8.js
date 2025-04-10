var myWind ;
var x = 0 ;
var y = 0 ;
var down = true;
var speed = 3;
  const targetX = window.screen.availWidth;  
  const targetY = window.screen.availHeight - 100;    
function fly(){
     myWind = open("Copy.html","","width=50 , height=50")
    
    function moveWindow() {
        if (down) {
            x += speed;
            y += speed;
            
            
            if (x >= targetX || y >= targetY ) {
                down = false;  
            }
          } 
          else {
            x -= speed;
            y -= speed;
    
            if (x <= 0 || y <= 0) {
                down = true;  
            }
          }
    myWind.moveTo(x, y);
    myWind.resizeTo(50, 50);
    animationFrameId = requestAnimationFrame(moveWindow);}
    moveWindow() 
}

function stop(){
        if (animationFrameId) {
          cancelAnimationFrame(animationFrameId);
          animationFrameId = null;
        }
        if (myWind) {
            myWind.close();
        }
      
}
