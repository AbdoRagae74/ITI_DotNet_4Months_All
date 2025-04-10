var exDate = new Date();
exDate.setDate(exDate.getDate() + 1);
var oldDate = exDate;
oldDate.setFullYear(2020);
websiteCookies= allCookieList(1);

if(websiteCookies.length!=0) location.replace("Registered.html");
function getCookie(cookieName) {
    for (var i = 0; i < websiteCookies.length; i++) 
        if (websiteCookies[i] == cookieName) 
            return `Cookie ${cookieName} found`;

    return `Cookie ${cookieName} not found`;
}
function setCookie(cookieName, cookieValue, expiryDate) {
    // Reset all cookies in our array
    websiteCookies.length = 0; 
    document.cookie = `${cookieName}=${cookieValue};expires=${expiryDate}`;
    tempCookies = document.cookie.split(";");
    for(var i = 0 ; i<tempCookies.length;i++){
        var cookie = tempCookies[i].split("=");
        // add new cooike name to all cookies
        if(tempCookies[i]!='')
        websiteCookies.push(cookie[0].trim()); 
    }

//   console.log(websiteCookies);

}

function deleteCookie(cookieName) {

    setCookie(cookieName, "S", oldDate);
}
function allCookieList(type) {
    //type 1 return array else return object
    tempCookies = document.cookie.split(";");

    var list = [];    
    for (var i = 0; i < tempCookies.length; i++) {
        var cookie = tempCookies[i].split("=");
        if(cookie[i]=='') continue;
        if(type!=1)
            list.push({ name: cookie[0].trim(), value: cookie[1] });
        else
            list.push(cookie[0]);
    }
    return list;

}

function hasCookie(cookieName) {

    var res = getCookie(cookieName);
    if (res != `Cookie ${cookieName} not found`) {
        console.log(`Cookie ${cookieName} Found`)
    }
    else
        console.log(res);
}


// var reg = document.getElementById("register");
// var abc = document.getElementById("name").value;
// var age = document.getElementById("age").text;
// var gender = document.getElementById("gender").value;

var reg = document.getElementById("register");
reg.addEventListener("click", function (e) {
    //     e.preventDefault();
    var userName = document.getElementById("name").value;
    var userColor = document.getElementById("color").value;
    var userGender = document.querySelector('input[name="gender"]:checked')?.value;
    setCookie("UserName",userName);
    var welcom = `Welcome <span style="color:${userColor}">${userName}</span>`;
    localStorage.setItem('welcomeMessage', welcom);
    localStorage.setItem('img', userGender);
    localStorage.setItem('cnt','0');
    location.replace("Registered.html");

    // deleteCookie("UserName");



    
})

