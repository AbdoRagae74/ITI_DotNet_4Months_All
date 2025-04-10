
var numInpt = document.getElementById("numInp");

function up() {
  numInpt.stepUp(10);
}

function down() {
  numInpt.stepDown(5);
}

// ===========================


var span = document.getElementById("rangeVal");
var range = document.getElementById("rangeInp");

range.addEventListener("input", function () {
  span.innerText = range.value
})


var username = document.getElementById("username");
function updateVal() {

  username.value = "Omar"
}

// =================================


var audio = document.querySelector("audio");
var volumeInp = document.getElementById("volumeInp")
var timeInp = document.getElementById("timeInp")
var speed = document.getElementById("speed")

function playAud() {
  audio.play();
}
function pauseAud() {
  audio.pause();
}
function stopAud() {
  audio.load();
  audio.pause();
}
function muteAud() {
  audio.muted = !audio.muted;
}

function test() {
  console.log(audio.duration);
}

volumeInp.addEventListener("input", function () {
  audio.volume = volumeInp.value;

})

window.onload = function () {
  timeInp.max = audio.duration
}

timeInp.addEventListener("input", function () {


  audio.currentTime = timeInp.value;
})

audio.addEventListener("timeupdate", function () {
  timeInp.value = audio.currentTime;
})


speed.addEventListener("change", function () {
  audio.playbackRate = speed.value;
})