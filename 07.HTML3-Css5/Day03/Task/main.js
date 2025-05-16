var preloader = document.getElementsByClassName("preloader")[0];
var header = document.getElementsByTagName("header")[0];
var h = document.getElementsByTagName("h1")[0];
var s = document.getElementById("hero-span");
var offers = document.getElementsByClassName("offer");
var categories = document.getElementsByClassName("category");

window.onscroll = function(){
  if(scrollY>420)
    {
      header.classList.add("fixed-bar");
      offers[0].style.animation="offerFade 1.5s forwards";
      offers[1].style.animation="offerFade 1.5s 0.4s forwards";
      offers[2].style.animation="offerFade 1.5s 0.8s forwards";

      categories[0].style.animation="offerFade 1.5s forwards";
      categories[1].style.animation="offerFade 1.5s 0.3s forwards";
      categories[2].style.animation="offerFade 1.5s 0.6s forwards";
      categories[3].style.animation="offerFade 1.5s 0.9s forwards";
    }
    else 
    {
      header.classList.remove("fixed-bar");

    }
  
} 

window.onload = function (){
  setTimeout(function() {
    
    preloader.style.transition="opacity .3s ease, transform 0.5s ease";
    preloader.style.opacity="0";
    setTimeout(function(){
    preloader.style.display="none";

    },400)
    
  }, 1000);

  h.style.animation="textFade 1.9s forwards";
  s.style.animation="textFade 1.5s forwards";


}