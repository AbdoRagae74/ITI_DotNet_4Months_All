var sum=0;
var cnt=0;
var response;
do{

    response = prompt("Enter number to add to summation or 0 to exit");
    // To ignore the empty string from being converted to 0 and exit loop
    if (typeof response == "string" && response.length == 0)
         {response=-1;
             continue;
            }
    if(!isNaN(response)){
        sum += Number(response) 
        cnt++;
    }

} while( sum<100 && response!=0 )

document.writeln(`<h1>You entered ${cnt} valid numbers and their sum = ${sum}</h1>`)