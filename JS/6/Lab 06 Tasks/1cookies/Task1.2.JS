    var msgId = document.getElementById("msg");
    var gender = localStorage.getItem('img') ;
    var img = document.getElementsByClassName("user-img")[0];
    var cnt = parseInt(localStorage.getItem("cnt")) ||0;
    cnt++;
    localStorage.setItem('cnt', cnt);
    console.log(cnt);
    console.log(gender);
    msgId.innerHTML = localStorage.getItem('welcomeMessage') + " U entered this site "+cnt+" times"  ;
    if(gender=='f') 
        img.setAttribute("src","2.jpg")
