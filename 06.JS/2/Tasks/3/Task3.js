function calculate(arr , operand){
    var ans = 0;
    switch (operand){
        case '+' : 
            for(var i = 0 ; i<arr.length;i++) ans+=arr[i]; break;
            case '*': ans = 1; for(var i = 0 ; i<arr.length;i++) ans*=arr[i]; break;
            case '/': ans = arr[0] / arr[1] ; for(var i = 2 ; i<arr.length;i++) ans/=arr[i]; break; 
    }
    return ans;
}

function formatNumber(num) {
    return Number.isInteger(num) ? num.toString() : num.toFixed(2);
}

function main(){

    document.writeln("<h1>Adding -- Multilpying -- and dividing 3 values </h1>")
    
    var arr = [];
    zero = false;
    for(var i = 0 ; i<3;i++){
            var value;
            do{
                value = prompt(`Enter Value #${i+1} except 0`)
            }while(isNaN(value) || Number(value) == 0)
            arr.push( Number (value));
        }
        var ans = 0 ; 

        
        var txt = `of the ${arr.length} values `;
        var operations = ["Sum ","Multiplication ","Division "];
        var operands = ['+','*','/'];
        
        for(var i = 0 ; i<arr.length;i++){
            ans = calculate(arr,operands[i]);
            var values = "";
            txt = operations[i] + `of the ${arr.length} values `;
            for(var x = 0 ; x<arr.length;x++){
                values+=arr[x]+" ";
                if(x!=arr.length-1) values+=operands[i]+" ";
            } 
            document.writeln(`<h2 style="color:red; display: inline-block;"> ${txt} </h2> <h2 style=" display: inline-block;"> ${values} = ${formatNumber(ans)} </h2><br>`)
            
        }
        
    }

    main();

