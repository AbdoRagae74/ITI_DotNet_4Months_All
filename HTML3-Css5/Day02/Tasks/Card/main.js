
document.addEventListener('mousemove', function(event) {
    console.log("AS");
    document.getElementById('x-coord').innerHTML = event.clientX;  // Mouse X position
    document.getElementById('y-coord').innerHTML = event.clientY;  // Mouse Y position
  });