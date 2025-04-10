var flag = false;
var value
do{
     value = prompt("Enter value")
     if (typeof value == "string" && value.length == 0) value="abc";
}while(isNaN(value)  )

    var ans;

if(value%3==0){
    if(value%5==0) ans = "Fizz Buzz" 
    else ans="Fizz"
}
else if (value%5==0) 
    ans="Buzz";
else
ans = "none";

document.writeln(`<h1>${ans}</h1>`)