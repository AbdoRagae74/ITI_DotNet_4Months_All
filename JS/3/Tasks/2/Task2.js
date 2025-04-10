var radius = prompt("Enter circle's radius");
var circleArea = Math.PI * Math.pow(radius,2);
circleArea = circleArea.toFixed(3);
document.writeln(`<h1> Area = ${circleArea} </h1>`);

var val = prompt("Enter value to calculate its square root");
var pow = Math.pow(val,2);
document.writeln(`<h1> square root of ${val} = ${pow} </h1>`);



var val = prompt("Enter an angle to calculate its cos");
console.log(val);
var cos = Math.cos(val*(Math.PI/180))  ;
document.writeln(`<h1> Cos ${val} => ${cos} </h1>`);