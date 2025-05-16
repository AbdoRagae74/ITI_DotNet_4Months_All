

navigator.geolocation.getCurrentPosition(success, error)

var lat, lng;
function success(pos) {
  lat = pos.coords.latitude;
  lng = pos.coords.longitude;
  initMap(lat, lng)
}

function error(e) {
  alert(e.message)
}


function initMap(myLat, mylng) {
  const myLatLng = { lat: myLat, lng: mylng };
  const map = new google.maps.Map(document.getElementById("map"), {
    zoom: 15,
    center: myLatLng,
  });

  new google.maps.Marker({
    position: myLatLng,
    map,
    title: "Hello World!",
  });
}

window.initMap = initMap;