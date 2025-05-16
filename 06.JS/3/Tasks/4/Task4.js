var str = prompt("Enter text");
strSplitted = str.split(" ");
str = "";

for(var i = 0 ; i < strSplitted.length;i++){
    str += strSplitted[i][0].toUpperCase() + strSplitted[i].substring(1);
    str+=" ";
}

document.writeln(`<h1>Capitalized word => ${str}</h1>`)