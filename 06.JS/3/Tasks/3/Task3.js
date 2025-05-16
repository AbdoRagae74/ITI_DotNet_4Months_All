function getMinMax(numbers){
    var ans =[];
    numbers.sort(function(a,b) {return a-b});
    for(var i = 1 ; i<numbers.length;i++)
         if(numbers[i]!=numbers[0]) {
            ans.push(numbers[i]);
             break;
            }
    for(var i = numbers.length-2 ; i>=0;i--)
        if(numbers[i]!=numbers[numbers.length-1]) {
            ans.push(numbers[i]);
            break;
            }
    return ans;

}



var numbers = [5,4,3,2,9,6,-1]
var ans = getMinMax(numbers);
document.writeln(`Sorted array ==> ${numbers} <br> `);
document.writeln(`Second minimum ==> ${ans[0]} <br>  `);
document.writeln(`Second maximum ==> ${ans[1]} <br> `);

// if(ans.length==0){
//     ans.push(numbers[0]);
//     ans.push(numbers[0]);
// }