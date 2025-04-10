var submitButton = document.getElementById("submit");


function checkName(){
    var nameValue = document.getElementById("name").value;
    var error = document.getElementById("errorName");
    nameValue = nameValue.trim();
    if(nameValue.length<1) {
        error.setAttribute("style","color:red")
        error.classList.remove('hidden');
        return false;
    }
    error.classList.add('hidden');
    return true;
}

function checkEmail(){
    var emailValue = document.getElementById("email").value;
    var error = document.getElementById("errorEmail");
    emailValue = emailValue.trim();
    var regex = /^[A-Za-z0-9._%+-]+@[A-Za-z0-9-]+\.[A-Za-z]{2,}$/;
    if(emailValue.length<1 || !regex.test(emailValue) ) {
        error.setAttribute("style","color:red")
        error.classList.remove('hidden');
        return false;
    }
    error.classList.add('hidden');
    return true;
}
function checkPassword(){
    var passwordValue = document.getElementById("password").value;
    var error = document.getElementById("errorPassword");
    passwordValue = passwordValue.trim();
    if(passwordValue.length<8 ) {
        error.setAttribute("style","color:red")
        error.classList.remove('hidden');
        return false;
    }
    error.classList.add('hidden');
    return true;
}
function checkGender(){
    var genderValue = document.querySelector('input[name="gender"]:checked')?.value;
    var error = document.getElementById("errorGender");
    console.log(genderValue);
    if(!genderValue) {
        error.setAttribute("style","color:red")
        error.classList.remove('hidden');
        return false;
    }
    error.classList.add('hidden');
    return true;
}

function checkGender(){
    var sportsLen = document.querySelectorAll('input[type="checkbox"]:checked').length;
    var error = document.getElementById("errorSport");
    if(sportsLen<2) {
        error.setAttribute("style","color:red")
        error.classList.remove('hidden');
        return false;
    }
    error.classList.add('hidden');
    return true;
}

function checkCountry(){
    var countryValue = document.getElementById('country').value;
    var error = document.getElementById("errorCountry");
    if(countryValue=="abc") {
        error.setAttribute("style","color:red")
        error.classList.remove('hidden');
        return false;
    }
    error.classList.add('hidden');
    return true;
}




function validateInputs(){
    var checking = checkName();
    checking = checking && checkEmail();
    checking = checking&& checkPassword();
    checking = checking&&checkGender();
    checking = checking&&checkGender();
    checking = checking&&checkCountry();
    if(checking) alert("Account created successfully")
}
function resetInputs(){
    var errors = document.getElementsByClassName("a");
    for(var i = 0 ; i<errors.length;i++) errors[i].classList.add('hidden');
    document.getElementById("name").value="";
    document.getElementById("email").value ="";
    document.getElementById("password").value ="";
    var radios = document.getElementsByName("gender");
    for (var i = 0; i < radios.length; i++) {
        radios[i].checked = false; 
      }
      
      var selectElement = document.getElementById("country");
      selectElement.selectedIndex = "0"; 

      let checkboxes = document.querySelectorAll('input[type="checkbox"]');
      for (var i = 0; i < checkboxes.length; i++) {
        checkboxes[i].checked = false;  
      }
}
