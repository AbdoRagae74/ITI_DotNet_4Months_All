
function get2ParamsOnly(){
    if(arguments.length!=2)
        throw new Error("Please Enter 2 numbers only");
}


// error if data type not number or with 0 parameters 
function otherCondition (){
    if(arguments.length==0) 
        throw new Error("Please Enter at least 1 number");
    var result = Number(0);
    for(var i = 0 ;i<arguments.length;i++)
        if(typeof arguments[i] != typeof result) 
            throw new Error("All parameters must be numbers");
        else result+=arguments[i];

return result;
}

// 0 parameters error
console.log(otherCondition())

//Works good
console.log(otherCondition(2,3,4));
//Error
console.log(otherCondition(2,3,"4"));