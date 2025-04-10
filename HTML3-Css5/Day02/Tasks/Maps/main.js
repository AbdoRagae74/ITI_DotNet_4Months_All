var mySelect = document.getElementById("countries");
var map;
var marker;



mySelect.addEventListener("change",function(){
  getPosition(mySelect.value);
})

function updateMap(myLat , myLong) {
  var myLatLng = { lat: myLat, lng: myLong };
console.log(myLat,myLong);
  map = new google.maps.Map(document.getElementById('map'), {
    zoom: 5,
    center: myLatLng,
  });

marker = new google.maps.Marker({
    position: myLatLng,
    map: map,
    title: 'Selected Location',
  });
}


function getPosition(country){
  var request = new XMLHttpRequest();
  request.open("GET",`https://nominatim.openstreetmap.org/search?format=json&q=${country}`);
  request.onreadystatechange = function(){
    if(request.readyState ===4 && request.status===200){
      var data = JSON.parse(request.responseText);

      var lat = parseFloat(data[0].lat);
      var lon = parseFloat(data[0].lon);
      updateMap(lat,lon);
    }
  };
  request.send();  

}



