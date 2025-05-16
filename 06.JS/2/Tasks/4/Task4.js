var arr = [];


for(var i = 0 ; i<5;i++){
    var value;
    do{
        value = prompt(`Enter Value #${i+1}`)
    }while(isNaN(value))
        arr.push( Number (value));
    }

var txt="" ;

for(var i = 0 ; i < arr.length;i++) txt+=arr[i]+" , ";
txt = txt.slice(0, -2); 

document.writeln(`<h1>U Entered ${txt}</h1>`)
txt="";

arr.sort(  function (a,b) { return a-b } )
for(var i = 0 ; i < arr.length;i++) txt+=arr[i]+" , ";
txt = txt.slice(0, -2); 
document.writeln(`<h1>Descending ${txt}</h1>`)

txt ="";
arr.sort(  function (a,b) { return b-a } )
for(var i = 0 ; i < arr.length;i++) txt+=arr[i]+" , ";
txt = txt.slice(0, -2); 
document.writeln(`<h1>Ascending ${txt}</h1>`)

