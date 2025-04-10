function isPalindrome(str){
   
   
    n = str.length
    for(var i = 0 ; i<n/2;i++) if(str[i]!=str[n-1-i]) return false;
    return true;
}


var input = prompt("Enter text")
var funparam;
var caseSenstive;
    caseSenstive = confirm("Do you want to consider case senstive characters?")
funparam = input;
    if(!caseSenstive) funparam = funparam.toLowerCase();
ans = isPalindrome(funparam)?"Palindrome":"Not plaindrome";
document.writeln(`<h1> ${input} is ${ans} </h1>`)



   /*
    N = 5
   n        n-1-i
   0        5-1-0=4
   1        5-1-1=3
   2        5-1-2=2
   

    N = 4 
   n        n-1-i
   0        4-1-0=3
   1        4-1-1=3
    
   */
