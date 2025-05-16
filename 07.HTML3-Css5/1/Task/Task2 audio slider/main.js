const audios = ["media/Anitek_-_Komorebi.mp3","media/nokia.m4a","media/ring2.m4a"];
var aud = document.getElementById("current-audio");
var rangeAudio = document.getElementById("audio-time")
var rangeVolume = document.getElementById("audio-volume")
var speed = document.getElementById("audio-speed");
function play(){
    aud.play();
}
function pause(){
    aud.pause();
}
function stop(){
    aud.load();

}
function mute(){
    aud.muted = !aud.muted;
}

function nxt (num){
    var x = document.getElementById("current-audio").getAttribute("src"); 
    var idx = audios.indexOf(x);
    var len = audios.length;
     idx = idx+num;
     idx = ((idx%len)+len)%len ;
    aud.setAttribute("src",audios[idx]);
    aud.play();
    rangeAudio.max = aud.duration;
}

window.onload = function(){
    rangeAudio.max = aud.duration;
}


rangeAudio.addEventListener("input",function(){
    aud.currentTime = rangeAudio.value;
})
aud.addEventListener("timeupdate",function(){
     rangeAudio.value = aud.currentTime;
})

aud.addEventListener("ended",function(){
    nxt(1);
})
speed.addEventListener("input", function(){
    aud.playbackRate = speed.value
})

rangeVolume.addEventListener("input",function(){
    aud.volume = rangeVolume.value;
})
