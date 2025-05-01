//Task1 Proxy

var user ={
    name:"Ali",
    address:"Alex",
    age:27
}

var handleObject = {
    set(obj,prop,value){
        
        if(prop=="name"){
            if(value.length!=7)
                throw new "Name must be of exactly 7 characters";
            else obj[prop] = value;
        }
       
        if(prop=="address"){
            if(typeof value != typeof("abc"))
                throw new "Address must be of type string";
            else obj[prop] = value;
        }

        if(prop=="age"){
            if(value >60 || value < 25 )
                throw new "Age must be between 25 and 60";
            else obj[prop] = value;
        }
        return true;

    },
    
}
var person = new Proxy({}, handleObject);
// person.age=24; Error
person.age=25;
// person.name="Ahmed"; //Error
person.name="Mohamed";

// person.address=12; // Error
person.address="Alex"; 



console.log(person);
//Task 2 Inheritance 

import { Rect, Square, Circle } from './modules.js';
let r1 = new Rect(3, 8);
let s1 = new Square(3);
let c1 = new Circle(5);






//Task 3
//Type 1 => count
//Type 2 => Max value

// function* fib(num, type) {
//     var a = 0, b = 1;
//     if (type == 1) {
//         for (var i = 0; i < num; i++) {
//             if (i < num);
//             yield a;
//             [a, b] = [b, a + b];
//         }
//     }
//     else {
//         for (var i = 0; i < num; i++) {
//             if (a < num)
//             yield a;
//             [a, b] = [b, a + b];
//         }
//     }
// }

// for (var i of fib(18, 1)) {
//     console.log(i);
// }



//Task 4 
//Object using function expression (Generic)
var obj = {
    name :"ali",
    age:24,
}

var obj2 = {
    name :"ahmed",
    age:23,
}

obj[Symbol.iterator] = getObjectPairs;
obj2[Symbol.iterator] = getObjectPairs;


console.log("Key  =>  Value");
for(var i of obj2)
{
    console.log(i," => ",obj2[i]);
}

for(var i of obj)
{
    console.log(i," => ",obj[i]);
}


function getObjectPairs(){
    let keys = Object.keys(this);    
    let i = 0;
    return {
        next :  function() {

            for(i;i<keys.length;){
                return {value:keys[i++],done:false};
            }
            return {value:undefined,done:true};


        },
    }

}

// array using Generator function (Generic)

let arr=[1,2,3,4,5,6,"Ahmed","Mona"];

let arr2=["Ahmed","Mona","SLLL"];

arr[Symbol.iterator] = generatorArrValues;

arr2[Symbol.iterator] = generatorArrValues;

for(var i of arr2) console.log(i);

function* generatorArrValues(){
    for(var i = 0 ; i<this.length;i++)
        yield this[i];
}

