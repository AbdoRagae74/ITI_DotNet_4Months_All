var name = prompt("Your name");
var phoneNumber="";
do{
    var phoneNumber = prompt("Enter your phone number [8 digits]");
}while(phoneNumber.length!=8)

var mobileNumber="";
var mobRegex = /(010|011|012)/
do{
    var mobileNumber = prompt("Enter your mobile number [11 digits]");
    console.log(mobRegex.test(mobileNumber))
}while( !(mobRegex.test(mobileNumber) && mobileNumber.length==11))

var email="";
var validmail=false;
var emailRegex = /^[A-Za-z]{3,}[a-zA-Z0-9._-]*@[a-zA-Z0-9._-]+\.[a-zA-Z]{2,}$/  
do{
    txt = "Enter your email";
    if(!validmail) txt="Please enter valid email";
    var email = prompt(txt);
    validmail = emailRegex.test(email);
}while(!validmail)

    var color = 0;
    do{
        color = prompt("Enter your favourite color 1 for red 2 for green or 3 for blue");
    }while(!(color>0 && color<4))
    
        color = color==1?"red":color==2?"green":"blue";

    document.writeln(`<h3 style="color:${color}; display: inline-block; " >Welcom dear guest</h3> <h3 style=" display: inline-block; " > ${name}</h3> <br> `);
    document.writeln(`<h3 style="color:${color}; display: inline-block; " >Your phone number is</h3> <h3 style=" display: inline-block; " > ${phoneNumber}</h3> <br> `);
    document.writeln(`<h3 style="color:${color}; display: inline-block; " >Your mobile number is</h3> <h3 style=" display: inline-block; " > ${mobileNumber}</h3> <br> `);
    document.writeln(`<h3 style="color:${color}; display: inline-block; " >Your E-mail address is</h3> <h3 style=" display: inline-block; " > ${email}</h3> <br> `);
    
      
