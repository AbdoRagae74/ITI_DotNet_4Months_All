document.addEventListener("contextmenu", function (event) {
  event.preventDefault(); 
  console.log(event);
  alert("U can't use right click here");
});