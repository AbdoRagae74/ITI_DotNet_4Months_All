var numbers =[1,2,3,4,5];

function processArray(numbers , square){
    for(var i = 0 ; i<numbers.length;i++)
    numbers[i] = square(numbers[i]);    
}
function square(n){
    return n*n;
}

processArray(numbers,square);

txt = "[";
for(var i = 0 ; i<numbers.length;i++) txt+=Number(numbers[i])+",";
txt += "]";

document.writeln(`<h1>Squared array = ${txt}</h1>`);


















