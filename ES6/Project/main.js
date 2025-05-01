import { User } from "./utils.js";

if(localStorage.getItem("currentUserName")!="NULL")  location.replace("homepage.html");
var loginButton = document.querySelector("#loginBtn");
var emailInp = document.querySelector("#email");
var passwordInp = document.querySelector("#password");

loginButton.addEventListener("click", (e) => {
    e.preventDefault();
    let uName;
    let usersData = JSON.parse(localStorage.getItem("users")) || [];
    usersData = usersData.map(user => User.fromObject(user));
    var existingUser = false;
    let mail = emailInp.value;
    let pass = passwordInp.value;
    usersData.forEach(element => {
        if (element.checkUser(mail, pass)) {
            existingUser = true;
            uName = element.name;
            return;
        }
    });

    if (existingUser) {
        
        location.replace("homepage.html");
        localStorage.setItem("currentUser", mail);
        localStorage.setItem("currentUserName",uName);

    }

    else alert("Please login with valid data")


})