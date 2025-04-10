// // Select Canvas

// var canvas = document.querySelector("canvas");

// // canvas.style.backgroundColor = "#f80"

// // Define Context

// var context = canvas.getContext("2d");


// // Rectangle

// // 1- filled rectangle

// context.fillRect(50, 50, 100, 60);

// context.fillStyle = "blue";
// context.fillRect(100, 200, 80, 50);

// context.fillStyle = "green";
// context.fillRect(400, 100, 150, 80);

// // ===================

// canvas.addEventListener("mousemove", function (e) {
//   console.log(e.clientX, e.clientY);

// })

// // 2- outlined rectangle

// context.strokeStyle = "red";
// context.lineWidth = "4"
// context.strokeRect(240, 60, 120, 70);

// // ======================

// context.fillStyle = "orange"
// context.fillRect(300, 300, 100, 50);
// context.strokeStyle = "black";
// context.lineWidth = "2"
// context.strokeRect(300, 300, 100, 50)

// // ======================

// // Clear rect area.moveTo(600, 50)


// context.clearRect(450, 120, 30, 30);

// // ======================

// // line : p1(x1,y1), p2(x2,y2)

// // h-line : y1 = y2

// // v-line :  x1 = x2

// context.strokeStyle = "red";
// context.lineWidth = "3"
// context.moveTo(400, 30);
// context.lineTo(550, 30);
// context.stroke();

// // =================

// context.moveTo(370, 160);
// context.lineTo(220, 290);
// context.stroke();

// // ====================
// /**
//  *
//  * .
//  *
//  * .    .
//  */

// context.strokeStyle = "green";
// context.beginPath()
// context.moveTo(600, 50)
// context.lineTo(700, 150);
// context.lineTo(600, 150);
// // context.lineTo(600, 50)
// context.closePath();
// // context.fill();
// context.stroke();

// // ======================

// context.beginPath();
// context.arc(100, 340, 50, 0, Math.PI, true);
// context.fill();
// // context.stroke();

// // =======================

// context.beginPath();
// context.ellipse(470, 250, 60, 40, 0, 0, Math.PI * 2);
// // context.fill();
// context.stroke();

// // =====================

// context.fillStyle = "pink";
// context.font = "30px Arial"
// context.fillText("Hello,Canvas", 50, 165);

// context.lineWidth = "1"
// context.font = "40px Arial"

// context.strokeText("Hello,Canvas", 450, 330)

// ==========================


// var canvas = document.querySelector("canvas");

// var context = canvas.getContext("2d")

// canvas.width = window.innerWidth * 0.8;
// canvas.height = window.innerHeight * 0.6;

// var x = canvas.width / 2;

// var y = canvas.height / 2;

// var r = 20;

// var dx = 4;
// var dy = 3;

// var counterDiv = document.getElementById("counter");
// var counter = 0;

// function animate() {
//   context.clearRect(0, 0, canvas.width, canvas.height)
//   context.beginPath();
//   context.arc(x, y, r, 0, Math.PI * 2);
//   context.fillStyle = "blue";
//   context.fill();
//   x += dx;
//   y += dy;

//   if (x + r > canvas.width || x - r < 0) {
//     dx = -dx;
//     updateCounter();
//   }

//   if (y + r > canvas.height || y - r < 0) {
//     dy = -dy;
//     updateCounter();
//   }
// }

// function updateCounter() {
//   counterDiv.textContent = `Edge Hits: ${++counter}`
// }

// setInterval(animate, 16);

// ==============================================

// JS Apis : local storage


// function saveData() {
//   localStorage.username = "mona";
//   localStorage["pass"] = "555";
//   localStorage.setItem("email", "mona@gmail.com");
//   localStorage.setItem("grades", [90, 50, 30, 60, 70])
// }




// function getData() {
//   console.log(localStorage["username"]);
//   console.log(localStorage.pass);
//   console.log(localStorage.getItem("email"));
//   console.log(localStorage.grades.split(",").map(Number));

// }

// function removeItem() {
//   localStorage.removeItem("email")
// }


// function removeAll() {
//   localStorage.clear();
// }



// Session storage
// function saveData() {
//   sessionStorage.username = "mona";
//   sessionStorage["pass"] = "555";
//   sessionStorage.setItem("email", "mona@gmail.com");
//   sessionStorage.setItem("grades", [90, 50, 30, 60, 70])
// }




// function getData() {
//   console.log(sessionStorage["username"]);
//   console.log(sessionStorage.pass);
//   console.log(sessionStorage.getItem("email"));
//   console.log(sessionStorage.grades.split(",").map(Number));

// }

// function removeItem() {
//   sessionStorage.removeItem("email")
// }


// function removeAll() {
//   sessionStorage.clear();
// }


// ==================================


// navigator.geolocation.getCurrentPosition(success, error);

// function success(pos) {
//   console.log(pos.coords.latitude, pos.coords.longitude);
// }

// function error(e) {
//   alert(e.message);

// }


// =========================================

function getPosition(countryName) {
  // Create request

  var request = new XMLHttpRequest();

  // Define request 

  request.open("GET", `https://nominatim.openstreetmap.org/search?format=json&q=${countryName}`);

  // Send Request

  request.send();


  request.onload = function () {
    var data = JSON.parse(request.response);
    console.log(data[0].lat, data[0].lon);
  }


}


getPosition("Egypt")
getPosition("Canada")
getPosition("USA")





