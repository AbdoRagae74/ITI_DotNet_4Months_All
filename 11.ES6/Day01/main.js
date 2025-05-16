// ========== 1 ========
// let x = 5;
// let y = 10;
// console.log("Before");
// console.log(`X = ${x}`);
// console.log(`Y = ${y}`);
// [x,y] = [y,x];
// console.log("After");
// console.log(`X = ${x}`);
// console.log(`Y = ${y}`);


// ================ 2 ==============

var numbers = [9,5,6,1,3,2,5]

function getMinMax(...arr){
    arr = arr.sort(function(a,b){return a-b;});
    var mn ;
    var mx;
    [mn,mx] = [Math.min(...arr),Math.max(...arr)]
    return [mn,mx];
}
let[min,max] = getMinMax(...numbers);
console.log(min);
console.log(max);

// ========== 3 ========


var fruits = ["apple", "strawberry", "banana", "orange", "mango"]
// 3.a
var res = fruits.every ((value)=>{
     return typeof value =="string"
    }
    );
console.log(res);


// 3.b
var res2 = fruits.some ((value)=>{
    return typeof value .startsWith("a")
   }
   );
console.log(res2);

// 3.c
var res3 = fruits.filter ((value)=>{
    return value.startsWith("b") || value.startsWith("s");
   }
   );
console.log(res3);

// 3.d
var res4 = fruits.map((value)=>{
    return (`I Love ${value}`);
   }
   );
console.log(res4);

// 3.e
res4.forEach((value)=>{
    console.log(value);
   }
   );


// ========== 4 ========

var nums = [2,-5,2,9,8,7];

function getPositives(arr){
    var ans = []
    arr.forEach((value)=>{
        if(value>0) ans.push(value);
    });
    return ans;
}
var a = getPositives(nums);
console.log(nums);

// ========== 5 ========


function sumArray(arr){

    var sum = arr.reduce( (x,y)=>{
        return x+y;
    })
    return sum;
}

var sum = sumArray(nums);
console.log(sum);

// ========== 6 ========

var names = ["ahmed","ali","sameh","heba","khaled"];
function capitalize(arr){
    var ans =[];
    arr.forEach((name)=>{
        ans.push(name[0].toUpperCase()+name.slice(1));
    });
    return ans;
}
var capitalizedNames = capitalize(names);
console.log(capitalizedNames);

// ========== 7 ========

let str = "HELLOWORDL";
console.log(str.toUpperCase() == str?"Capitaliezed":"Not capitalized");

// ========== 8 ========

    var filterArr = (strArr,len)=>{
        return strArr.filter( (item)=>{
            return item.length > len;
    })
    };


var stringArr = ["avfg","dsadsad","a","dsad","sw"];

    console.log(filterArr(stringArr,3));