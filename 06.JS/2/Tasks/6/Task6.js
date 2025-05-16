function applyoperations(number1 , number2 , myFunction){
    return myFunction(number1,number2);
}


function add(n1,n2){
    return Number(n1) + Number(n2) +` (${n1} + ${n2})`;
}


function multiply(n1,n2){
    return Number(n1) * Number(n2) +` (${n1} * ${n2})`;
}


function division(n1,n2){
    return Number(n1) / Number(n2) +` (${n1} / ${n2})`;
}


function subtraction(n1,n2){
    return Number(n1) - Number(n2) +` (${n1} - ${n2})`;
}


console.log(applyoperations(5,3,add));
console.log(applyoperations(5,3,subtraction));
console.log(applyoperations(5,3,division));
console.log(applyoperations(5,3,multiply));